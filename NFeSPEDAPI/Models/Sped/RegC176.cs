using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c176")]
[Index("CodPartUltE", Name = "idx_cod_part_ult_e")]
public partial class RegC176
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

    [Column("cod_mod_ult_e")]
    [StringLength(2)]
    public string? CodModUltE { get; set; }

    [Column("num_doc_ult_e")]
    [StringLength(9)]
    public string? NumDocUltE { get; set; }

    [Column("ser_ult_e")]
    [StringLength(3)]
    public string? SerUltE { get; set; }

    [Column("dt_ult_e")]
    public DateOnly? DtUltE { get; set; }

    [Column("cod_part_ult_e")]
    [StringLength(60)]
    public string? CodPartUltE { get; set; }

    [Column("quant_ult_e")]
    [Precision(22, 3)]
    public decimal? QuantUltE { get; set; }

    [Column("vl_unit_ult_e")]
    [Precision(22, 3)]
    public decimal? VlUnitUltE { get; set; }

    [Column("vl_unit_bc_st")]
    [Precision(22, 3)]
    public decimal? VlUnitBcSt { get; set; }

    [Column("chave_nfe_ult_e")]
    [StringLength(44)]
    public string? ChaveNfeUltE { get; set; }

    [Column("num_item_ult_e")]
    [StringLength(3)]
    public string? NumItemUltE { get; set; }

    [Column("vl_unit_bc_icms_ult_e")]
    [Precision(21, 2)]
    public decimal? VlUnitBcIcmsUltE { get; set; }

    [Column("aliq_icms_ult_e")]
    [Precision(21, 2)]
    public decimal? AliqIcmsUltE { get; set; }

    [Column("vl_unit_limite_bc_icms_ult_e")]
    [Precision(21, 2)]
    public decimal? VlUnitLimiteBcIcmsUltE { get; set; }

    [Column("vl_unit_icms_ult_e")]
    [Precision(22, 3)]
    public decimal? VlUnitIcmsUltE { get; set; }

    [Column("aliq_st_ult_e")]
    [Precision(21, 2)]
    public decimal? AliqStUltE { get; set; }

    [Column("vl_unit_res")]
    [Precision(22, 3)]
    public decimal? VlUnitRes { get; set; }

    [Column("cod_resp_ret")]
    [StringLength(1)]
    public string? CodRespRet { get; set; }

    [Column("cod_mot_res")]
    [StringLength(1)]
    public string? CodMotRes { get; set; }

    [Column("chave_nfe_ret")]
    [StringLength(44)]
    public string? ChaveNfeRet { get; set; }

    [Column("cod_part_nfe_ret")]
    [StringLength(60)]
    public string? CodPartNfeRet { get; set; }

    [Column("ser_nfe_ret")]
    [StringLength(3)]
    public string? SerNfeRet { get; set; }

    [Column("num_nfe_ret")]
    [StringLength(9)]
    public string? NumNfeRet { get; set; }

    [Column("item_nfe_ret")]
    [StringLength(3)]
    public string? ItemNfeRet { get; set; }

    [Column("cod_da")]
    [StringLength(1)]
    public string? CodDa { get; set; }

    [Column("num_da")]
    [StringLength(255)]
    public string? NumDa { get; set; }

    [Column("vl_unit_res_fcp_st")]
    [Precision(22, 3)]
    public decimal? VlUnitResFcpSt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC176s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
