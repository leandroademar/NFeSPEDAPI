using Microsoft.AspNetCore.Mvc;
using NFeSPEDAPI.Services;

namespace NFeSPEDAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpedController : ControllerBase
{
    private readonly ISpedService _spedService;

    public SpedController(ISpedService spedService)
    {
        _spedService = spedService;
    }

    [HttpPost("importar")]
    public async Task<IActionResult> ImportarSped(IFormFile arquivo)
    {
        if (arquivo == null || arquivo.Length == 0)
            return BadRequest("Arquivo SPED não fornecido ou vazio.");

        try
        {
            var sped = await _spedService.ProcessarArquivoSpedAsync(arquivo);
            var spedSalvo = await _spedService.SalvarSpedAsync(sped);
            return Ok(spedSalvo);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao importar SPED: {ex.Message}");
        }
    }

    [HttpGet("consultar/{id}")]
    public async Task<IActionResult> ConsultarSped(Guid id)
    {
        try
        {
            var sped = await _spedService.ObterSpedPorIdAsync(id);
            
            if (sped == null)
                return NotFound($"SPED com ID {id} não encontrado.");
            
            return Ok(sped);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao consultar SPED: {ex.Message}");
        }
    }

    [HttpGet("listar")]
    public async Task<IActionResult> ListarSped([FromQuery] DateTime? dataInicial, [FromQuery] DateTime? dataFinal)
    {
        try
        {
            var speds = await _spedService.ListarSpedAsync(dataInicial, dataFinal);
            return Ok(speds);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao listar SPEDs: {ex.Message}");
        }
    }
}