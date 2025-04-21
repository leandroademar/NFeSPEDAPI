using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b020")]
[Index("IndOper", "CodPart", Name = "idx_ind_oper_cod_part")]
public partial class RegB020
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

    [Column("cod_mun_serv")]
    [StringLength(7)]
    public string? CodMunServ { get; set; }

    [Column("vl_cont")]
    [Precision(21, 2)]
    public decimal? VlCont { get; set; }

    [Column("vl_mat_terc")]
    [Precision(21, 2)]
    public decimal? VlMatTerc { get; set; }

    [Column("vl_sub")]
    [Precision(21, 2)]
    public decimal? VlSub { get; set; }

    [Column("vl_isnt_iss")]
    [Precision(21, 2)]
    public decimal? VlIsntIss { get; set; }

    [Column("vl_ded_bc")]
    [Precision(21, 2)]
    public decimal? VlDedBc { get; set; }

    [Column("vl_bc_iss")]
    [Precision(21, 2)]
    public decimal? VlBcIss { get; set; }

    [Column("vl_bc_iss_rt")]
    [Precision(21, 2)]
    public decimal? VlBcIssRt { get; set; }

    [Column("vl_iss_rt")]
    [Precision(21, 2)]
    public decimal? VlIssRt { get; set; }

    [Column("vl_iss")]
    [Precision(21, 2)]
    public decimal? VlIss { get; set; }

    [Column("cod_inf_obs")]
    [StringLength(6)]
    public string? CodInfObs { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB020s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
