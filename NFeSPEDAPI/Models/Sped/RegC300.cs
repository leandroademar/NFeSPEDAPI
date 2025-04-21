using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c300")]
[Index("CodMod", "Ser", "Sub", Name = "idx_cod_mod_ser_sub")]
[Index("NumDocFin", Name = "idx_num_doc_fin")]
[Index("NumDocIni", Name = "idx_num_doc_ini")]
public partial class RegC300
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

    [Column("cod_mod")]
    [StringLength(2)]
    public string? CodMod { get; set; }

    [Column("ser")]
    [StringLength(4)]
    public string? Ser { get; set; }

    [Column("sub")]
    [StringLength(3)]
    public string? Sub { get; set; }

    [Column("num_doc_ini")]
    [StringLength(6)]
    public string? NumDocIni { get; set; }

    [Column("num_doc_fin")]
    [StringLength(255)]
    public string? NumDocFin { get; set; }

    [Column("cst_icms")]
    [StringLength(3)]
    public string? CstIcms { get; set; }

    [Column("cfop")]
    [StringLength(4)]
    public string? Cfop { get; set; }

    [Column("aliq_icms")]
    [Precision(8, 2)]
    public decimal? AliqIcms { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("vl_opr")]
    [Precision(21, 2)]
    public decimal? VlOpr { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Column("vl_serv")]
    [Precision(21, 2)]
    public decimal? VlServ { get; set; }

    [Column("vl_seg")]
    [Precision(21, 2)]
    public decimal? VlSeg { get; set; }

    [Column("vl_out_desp")]
    [Precision(21, 2)]
    public decimal? VlOutDesp { get; set; }

    [Column("vl_bc_icms")]
    [Precision(21, 2)]
    public decimal? VlBcIcms { get; set; }

    [Column("vl_icms")]
    [Precision(21, 2)]
    public decimal? VlIcms { get; set; }

    [Column("vl_red_bc")]
    [Precision(21, 2)]
    public decimal? VlRedBc { get; set; }

    [Column("cod_obs")]
    [StringLength(6)]
    public string? CodObs { get; set; }

    [Column("cod_cta")]
    [StringLength(255)]
    public string? CodCta { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC300s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
