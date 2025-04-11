using Microsoft.AspNetCore.Mvc;
using NFeSPEDAPI.Services;

namespace NFeSPEDAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NFeController : ControllerBase
{
    private readonly INFeService _nfeService;

    public NFeController(INFeService nfeService)
    {
        _nfeService = nfeService;
    }

    [HttpPost("importar")]
    public async Task<IActionResult> ImportarNFe(IFormFile arquivo)
    {
        if (arquivo == null || arquivo.Length == 0)
            return BadRequest("Arquivo XML não fornecido ou vazio.");

        try
        {
            var nfe = await _nfeService.ProcessarXmlNFeAsync(arquivo);
            var nfeSalva = await _nfeService.SalvarNFeAsync(nfe);
            return Ok(nfeSalva);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao importar NFe: {ex.Message}");
        }
    }

    [HttpGet("consultar/{chaveAcesso}")]
    public async Task<IActionResult> ConsultarNFe(string chaveAcesso)
    {
        try
        {
            var nfe = await _nfeService.ObterNFePorChaveAsync(chaveAcesso);

            if (nfe == null)
                return NotFound($"NFe com chave {chaveAcesso} não encontrada.");

            return Ok(nfe);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao consultar NFe: {ex.Message}");
        }
    }

    [HttpGet("listar")]
    public async Task<IActionResult> ListarNFes([FromQuery] DateTime? dataInicial, [FromQuery] DateTime? dataFinal)
    {
        try
        {
            var nfes = await _nfeService.ListarNFesAsync(dataInicial, dataFinal);
            return Ok(nfes);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao listar NFes: {ex.Message}");
        }
    }
}