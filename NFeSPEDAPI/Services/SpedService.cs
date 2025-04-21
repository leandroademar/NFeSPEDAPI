using System.Reflection;
using EficazFramework.SPED.Schemas.EFD_ICMS_IPI;
using NFeSPEDAPI.Data;
using NFeSPEDAPI.Models.Sped;

// using Registro0000 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0000;
// using Registro0001 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0001;
// using Registro0005 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0005;
// using Registro0015 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0015;
// using Registro0100 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0100;
// using Registro0150 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0150;
// using Registro0175 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0175;
// using Registro0190 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0190;
// using Registro0200 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0200;
// using Registro0205 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0205;
// using Registro0206 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0206;
// using Registro0220 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0220;
// using Registro0300 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0300;
// using Registro0305 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0305;
// using Registro0400 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0400;
// using Registro0450 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0450;
// using Registro0460 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0460;
// using Registro0500 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0500;
// using Registro0600 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0600;
// using Registro0990 = NFeSPEDAPI.Models.SPED.Blocos.Bloco_0.Registro0990;

namespace NFeSPEDAPI.Services;

public class SpedService : ISpedService
{
    private readonly AppDbContextPg _context;
    private readonly ILogger<SpedService> _logger;

    public SpedService(AppDbContextPg context, ILogger<SpedService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<ProcessamentoResult> ProcessarArquivoSpedAsync(string caminhoArquivo,
        CancellationToken cancellationToken = default)
    {
        try
        {
            using var stream = File.OpenRead(caminhoArquivo);
            return await ProcessarArquivoSpedAsync(stream, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao abrir o arquivo SPED: {Caminho}", caminhoArquivo);
            return new ProcessamentoResult
            {
                Sucesso = false,
                Mensagem = $"Erro ao abrir o arquivo: {ex.Message}",
                Erro = ex
            };
        }
    }

    public async Task<string> ObterCNPJDoArquivoAsync(Stream stream, CancellationToken cancellationToken = default)
    {
        // Importante: Não modifique o stream original
    
        // Crie uma instância de Escrituracao
        var escrituracao = new Escrituracao
        {
            Encoding = System.Text.Encoding.Default
        };
    
        // Use o stream recebido sem tentar reposicioná-lo
        // O método LeEmpresaArquivo lê apenas a primeira linha do arquivo
        string cnpj = await escrituracao.LeEmpresaArquivo(stream, cancellationToken);
    
        return cnpj ?? "";
    }

    public async Task<ProcessamentoResult> ProcessarArquivoSpedAsync(Stream stream,
        CancellationToken cancellationToken = default)
    {
        var result = new ProcessamentoResult();

        try
        {
            _logger.LogInformation("Iniciando processamento do arquivo SPED");

            // Cria a instância de Escrituracao e lê o arquivo
            var escrituracao = new Escrituracao
            {
                Encoding = System.Text.Encoding.Default
            };

            // Posiciona o stream no início
            stream.Position = 0;

            // Lê o arquivo SPED
            await escrituracao.LeArquivo(stream, cancellationToken);

            _logger.LogInformation("Arquivo SPED lido com sucesso. Iniciando persistência no banco de dados.");

            // Começa uma transação para garantir a integridade dos dados
            using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                int totalRegistros = 0;

                // Processa os registros do Bloco 0
                int registrosBloco0 = await ProcessarBlocoZeroAsync(escrituracao, cancellationToken);
                totalRegistros += registrosBloco0;
                result.RegistrosPorBloco["Bloco 0"] = registrosBloco0;
                

                // // Processa os registros do Bloco B
                // int registrosBlocoB = await ProcessarBlocoBAsync(escrituracao, cancellationToken);
                // totalRegistros += registrosBlocoB;
                // result.RegistrosPorBloco["Bloco B"] = registrosBlocoB;
                //
                // // Processa os registros do Bloco C
                // int registrosBlocoC = await ProcessarBlocoCAsync(escrituracao, cancellationToken);
                // totalRegistros += registrosBlocoC;
                // result.RegistrosPorBloco["Bloco C"] = registrosBlocoC;
                //
                // // Processa os registros do Bloco D
                // int registrosBlocoD = await ProcessarBlocoDAsync(escrituracao, cancellationToken);
                // totalRegistros += registrosBlocoD;
                // result.RegistrosPorBloco["Bloco D"] = registrosBlocoD;
                //
                // // Processa os registros do Bloco E
                // int registrosBlocoE = await ProcessarBlocoEAsync(escrituracao, cancellationToken);
                // totalRegistros += registrosBlocoE;
                // result.RegistrosPorBloco["Bloco E"] = registrosBlocoE;
                //
                // // Processa os registros do Bloco G
                // int registrosBlocoG = await ProcessarBlocoGAsync(escrituracao, cancellationToken);
                // totalRegistros += registrosBlocoG;
                // result.RegistrosPorBloco["Bloco G"] = registrosBlocoG;
                //
                // // Processa os registros do Bloco H
                // int registrosBlocoH = await ProcessarBlocoHAsync(escrituracao, cancellationToken);
                // totalRegistros += registrosBlocoH;
                // result.RegistrosPorBloco["Bloco H"] = registrosBlocoH;
                //
                // // Processa os registros do Bloco K
                // int registrosBlocoK = await ProcessarBlocoKAsync(escrituracao, cancellationToken);
                // totalRegistros += registrosBlocoK;
                // result.RegistrosPorBloco["Bloco K"] = registrosBlocoK;
                //
                // // Processa os registros do Bloco 1
                // int registrosBloco1 = await ProcessarBloco1Async(escrituracao, cancellationToken);
                // totalRegistros += registrosBloco1;
                // result.RegistrosPorBloco["Bloco 1"] = registrosBloco1;
                //
                // // Processa os registros do Bloco 9
                // int registrosBloco9 = await ProcessarBloco9Async(escrituracao, cancellationToken);
                // totalRegistros += registrosBloco9;
                // result.RegistrosPorBloco["Bloco 9"] = registrosBloco9;

                // Salva todas as alterações em um único commit
                
                // Extrair o ano e mês do arquivo ou usar uma lógica específica
                string dataFile = ObterDataFileDoArquivo(stream);
                // _context.SaveChangesAsync(dataFile);                
                await _context.SaveChangesAsync(cancellationToken);

                // Commit da transação
                await transaction.CommitAsync(cancellationToken);

                result.Sucesso = true;
                result.RegistrosImportados = totalRegistros;
                result.Mensagem = $"Processamento concluído com sucesso. {totalRegistros} registros importados.";

                _logger.LogInformation(
                    "Processamento do arquivo SPED concluído com sucesso. {TotalRegistros} registros importados.",
                    totalRegistros);

                return result;
            }
            catch (Exception ex)
            {
                // Em caso de erro, faz rollback da transação
                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro durante o processamento do arquivo SPED");
            result.Sucesso = false;
            result.Mensagem = $"Erro durante o processamento: {ex.Message}";
            result.Erro = ex;
            return result;
        }
    }

    #region Processamento de Blocos
    
    
    private string ObterDataFileDoArquivo(Stream stream)
    {
        // Exemplo: extrair do Registro0000
        var escrituracao = new Escrituracao { Encoding = System.Text.Encoding.Default };
        stream.Position = 0;
        var bloco0 = escrituracao.Blocos["0"] as Bloco0;
    
        // Usa a data inicial do arquivo como base para o datafile
        return bloco0?.Registro0000?.DataInicial?.ToString("yyyyMM") 
               ?? DateTime.Now.ToString("yyyyMM");
    }

    private async Task<int> ProcessarBlocoZeroAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        int totalRegistros = 0;
        var bloco0 = escrituracao.Blocos["0"] as Bloco0;

        if (bloco0 == null || bloco0.Registro0001 == null)
        {
            _logger.LogWarning("Bloco 0 não encontrado ou vazio no arquivo SPED");
            return totalRegistros;
        }

        // Processa o registro 0000
        if (bloco0.Registro0000 != null)
        {
            Escrituracaofiscal reg0 = new Escrituracaofiscal();
            reg0.Estado = 
            _context.Add(registro0000);
            totalRegistros++;
        }

        // Processa o registro 0001
        if (bloco0.Registro0001 != null)
        {
            var registro0001 = MapearRegistro<Registro0001>(bloco0.Registro0001);
            _context.Add(registro0001);
            totalRegistros++;
        }

        // Processa o registro 0005
        if (bloco0.Registro0001?.Registro0005 != null)
        {
            var registro0005 = MapearRegistro<Registro0005>(bloco0.Registro0001.Registro0005);
            _context.Add(registro0005);
            totalRegistros++;
        }

        // // Processa os registros 0015
        // foreach (var reg0015 in bloco0.Registro0001?.Registros0015 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0015>())
        // {
        //     var registro0015 = MapearRegistro<Registro0015>(reg0015);
        //     _context.Add(registro0015);
        //     totalRegistros++;
        // }
        //
        // // Processa o registro 0100
        // if (bloco0.Registro0001?.Registro0100 != null)
        // {
        //     var registro0100 = MapearRegistro<Registro0100>(bloco0.Registro0001.Registro0100);
        //     _context.Add(registro0100);
        //     totalRegistros++;
        // }
        //
        // // Processa os registros 0150 e 0175
        // foreach (var reg0150 in bloco0.Registro0001?.Registros0150 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0150>())
        // {
        //     var registro0150 = MapearRegistro<Registro0150>(reg0150);
        //     _context.Add(registro0150);
        //     totalRegistros++;
        //
        //     foreach (var reg0175 in reg0150.Registros0175 ??
        //                             Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0175>())
        //     {
        //         var registro0175 = MapearRegistro<Registro0175>(reg0175);
        //         _context.Add(registro0175);
        //         totalRegistros++;
        //     }
        // }
        //
        // // Processa os registros 0190
        // foreach (var reg0190 in bloco0.Registro0001?.Registros0190 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0190>())
        // {
        //     var registro0190 = MapearRegistro<Registro0190>(reg0190);
        //     _context.Add(registro0190);
        //     totalRegistros++;
        // }
        //
        // // Processa os registros 0200, 0205, 0206 e 0220
        // foreach (var reg0200 in bloco0.Registro0001?.Registros0200 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0200>())
        // {
        //     var registro0200 = MapearRegistro<Registro0200>(reg0200);
        //     _context.Add(registro0200);
        //     totalRegistros++;
        //
        //     foreach (var reg0205 in reg0200.Registros0205 ??
        //                             Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0205>())
        //     {
        //         var registro0205 = MapearRegistro<Registro0205>(reg0205);
        //         _context.Add(registro0205);
        //         totalRegistros++;
        //     }
        //
        //     if (reg0200.Registros0206 != null)
        //     {
        //         var registro0206 = MapearRegistro<Registro0206>(reg0200.Registros0206);
        //         _context.Add(registro0206);
        //         totalRegistros++;
        //     }
        //
        //     foreach (var reg0220 in reg0200.Registros0220 ??
        //                             Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0220>())
        //     {
        //         var registro0220 = MapearRegistro<Registro0220>(reg0220);
        //         _context.Add(registro0220);
        //         totalRegistros++;
        //     }
        // }
        //
        // // Processa os registros 0300 e 0305
        // foreach (var reg0300 in bloco0.Registro0001?.Registros0300 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0300>())
        // {
        //     var registro0300 = MapearRegistro<Registro0300>(reg0300);
        //     _context.Add(registro0300);
        //     totalRegistros++;
        //
        //     if (reg0300.Registro0305 != null)
        //     {
        //         var registro0305 = MapearRegistro<Registro0305>(reg0300.Registro0305);
        //         _context.Add(registro0305);
        //         totalRegistros++;
        //     }
        // }
        //
        // // Processa os registros 0400
        // foreach (var reg0400 in bloco0.Registro0001?.Registros0400 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0400>())
        // {
        //     var registro0400 = MapearRegistro<Registro0400>(reg0400);
        //     _context.Add(registro0400);
        //     totalRegistros++;
        // }
        //
        // // Processa os registros 0450
        // foreach (var reg0450 in bloco0.Registro0001?.Registros0450 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0450>())
        // {
        //     var registro0450 = MapearRegistro<Registro0450>(reg0450);
        //     _context.Add(registro0450);
        //     totalRegistros++;
        // }
        //
        // // Processa os registros 0460
        // foreach (var reg0460 in bloco0.Registro0001?.Registros0460 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0460>())
        // {
        //     var registro0460 = MapearRegistro<Registro0460>(reg0460);
        //     _context.Add(registro0460);
        //     totalRegistros++;
        // }
        //
        // // Processa os registros 0500
        // foreach (var reg0500 in bloco0.Registro0001?.Registros0500 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0500>())
        // {
        //     var registro0500 = MapearRegistro<Registro0500>(reg0500);
        //     _context.Add(registro0500);
        //     totalRegistros++;
        // }
        //
        // // Processa os registros 0600
        // foreach (var reg0600 in bloco0.Registro0001?.Registros0600 ??
        //                         Enumerable.Empty<EficazFramework.SPED.Schemas.EFD_ICMS_IPI.Registro0600>())
        // {
        //     var registro0600 = MapearRegistro<Registro0600>(reg0600);
        //     _context.Add(registro0600);
        //     totalRegistros++;
        // }
        //
        // // Processa o registro 0990
        // if (bloco0.Registro0000?.Registro0990 != null)
        // {
        //     var registro0990 = MapearRegistro<Registro0990>(bloco0.Registro0000.Registro0990);
        //     _context.Add(registro0990);
        //     totalRegistros++;
        // }

        return totalRegistros;
    }

    // Implementações dos métodos para os outros blocos
    // Estes são stubs - você precisará implementá-los com o mapeamento correto para suas entidades

    private async Task<int> ProcessarBlocoBAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco B aqui
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBlocoCAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco C aqui
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBlocoDAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco D aqui
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBlocoEAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco E aqui
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBlocoGAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco G aqui
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBlocoHAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco H aqui
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBlocoKAsync(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco K aqui
        // Cuidado com RegistroK235 que não tem construtor sem parâmetros
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBloco1Async(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco 1 aqui
        return 0; // Retorna 0 registros por padrão
    }

    private async Task<int> ProcessarBloco9Async(Escrituracao escrituracao, CancellationToken cancellationToken)
    {
        // Implemente o processamento do Bloco 9 aqui
        return 0; // Retorna 0 registros por padrão
    }

    #endregion

    #region Mapeamento de Entidades

    /// <summary>
    /// Método genérico para mapear um registro do EficazFramework para sua entidade correspondente
    /// </summary>
    private TDestino MapearRegistro<TDestino>(object origem) where TDestino : class, new()
    {
       var destino = new TDestino();
        CopiarPropriedades(origem, destino);
    
        return destino;
    }

    /// <summary>
    /// Método genérico para copiar propriedades entre objetos
    /// </summary>
    private void CopiarPropriedades(object origem, object destino)
    {
        if (origem == null || destino == null)
            return;

        var propriedadesOrigem = origem.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var propriedadesDestino = destino.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .ToDictionary(p => p.Name.ToLower());

        foreach (var propOrigem in propriedadesOrigem)
        {
            // Ignora propriedades de navegação e coleções
            if (propOrigem.PropertyType.IsClass &&
                propOrigem.PropertyType != typeof(string) &&
                !propOrigem.PropertyType.IsValueType &&
                !propOrigem.PropertyType.IsPrimitive)
                continue;

            // Tenta encontrar a propriedade correspondente no destino (case insensitive)
            if (propriedadesDestino.TryGetValue(propOrigem.Name.ToLower(), out var propDestino))
            {
                try
                {
                    // Verifica se os tipos são compatíveis
                    var valorOrigem = propOrigem.GetValue(origem);

                    if (valorOrigem == null)
                        continue;

                    // Se os tipos forem diferentes, tenta converter
                    if (propDestino.PropertyType != propOrigem.PropertyType)
                    {
                        try
                        {
                            // Tenta converter o valor para o tipo da propriedade de destino
                            var valorConvertido = Convert.ChangeType(valorOrigem, propDestino.PropertyType);
                            propDestino.SetValue(destino, valorConvertido);
                        }
                        catch
                        {
                            // Se a conversão falhar, ignora esta propriedade
                            _logger.LogWarning(
                                "Não foi possível converter a propriedade {Propriedade} de {TipoOrigem} para {TipoDestino}",
                                propOrigem.Name, propOrigem.PropertyType.Name, propDestino.PropertyType.Name);
                        }
                    }
                    else
                    {
                        // Se os tipos forem iguais, copia diretamente
                        propDestino.SetValue(destino, valorOrigem);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogWarning("Erro ao copiar a propriedade {Propriedade}: {Erro}",
                        propOrigem.Name, ex.Message);
                }
            }
        }
    }
     
    #endregion
}