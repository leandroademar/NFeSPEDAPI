using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c100")]
public partial class RegC100
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

    [Column("ind_oper")]
    [StringLength(1)]
    public string? IndOper { get; set; }

    [Column("ind_emit")]
    [StringLength(1)]
    public string? IndEmit { get; set; }

    [Column("cod_part")]
    [StringLength(60)]
    public string? CodPart { get; set; }

    [Column("cod_mod")]
    [StringLength(2)]
    public string? CodMod { get; set; }

    [Column("cod_sit")]
    [StringLength(2)]
    public string? CodSit { get; set; }

    [Column("ser")]
    [StringLength(3)]
    public string? Ser { get; set; }

    [Column("num_doc")]
    [StringLength(9)]
    public string? NumDoc { get; set; }

    [Column("chv_nfe")]
    [StringLength(44)]
    public string? ChvNfe { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("dt_e_s")]
    public DateOnly? DtES { get; set; }

    [Column("vl_doc")]
    [Precision(21, 2)]
    public decimal? VlDoc { get; set; }

    [Column("ind_pgto")]
    [StringLength(1)]
    public string? IndPgto { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Column("vl_abat_nt")]
    [Precision(21, 2)]
    public decimal? VlAbatNt { get; set; }

    [Column("vl_merc")]
    [Precision(21, 2)]
    public decimal? VlMerc { get; set; }

    [Column("ind_frt")]
    [StringLength(1)]
    public string? IndFrt { get; set; }

    [Column("vl_frt")]
    [Precision(21, 2)]
    public decimal? VlFrt { get; set; }

    [Column("vl_seg")]
    [Precision(21, 2)]
    public decimal? VlSeg { get; set; }

    [Column("vl_out_da")]
    [Precision(21, 2)]
    public decimal? VlOutDa { get; set; }

    [Column("vl_bc_icms")]
    [Precision(21, 2)]
    public decimal? VlBcIcms { get; set; }

    [Column("vl_icms")]
    [Precision(21, 2)]
    public decimal? VlIcms { get; set; }

    [Column("vl_bc_icms_st")]
    [Precision(21, 2)]
    public decimal? VlBcIcmsSt { get; set; }

    [Column("vl_icms_st")]
    [Precision(21, 2)]
    public decimal? VlIcmsSt { get; set; }

    [Column("vl_ipi")]
    [Precision(21, 2)]
    public decimal? VlIpi { get; set; }

    [Column("vl_pis")]
    [Precision(21, 2)]
    public decimal? VlPis { get; set; }

    [Column("vl_cofins")]
    [Precision(21, 2)]
    public decimal? VlCofins { get; set; }

    [Column("vl_pis_st")]
    [Precision(21, 2)]
    public decimal? VlPisSt { get; set; }

    [Column("vl_cofins_st")]
    [Precision(21, 2)]
    public decimal? VlCofinsSt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC100s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
