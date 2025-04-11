using Microsoft.EntityFrameworkCore;
using NFeSPEDAPI.Data;
using NFeSPEDAPI.Models.SPED;

namespace NFeSPEDAPI.Services;

public class SpedService : ISpedService
    {
        private readonly ApplicationDbContext _context;

        public SpedService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SpedModel> ProcessarArquivoSpedAsync(IFormFile arquivo)
        {
            using var reader = new StreamReader(arquivo.OpenReadStream());
            string conteudoArquivo = await reader.ReadToEndAsync();
            return await ProcessarArquivoSpedAsync(conteudoArquivo);
        }

        public async Task<SpedModel> ProcessarArquivoSpedAsync(string conteudoArquivo)
        {
            try
            {
                var linhas = conteudoArquivo.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                
                // Modelo para armazenar os dados do SPED
                var sped = new SpedModel
                {
                    ArquivoCompleto = conteudoArquivo,
                    Blocos = new List<SpedBlocoModel>()
                };

                // Dicionário para acompanhar blocos já criados
                var blocosDicionario = new Dictionary<string, SpedBlocoModel>();
                
                // Processa o cabeçalho do arquivo (Registro 0000)
                var linha0000 = linhas.FirstOrDefault(l => l.StartsWith("|0000|"));
                if (linha0000 != null)
                {
                    var campos = linha0000.Split('|');
                    if (campos.Length > 7)
                    {
                        sped.CNPJ = campos[7];
                        sped.NomeEmpresa = campos[8];
                        
                        // Período inicial e final (formatos podem variar dependendo do layout do SPED)
                        if (DateTime.TryParse(campos[4], out DateTime dtIni))
                            sped.PeriodoInicial = dtIni;
                        
                        if (DateTime.TryParse(campos[5], out DateTime dtFin))
                            sped.PeriodoFinal = dtFin;
                    }
                }

                // Processa as linhas do arquivo
                for (int i = 0; i < linhas.Length; i++)
                {
                    var linha = linhas[i];
                    if (string.IsNullOrWhiteSpace(linha))
                        continue;

                    var campos = linha.Split('|');
                    if (campos.Length < 3)
                        continue;

                    var codigoRegistro = campos[1];
                    
                    // Identifica o bloco com base no primeiro caractere do registro
                    var codigoBloco = codigoRegistro.Length > 0 ? codigoRegistro[0].ToString() : "";
                    
                    // Define descrição do bloco conforme padrão SPED
                    var descricaoBloco = codigoBloco switch
                    {
                        "0" => "Abertura, Identificação e Referências",
                        "A" => "Documentos - Serviços (Não ICMS)",
                        "B" => "Escrituração e Apuração do ISS",
                        "C" => "Documentos Fiscais I - Mercadorias (ICMS/IPI)",
                        "D" => "Documentos Fiscais II - Serviços (ICMS)",
                        "E" => "Apuração do ICMS e do IPI",
                        "G" => "Controle do Crédito de ICMS do Ativo Permanente - CIAP",
                        "H" => "Inventário Físico",
                        "K" => "Controle da Produção e do Estoque",
                        "1" => "Outras Informações",
                        "9" => "Controle e Encerramento do Arquivo Digital",
                        _ => $"Bloco {codigoBloco}"
                    };

                    // Obtém ou cria o bloco
                    if (!blocosDicionario.TryGetValue(codigoBloco, out var bloco))
                    {
                        bloco = new SpedBlocoModel
                        {
                            CodigoBloco = codigoBloco,
                            Descricao = descricaoBloco,
                            Registros = new List<SpedRegistroModel>()
                        };
                        
                        blocosDicionario[codigoBloco] = bloco;
                        sped.Blocos.Add(bloco);
                    }

                    // Adiciona o registro ao bloco
                    var registro = new SpedRegistroModel
                    {
                        CodigoRegistro = codigoRegistro,
                        Conteudo = linha,
                        LinhaArquivo = i + 1
                    };
                    
                    bloco.Registros.Add(registro);
                }

                return sped;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao processar arquivo SPED: {ex.Message}", ex);
            }
        }

        public async Task<SpedModel> SalvarSpedAsync(SpedModel sped)
        {
            // Verificar se já existe um SPED com o mesmo CNPJ e período
            var spedExistente = await _context.SpedArquivos
                .FirstOrDefaultAsync(s => s.CNPJ == sped.CNPJ && 
                                         s.PeriodoInicial == sped.PeriodoInicial && 
                                         s.PeriodoFinal == sped.PeriodoFinal);

            if (spedExistente != null)
            {
                // Se já existir, exclui o antigo antes de inserir o novo
                _context.SpedArquivos.Remove(spedExistente);
                await _context.SaveChangesAsync();
            }

            _context.SpedArquivos.Add(sped);
            await _context.SaveChangesAsync();
            return sped;
        }

        public async Task<SpedModel> ObterSpedPorIdAsync(Guid id)
        {
            return await _context.SpedArquivos
                .Include(s => s.Blocos)
                .ThenInclude(b => b.Registros)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<SpedModel>> ListarSpedAsync(DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            var query = _context.SpedArquivos.AsQueryable();

            if (dataInicial.HasValue)
                query = query.Where(s => s.PeriodoInicial >= dataInicial.Value);

            if (dataFinal.HasValue)
                query = query.Where(s => s.PeriodoFinal <= dataFinal.Value);

            return await query.ToListAsync();
        }
    }