using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c370")]
public partial class RegC370
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("id_pai")]
    public long IdPai { get; set; }

    [Column("linha")]
    public long Linha { get; set; }

    [Column("hash")]
    public long Hash { get; set; }

    [Column("reg")]
    [StringLength(4)]
    public string? Reg { get; set; }

    [Column("num_item")]
    [StringLength(3)]
    public string? NumItem { get; set; }

    [Column("cod_item")]
    [StringLength(60)]
    public string? CodItem { get; set; }

    [Column("qtd")]
    [Precision(25, 6)]
    public decimal? Qtd { get; set; }

    [Column("unid")]
    [StringLength(6)]
    public string? Unid { get; set; }

    [Column("vl_item")]
    [Precision(21, 2)]
    public decimal? VlItem { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC370s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
