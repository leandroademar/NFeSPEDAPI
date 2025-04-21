using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using NFeSPEDAPI.Data;
using NFeSPEDAPI.Models.NFe;

namespace NFeSPEDAPI.Services;

 public class NFeService : INFeService
    {
        private readonly AppDbContextPg _context;
        
         public NFeService(AppDbContextPg context)
         {
             _context = context;
        }

        public async Task<NFeModel> ProcessarXmlNFeAsync(IFormFile arquivo)
        {
            using var reader = new StreamReader(arquivo.OpenReadStream());
            string conteudoXml = await reader.ReadToEndAsync();
            return await ProcessarXmlNFeAsync(conteudoXml);
        }

        public async Task<NFeModel> ProcessarXmlNFeAsync(string conteudoXml)
        {
            // Namespaces comuns em XML de NFe
            XNamespace ns = "http://www.portalfiscal.inf.br/nfe";

            try
            {
                XDocument xDoc = XDocument.Parse(conteudoXml);
                
                // Tenta buscar o elemento NFe ou procNFe (NFe pode estar dentro de um envelope)
                XElement nfeElement = xDoc.Root.Name.LocalName == "NFe" ? xDoc.Root : 
                                     xDoc.Descendants(ns + "NFe").FirstOrDefault();

                if (nfeElement == null)
                    throw new Exception("Estrutura do XML NFe inválida. Elemento NFe não encontrado.");

                // Extrai informações do XML
                XElement infNFe = nfeElement.Element(ns + "infNFe");
                if (infNFe == null)
                    throw new Exception("Elemento infNFe não encontrado no XML.");

                XElement ide = infNFe.Element(ns + "ide");
                XElement emit = infNFe.Element(ns + "emit");
                XElement dest = infNFe.Element(ns + "dest");
                XElement total = infNFe.Element(ns + "total")?.Element(ns + "ICMSTot");
                var itensXml = infNFe.Elements(ns + "det").ToList();

                // Cria o modelo NFe
                var nfe = new NFeModel
                {
                    ChaveAcesso = infNFe.Attribute("Id")?.Value.Replace("NFe", ""),
                    Numero = ide?.Element(ns + "nNF")?.Value,
                    Serie = ide?.Element(ns + "serie")?.Value,
                    DataEmissao = DateTime.Parse(ide?.Element(ns + "dhEmi")?.Value ?? DateTime.Now.ToString()).ToUniversalTime(),
                    CNPJEmitente = emit?.Element(ns + "CNPJ")?.Value,
                    NomeEmitente = emit?.Element(ns + "xNome")?.Value,
                    CNPJDestinatario = dest?.Element(ns + "CNPJ")?.Value,
                    NomeDestinatario = dest?.Element(ns + "xNome")?.Value,
                    ValorTotal = decimal.Parse(total?.Element(ns + "vNF")?.Value ?? "0"),
                    XmlCompleto = conteudoXml,
                    Itens = new List<NFeItemModel>()
                };

                // Processa os itens da NFe
                foreach (var item in itensXml)
                {
                    var prod = item.Element(ns + "prod");
                    var imposto = item.Element(ns + "imposto");
                    var icms = imposto?.Elements().FirstOrDefault(e => e.Name.LocalName.StartsWith("ICMS"));
                    var ipi = imposto?.Element(ns + "IPI")?.Element(ns + "IPITrib");

                    var nItem = int.Parse(item.Attribute("nItem")?.Value ?? "0");
                    var vICMS = decimal.Parse(icms?.Element(ns + "vICMS")?.Value ?? "0");
                    var vIPI = decimal.Parse(ipi?.Element(ns + "vIPI")?.Value ?? "0");

                    var nfeItem = new NFeItemModel
                    {
                        NumeroItem = nItem,
                        CodigoProduto = prod?.Element(ns + "cProd")?.Value,
                        Descricao = prod?.Element(ns + "xProd")?.Value,
                        NCM = prod?.Element(ns + "NCM")?.Value,
                        CFOP = prod?.Element(ns + "CFOP")?.Value,
                        Unidade = prod?.Element(ns + "uCom")?.Value,
                        Quantidade = decimal.Parse(prod?.Element(ns + "qCom")?.Value ?? "0"),
                        ValorUnitario = decimal.Parse(prod?.Element(ns + "vUnCom")?.Value ?? "0"),
                        ValorTotal = decimal.Parse(prod?.Element(ns + "vProd")?.Value ?? "0"),
                        ValorICMS = vICMS,
                        ValorIPI = vIPI
                    };

                    nfe.Itens.Add(nfeItem);
                }

                return nfe;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao processar XML NFe: {ex.Message}", ex);
            }
        }

        public async Task<NFeModel> SalvarNFeAsync(NFeModel nfe)
        {
            // Verifica se a NFe já existe no banco
            var nfeExistente = await _context.NFes
                .FirstOrDefaultAsync(n => n.ChaveAcesso == nfe.ChaveAcesso);

            if (nfeExistente != null)
                return nfeExistente; // NFe já importada anteriormente

            // Caso não exista, salva a nova NFe
            _context.NFes.Add(nfe);
            await _context.SaveChangesAsync();
            return nfe;
        }

        public async Task<NFeModel> ObterNFePorChaveAsync(string chaveAcesso)
        {
            return await _context.NFes
                .Include(n => n.Itens)
                .FirstOrDefaultAsync(n => n.ChaveAcesso == chaveAcesso);
        }

        public async Task<IEnumerable<NFeModel>> ListarNFesAsync(DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            var query = _context.NFes.AsQueryable();

            if (dataInicial.HasValue)
                query = query.Where(n => n.DataEmissao >= dataInicial.Value);

            if (dataFinal.HasValue)
                query = query.Where(n => n.DataEmissao <= dataFinal.Value);

            return await query.ToListAsync();
        }
    }