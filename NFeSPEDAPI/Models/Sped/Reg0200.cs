using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0200")]
[Index("CodItem", Name = "idx_cod_item")]
[Index("UnidInv", Name = "idx_unid_inv")]
public partial class Reg0200
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

    [Column("cod_item")]
    [StringLength(60)]
    public string? CodItem { get; set; }

    [Column("descr_item")]
    [StringLength(255)]
    public string? DescrItem { get; set; }

    [Column("cod_barra")]
    [StringLength(20)]
    public string? CodBarra { get; set; }

    [Column("cod_ant_item")]
    [StringLength(60)]
    public string? CodAntItem { get; set; }

    [Column("unid_inv")]
    [StringLength(6)]
    public string? UnidInv { get; set; }

    [Column("tipo_item")]
    [StringLength(2)]
    public string? TipoItem { get; set; }

    [Column("cod_ncm")]
    [StringLength(8)]
    public string? CodNcm { get; set; }

    [Column("ex_ipi")]
    [StringLength(3)]
    public string? ExIpi { get; set; }

    [Column("cod_gen")]
    [StringLength(2)]
    public string? CodGen { get; set; }

    [Column("cod_lst")]
    [StringLength(5)]
    public string? CodLst { get; set; }

    [Column("aliq_icms")]
    [Precision(8, 2)]
    public decimal? AliqIcms { get; set; }

    [Column("cest")]
    [StringLength(7)]
    public string? Cest { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0200s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
