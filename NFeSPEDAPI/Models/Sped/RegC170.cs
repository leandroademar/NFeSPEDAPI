using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c170")]
[Index("CodNat", Name = "idx_cod_nat")]
public partial class RegC170
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

    [Column("descr_compl")]
    [StringLength(255)]
    public string? DescrCompl { get; set; }

    [Column("qtd")]
    [Precision(24, 5)]
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

    [Column("ind_mov")]
    [StringLength(1)]
    public string? IndMov { get; set; }

    [Column("cst_icms")]
    [StringLength(3)]
    public string? CstIcms { get; set; }

    [Column("cfop")]
    [StringLength(4)]
    public string? Cfop { get; set; }

    [Column("cod_nat")]
    [StringLength(10)]
    public string? CodNat { get; set; }

    [Column("vl_bc_icms")]
    [Precision(21, 2)]
    public decimal? VlBcIcms { get; set; }

    [Column("aliq_icms")]
    [Precision(8, 2)]
    public decimal? AliqIcms { get; set; }

    [Column("vl_icms")]
    [Precision(21, 2)]
    public decimal? VlIcms { get; set; }

    [Column("vl_bc_icms_st")]
    [Precision(21, 2)]
    public decimal? VlBcIcmsSt { get; set; }

    [Column("aliq_st")]
    [Precision(8, 2)]
    public decimal? AliqSt { get; set; }

    [Column("vl_icms_st")]
    [Precision(21, 2)]
    public decimal? VlIcmsSt { get; set; }

    [Column("ind_apur")]
    [StringLength(1)]
    public string? IndApur { get; set; }

    [Column("cst_ipi")]
    [StringLength(2)]
    public string? CstIpi { get; set; }

    [Column("cod_enq")]
    [StringLength(3)]
    public string? CodEnq { get; set; }

    [Column("vl_bc_ipi")]
    [Precision(21, 2)]
    public decimal? VlBcIpi { get; set; }

    [Column("aliq_ipi")]
    [Precision(8, 2)]
    public decimal? AliqIpi { get; set; }

    [Column("vl_ipi")]
    [Precision(21, 2)]
    public decimal? VlIpi { get; set; }

    [Column("cst_pis")]
    [StringLength(2)]
    public string? CstPis { get; set; }

    [Column("vl_bc_pis")]
    [Precision(21, 2)]
    public decimal? VlBcPis { get; set; }

    [Column("aliq_pis_perc")]
    [Precision(12, 4)]
    public decimal? AliqPisPerc { get; set; }

    [Column("quant_bc_pis")]
    [Precision(22, 3)]
    public decimal? QuantBcPis { get; set; }

    [Column("aliq_pis_reais")]
    [Precision(23, 4)]
    public decimal? AliqPisReais { get; set; }

    [Column("vl_pis")]
    [Precision(21, 2)]
    public decimal? VlPis { get; set; }

    [Column("cst_cofins")]
    [StringLength(2)]
    public string? CstCofins { get; set; }

    [Column("vl_bc_cofins")]
    [Precision(21, 2)]
    public decimal? VlBcCofins { get; set; }

    [Column("aliq_cofins_perc")]
    [Precision(12, 4)]
    public decimal? AliqCofinsPerc { get; set; }

    [Column("quant_bc_cofins")]
    [Precision(22, 3)]
    public decimal? QuantBcCofins { get; set; }

    [Column("aliq_cofins_reais")]
    [Precision(23, 4)]
    public decimal? AliqCofinsReais { get; set; }

    [Column("vl_cofins")]
    [Precision(21, 2)]
    public decimal? VlCofins { get; set; }

    [Column("cod_cta")]
    [StringLength(255)]
    public string? CodCta { get; set; }

    [Column("vl_abat_nt")]
    [Precision(21, 2)]
    public decimal? VlAbatNt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC170s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
