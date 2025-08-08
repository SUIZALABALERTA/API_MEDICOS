using Application.Common;
using Application.Interfaces.IRepository;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using System.Net.Sockets;

namespace Infrastructure.Repositories;


public class AtencionesRepository : IAtencionesRepository
{

    private readonly SuizasoftContext _context;

    private readonly IMapper _mapper;
    private readonly string connectionString;


    public AtencionesRepository(SuizasoftContext dataContext, IMapper mapper, IConfiguration configuration)
    {
        _context = dataContext;
        _mapper = mapper;
        this.connectionString = configuration.GetConnectionString("PostgresSQLConnection");

    }

    public async Task<(ServiceStatus, string, object)> GetAtenciones(string value, string startDate, string endDate, int idMedico, int page, int amount)
    {
        if (!DateTime.TryParse(startDate, out DateTime start))

            return (ServiceStatus.FailedValidation, $"Error en formato de fecha - {startDate}", null);

        if (!DateTime.TryParse(endDate, out DateTime end))

            return (ServiceStatus.FailedValidation, $"Error en formato de fecha - {endDate}", null);

        long result;

        var isNumeric = long.TryParse(value, out result);

        DataCollection<OrdenServicioCabeceraDTO> entidades = new();

        try
        {
            entidades = await _context.MstOrdenServicioCabeceras.AsNoTracking()
                                                                .Where(p => p.OrsIdMedico == idMedico)
                                                                .Where(p => p.OrsFechaRegistro.Value.Date >= start.Date && p.OrsFechaRegistro.Value.Date <= end.Date)
                                                                .WhereIf(!string.IsNullOrEmpty(value) && !isNumeric, p => p.OrsIdPacienteNavigation.PacNombre.Contains(value) ||
                                                                                                                  p.OrsIdPacienteNavigation.PacApellidoPaterno.Contains(value) ||
                                                                                                                  p.OrsIdPacienteNavigation.PacApellidoMaterno.Contains(value))
                                                                .WhereIf(isNumeric, p => p.OrsIdPacienteNavigation.PacNumeroDocumento.Contains(result.ToString()))
                                                                .OrderByDescending(p => p.OrsFechaRegistro)
                                                                .ProjectTo<OrdenServicioCabeceraDTO>(_mapper.ConfigurationProvider)
                                                                .GetPagedAsync(page, amount);

            if (entidades == null) return (ServiceStatus.NotFound, "No se encontraron registros", null);

            List<DetOrdenServicioDetalle> lista = new();

            foreach (var item in entidades.Items)
            {

                var detalles = await _context.DetOrdenServicioDetalles.AsNoTracking()
                                                                     .Where(p =>
                                                                                 p.OrdIdNumeroCab == item.OrsId &&
                                                                                 p.OrdPeriodo == item.OrsPeriodo &&
                                                                                 p.OrdAnio == item.OrsAnio &&
                                                                                 p.OrdIdSucursal == item.OrsIdSucursal)
                                                                     .ToListAsync();
                item.Detalles = detalles;

                var ticket = item.OrsId.ToString() + item.OrsPeriodo.ToString() + item.OrsAnio.ToString() + item.OrsIdSucursal.ToString();

                using var connection = new NpgsqlConnection(connectionString);

                string query = "suizasoft.func_get_detalle_orden_result";

                var response = (await connection.QueryAsync<OrderResultDetailDto>(query, new
                {
                    p_ticket = ticket

                }, commandType: CommandType.StoredProcedure)).ToList();

                item.DetalleExamenes = response;

            }
        }
        catch (Exception e)
        {
            return (ServiceStatus.InternalError, e.Message, null);
        }
        var responses = "succeeded" + $"{startDate}" + $"{endDate}";

        return (ServiceStatus.Ok, responses, entidades);

    }


}
