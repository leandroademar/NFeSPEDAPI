using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1500")]
public partial class Reg1500
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

    [Column("vl_cofis")]
    [Precision(21, 2)]
    public decimal? VlCofis { get; set; }

    [Column("tp_ligacao")]
    [StringLength(1)]
    public string? TpLigacao { get; set; }

    [Column("cod_grupo_tensao")]
    [StringLength(2)]
    public string? CodGrupoTensao { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1500s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
