namespace NFeSPEDAPI.Services;

public class ProcessamentoResult
{
    public bool Sucesso { get; set; }
    public string Mensagem { get; set; }
    public int RegistrosImportados { get; set; }
    public Dictionary<string, int> RegistrosPorBloco { get; set; } = new Dictionary<string, int>();
    public List<string> Detalhes { get; set; } = new List<string>();
    public Exception Erro { get; set; }
}