using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SUIZASOFT_MEDICOS.Controllers;

[Route("api/medic/attentions")]
[ApiController]
public class AttentionsController : ControllerBase
{
    private readonly IAtencionesService _atencionesService;

    public AttentionsController(IAtencionesService atencionesService)
    {
        _atencionesService = atencionesService;
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> SearchMedicoAsync([FromQuery] string value, string startDate, string endDate, int idMedico, int page, int amount)
        => Ok(await _atencionesService.GetAtenciones(value, startDate, endDate, idMedico, page, amount));

}
