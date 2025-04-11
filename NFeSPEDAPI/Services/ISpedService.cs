using NFeSPEDAPI.Models.SPED;

namespace NFeSPEDAPI.Services;

public interface ISpedService
{
    Task<SpedModel> ProcessarArquivoSpedAsync(IFormFile arquivo);
    Task<SpedModel> ProcessarArquivoSpedAsync(string conteudoArquivo);
    Task<SpedModel> SalvarSpedAsync(SpedModel sped);
    Task<SpedModel> ObterSpedPorIdAsync(Guid id);
    Task<IEnumerable<SpedModel>> ListarSpedAsync(DateTime? dataInicial = null, DateTime? dataFinal = null);
}