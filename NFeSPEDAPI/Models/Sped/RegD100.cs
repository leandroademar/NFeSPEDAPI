using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_d100")]
public partial class RegD100
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
    [StringLength(4)]
    public string? Ser { get; set; }

    [Column("sub")]
    [StringLength(3)]
    public string? Sub { get; set; }

    [Column("num_doc")]
    [StringLength(9)]
    public string? NumDoc { get; set; }

    [Column("chv_cte")]
    [StringLength(44)]
    public string? ChvCte { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("dt_a_p")]
    public DateOnly? DtAP { get; set; }

    [Column("tp_ct_e")]
    [StringLength(1)]
    public string? TpCtE { get; set; }

    [Column("chv_cte_ref")]
    [StringLength(44)]
    public string? ChvCteRef { get; set; }

    [Column("vl_doc")]
    [Precision(21, 2)]
    public decimal? VlDoc { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Column("ind_frt")]
    [StringLength(1)]
    public string? IndFrt { get; set; }

    [Column("vl_serv")]
    [Precision(21, 2)]
    public decimal? VlServ { get; set; }

    [Column("vl_bc_icms")]
    [Precision(21, 2)]
    public decimal? VlBcIcms { get; set; }

    [Column("vl_icms")]
    [Precision(21, 2)]
    public decimal? VlIcms { get; set; }

    [Column("vl_nt")]
    [Precision(21, 2)]
    public decimal? VlNt { get; set; }

    [Column("cod_inf")]
    [StringLength(60)]
    public string? CodInf { get; set; }

    [Column("cod_cta")]
    [StringLength(255)]
    public string? CodCta { get; set; }

    [Column("cod_mun_orig")]
    [StringLength(7)]
    public string? CodMunOrig { get; set; }

    [Column("cod_mun_dest")]
    [StringLength(7)]
    public string? CodMunDest { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegD100s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
