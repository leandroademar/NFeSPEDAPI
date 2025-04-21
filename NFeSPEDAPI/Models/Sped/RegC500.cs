using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c500")]
[Index("CodInf", Name = "idx_cod_inf")]
public partial class RegC500
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

    [Column("cod_cons")]
    [StringLength(2)]
    public string? CodCons { get; set; }

    [Column("num_doc")]
    [StringLength(9)]
    public string? NumDoc { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("dt_e_s")]
    public DateOnly? DtES { get; set; }

    [Column("vl_doc")]
    [Precision(21, 2)]
    public decimal? VlDoc { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Column("vl_forn")]
    [Precision(21, 2)]
    public decimal? VlForn { get; set; }

    [Column("vl_serv_nt")]
    [Precision(21, 2)]
    public decimal? VlServNt { get; set; }

    [Column("vl_terc")]
    [Precision(21, 2)]
    public decimal? VlTerc { get; set; }

    [Column("vl_da")]
    [Precision(21, 2)]
    public decimal? VlDa { get; set; }

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

    [Column("cod_inf")]
    [StringLength(6)]
    public string? CodInf { get; set; }

    [Column("vl_pis")]
    [Precision(21, 2)]
    public decimal? VlPis { get; set; }

    [Column("vl_cofins")]
    [Precision(21, 2)]
    public decimal? VlCofins { get; set; }

    [Column("tp_ligacao")]
    [StringLength(1)]
    public string? TpLigacao { get; set; }

    [Column("cod_grupo_tensao")]
    [StringLength(2)]
    public string? CodGrupoTensao { get; set; }

    [Column("chv_doce")]
    [StringLength(44)]
    public string? ChvDoce { get; set; }

    [Column("fin_doce")]
    [StringLength(1)]
    public string? FinDoce { get; set; }

    [Column("chv_doce_ref")]
    [StringLength(44)]
    public string? ChvDoceRef { get; set; }

    [Column("ind_dest")]
    [StringLength(1)]
    public string? IndDest { get; set; }

    [Column("cod_mun_dest")]
    [StringLength(7)]
    public string? CodMunDest { get; set; }

    [Column("cod_cta")]
    [StringLength(255)]
    public string? CodCta { get; set; }

    [Column("cod_mod_doc_ref")]
    [StringLength(2)]
    public string? CodModDocRef { get; set; }

    [Column("hash_doc_ref")]
    [StringLength(32)]
    public string? HashDocRef { get; set; }

    [Column("ser_doc_ref")]
    [StringLength(4)]
    public string? SerDocRef { get; set; }

    [Column("num_doc_ref")]
    [StringLength(9)]
    public string? NumDocRef { get; set; }

    [Column("mes_doc_ref")]
    [StringLength(6)]
    public string? MesDocRef { get; set; }

    [Column("ener_injet")]
    [Precision(21, 2)]
    public decimal? EnerInjet { get; set; }

    [Column("outras_ded")]
    [Precision(21, 2)]
    public decimal? OutrasDed { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC500s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
