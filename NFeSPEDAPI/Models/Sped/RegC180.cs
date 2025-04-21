using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c180")]
public partial class RegC180
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

    [Column("cod_resp_ret")]
    [StringLength(1)]
    public string? CodRespRet { get; set; }

    [Column("quant_conv")]
    [Precision(25, 6)]
    public decimal? QuantConv { get; set; }

    [Column("unid")]
    [StringLength(6)]
    public string? Unid { get; set; }

    [Column("vl_unit_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitConv { get; set; }

    [Column("vl_unit_icms_op_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsOpConv { get; set; }

    [Column("vl_unit_bc_icms_st_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitBcIcmsStConv { get; set; }

    [Column("vl_unit_icms_st_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsStConv { get; set; }

    [Column("vl_unit_fcp_st_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitFcpStConv { get; set; }

    [Column("cod_da")]
    [StringLength(1)]
    public string? CodDa { get; set; }

    [Column("num_da")]
    [StringLength(255)]
    public string? NumDa { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC180s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
