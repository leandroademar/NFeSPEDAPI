using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1800")]
public partial class Reg1800
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

    [Column("vl_carga")]
    [Precision(21, 2)]
    public decimal? VlCarga { get; set; }

    [Column("vl_pass")]
    [Precision(21, 2)]
    public decimal? VlPass { get; set; }

    [Column("vl_fat")]
    [Precision(21, 2)]
    public decimal? VlFat { get; set; }

    [Column("ind_rat")]
    [Precision(14, 6)]
    public decimal? IndRat { get; set; }

    [Column("vl_icms_ant")]
    [Precision(21, 2)]
    public decimal? VlIcmsAnt { get; set; }

    [Column("vl_bc_icms")]
    [Precision(21, 2)]
    public decimal? VlBcIcms { get; set; }

    [Column("vl_icms_apur")]
    [Precision(21, 2)]
    public decimal? VlIcmsApur { get; set; }

    [Column("vl_bc_icms_apur")]
    [Precision(21, 2)]
    public decimal? VlBcIcmsApur { get; set; }

    [Column("vl_dif")]
    [Precision(21, 2)]
    public decimal? VlDif { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1800s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
