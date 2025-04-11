using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.NFe;

[Table("nfe_itens")]
public class NFeItemModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [Column("nfe_id")]
    public Guid NFeId { get; set; }

    [Required]
    [Column("numero_item")]
    public int NumeroItem { get; set; }

    [Required]
    [Column("codigo_produto")]
    public string CodigoProduto { get; set; }

    [Required]
    [Column("descricao")]
    public string Descricao { get; set; }

    [Required]
    [Column("ncm")]
    public string NCM { get; set; }

    [Required]
    [Column("cfop")]
    public string CFOP { get; set; }

    [Required]
    [Column("unidade")]
    public string Unidade { get; set; }

    [Required]
    [Column("quantidade")]
    public decimal Quantidade { get; set; }

    [Required]
    [Column("valor_unitario")]
    public decimal ValorUnitario { get; set; }

    [Required]
    [Column("valor_total")]
    public decimal ValorTotal { get; set; }

    [Column("valor_icms")]
    public decimal ValorICMS { get; set; }

    [Column("valor_ipi")]
    public decimal ValorIPI { get; set; }

    // Referência para a NFe pai
    [ForeignKey("NFeId")]
    public NFeModel NFe { get; set; }
}