using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.NFe;

[Table("nfes")]
public class NFeModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [Column("chave_acesso")]
    public string ChaveAcesso { get; set; }

    [Required]
    [Column("numero")]
    public string Numero { get; set; }

    [Required]
    [Column("serie")]
    public string Serie { get; set; }

    [Required]
    [Column("data_emissao")]
    public DateTime DataEmissao { get; set; }

    [Required]
    [Column("valor_total")]
    public decimal ValorTotal { get; set; }

    [Column("cnpj_emitente")]
    public string CNPJEmitente { get; set; }

    [Column("nome_emitente")]
    public string NomeEmitente { get; set; }

    [Column("cnpj_destinatario")]
    public string CNPJDestinatario { get; set; }

    [Column("nome_destinatario")]
    public string NomeDestinatario { get; set; }

    [Column("data_importacao")]
    public DateTime DataImportacao { get; set; } = DateTime.UtcNow;

    [Column("xml_completo")]
    public string XmlCompleto { get; set; }

    // Relacionamento com os itens da NFe
    public ICollection<NFeItemModel> Itens { get; set; } = new List<NFeItemModel>();
}