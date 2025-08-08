using Application.Interfaces.IServices;
using Domain.Models;
using Domain.Payloads;
using Microsoft.AspNetCore.Mvc;

namespace SUIZASOFT_MEDICOS.Controllers;

[Route("api/medic")]
[ApiController]
public class MedicController : ControllerBase
{
    private readonly IMedicoService _medicoService;


    public MedicController(IMedicoService medicoService)
    {
        _medicoService = medicoService;
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchMedicoAsync(
        [FromQuery] string value,
        [FromQuery] string records,
        [FromQuery] int? idTipoMedico,
        [FromQuery] List<int> idEspecialidades,
        [FromQuery] int? page = 1,
        [FromQuery] int? amount = 10
        ) => Ok(await _medicoService.SearchMedico(value, page.Value, amount.Value, records, idTipoMedico.GetValueOrDefault(), idEspecialidades));

    [HttpGet("searchdatos")]
    public async Task<IActionResult> SearchMedicodatosAsync(
       [FromQuery] string ColegioCodigo,
       [FromQuery] string NombreCompleto,
       [FromQuery] string ApellidoPaterno,
       [FromQuery] string ApellidoMaterno,
       [FromQuery] string value,
       [FromQuery] string records,
       [FromQuery] int? page = 1,
       [FromQuery] int? amount = 10
       ) => Ok(await _medicoService.SearchMedicodatosAsync(ColegioCodigo, NombreCompleto, ApellidoPaterno, ApellidoMaterno, value, page.Value, amount.Value, records));

    [HttpGet]
    [Route("{numdoc}")]
    public async Task<IActionResult> GetMedicoAsync(string numdoc) => Ok(await _medicoService.GetMedico(numdoc));

    [HttpGet("roles")]
    public async Task<IActionResult> GetMedicoRoles() => Ok(await _medicoService.GetRoles());


    [HttpPost("create")]
    public async Task<IActionResult> CreateMedicoAsync(CreateMedicoPayload data) => Ok(await _medicoService.CreateMedico(data));


    [HttpPut("update")]
    public async Task<IActionResult> UpdateMedicoAsync(UpdateMedicoPayload data) => Ok(await _medicoService.UpdateMedico(data));


    [HttpPut("image-profile")]
    public async Task<IActionResult> UpdateImage(Attachment request) => Ok(await _medicoService.UpdateImage(request));

}
