using NFeSPEDAPI.Models.SPED;

namespace NFeSPEDAPI.Services;

public interface ISpedService
{
    Task<ProcessamentoResult> ProcessarArquivoSpedAsync(string caminhoArquivo, CancellationToken cancellationToken = default);
    Task<ProcessamentoResult> ProcessarArquivoSpedAsync(Stream stream, CancellationToken cancellationToken = default);
    Task<string> ObterCNPJDoArquivoAsync(Stream stream, CancellationToken cancellationToken = default);
}