using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c197")]
public partial class RegC197
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

    [Column("cod_aj")]
    [StringLength(10)]
    public string? CodAj { get; set; }

    [Column("descr_compl_aj")]
    [StringLength(255)]
    public string? DescrComplAj { get; set; }

    [Column("cod_item")]
    [StringLength(60)]
    public string? CodItem { get; set; }

    [Column("vl_bc_icms")]
    [Precision(21, 2)]
    public decimal? VlBcIcms { get; set; }

    [Column("aliq_icms")]
    [Precision(8, 2)]
    public decimal? AliqIcms { get; set; }

    [Column("vl_icms")]
    [Precision(21, 2)]
    public decimal? VlIcms { get; set; }

    [Column("vl_outros")]
    [Precision(21, 2)]
    public decimal? VlOutros { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC197s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
