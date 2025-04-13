using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NFeSPEDAPI.Services;

namespace NFeSPEDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpedController : ControllerBase
    {
        private readonly ISpedService _spedService;
        private readonly ILogger<SpedController> _logger;

        public SpedController(ISpedService spedService, ILogger<SpedController> logger)
        {
            _spedService = spedService;
            _logger = logger;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadAndProcess(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Arquivo não fornecido ou vazio");

            try
            {
                // Abordagem segura: salvar o arquivo em um local temporário
                var tempFilePath = Path.GetTempFileName();
                
                try
                {
                    // Cria uma cópia do arquivo no sistema de arquivos
                    using (var stream = new FileStream(tempFilePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    
                    // Agora podemos abrir e ler o arquivo quantas vezes for necessário
                    
                    // Primeiro, lemos apenas o CNPJ
                    string cnpj;
                    using (var stream = new FileStream(tempFilePath, FileMode.Open, FileAccess.Read))
                    {
                        cnpj = await _spedService.ObterCNPJDoArquivoAsync(stream);
                    }
                    _logger.LogInformation("Processando arquivo SPED do CNPJ: {CNPJ}", cnpj);
                    
                    // Em seguida, processamos o arquivo completo
                    var result = await _spedService.ProcessarArquivoSpedAsync(tempFilePath);
                    
                    if (result.Sucesso)
                        return Ok(result);
                    else
                        return BadRequest(result);
                }
                finally
                {
                    // Garante que o arquivo temporário seja excluído
                    if (System.IO.File.Exists(tempFilePath))
                    {
                        try
                        {
                            System.IO.File.Delete(tempFilePath);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogWarning(ex, "Erro ao excluir arquivo temporário: {Caminho}", tempFilePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao processar arquivo SPED");
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }

        [HttpPost("processar")]
        public async Task<IActionResult> ProcessarArquivoLocal([FromBody] ProcessarArquivoRequest request)
        {
            if (string.IsNullOrEmpty(request.CaminhoArquivo))
                return BadRequest("Caminho do arquivo não fornecido");

            try
            {
                // Verifica se o arquivo existe
                if (!System.IO.File.Exists(request.CaminhoArquivo))
                {
                    return BadRequest($"O arquivo {request.CaminhoArquivo} não foi encontrado");
                }
                
                // Primeiro obtém o CNPJ
                string cnpj;
                using (var stream = new FileStream(request.CaminhoArquivo, FileMode.Open, FileAccess.Read))
                {
                    cnpj = await _spedService.ObterCNPJDoArquivoAsync(stream);
                }
                _logger.LogInformation("Processando arquivo SPED do CNPJ: {CNPJ}", cnpj);
                
                // Processa o arquivo completo
                var result = await _spedService.ProcessarArquivoSpedAsync(request.CaminhoArquivo);

                if (result.Sucesso)
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao processar arquivo SPED local: {Caminho}", request.CaminhoArquivo);
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }
    }

    public class ProcessarArquivoRequest
    {
        public string CaminhoArquivo { get; set; }
    }
}