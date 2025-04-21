using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c380")]
public partial class RegC380
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

    [Column("cod_mot_rest_compl")]
    [StringLength(5)]
    public string? CodMotRestCompl { get; set; }

    [Column("quant_conv")]
    [Precision(25, 6)]
    public decimal? QuantConv { get; set; }

    [Column("unid")]
    [StringLength(6)]
    public string? Unid { get; set; }

    [Column("vl_unit_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitConv { get; set; }

    [Column("vl_unit_icms_na_operacao_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsNaOperacaoConv { get; set; }

    [Column("vl_unit_icms_op_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsOpConv { get; set; }

    [Column("vl_unit_bc_icms_st_estoque_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitBcIcmsStEstoqueConv { get; set; }

    [Column("vl_unit_icms_st_estoque_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsStEstoqueConv { get; set; }

    [Column("vl_unit_fcp_icms_st_estoque_conv")]
    [Precision(25, 6)]
    public decimal? VlUnitFcpIcmsStEstoqueConv { get; set; }

    [Column("vl_unit_icms_st_conv_rest")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsStConvRest { get; set; }

    [Column("vl_unit_fcp_st_conv_rest")]
    [Precision(25, 6)]
    public decimal? VlUnitFcpStConvRest { get; set; }

    [Column("vl_unit_icms_st_conv_compl")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsStConvCompl { get; set; }

    [Column("vl_unit_fcp_st_conv_compl")]
    [Precision(25, 6)]
    public decimal? VlUnitFcpStConvCompl { get; set; }

    [Column("cst_icms")]
    [StringLength(3)]
    public string? CstIcms { get; set; }

    [Column("cfop")]
    [StringLength(4)]
    public string? Cfop { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC380s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
