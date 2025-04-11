using NFeSPEDAPI.Models.NFe;

namespace NFeSPEDAPI.Services;

public interface INFeService
{
    Task<NFeModel> ProcessarXmlNFeAsync(IFormFile arquivo);
    Task<NFeModel> ProcessarXmlNFeAsync(string conteudoXml);
    Task<NFeModel> SalvarNFeAsync(NFeModel nfe);
    Task<NFeModel> ObterNFePorChaveAsync(string chaveAcesso);
    Task<IEnumerable<NFeModel>> ListarNFesAsync(DateTime? dataInicial = null, DateTime? dataFinal = null);
}