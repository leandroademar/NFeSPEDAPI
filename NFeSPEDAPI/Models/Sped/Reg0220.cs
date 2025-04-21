using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0220")]
public partial class Reg0220
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

    [Column("unid_conv")]
    [StringLength(6)]
    public string? UnidConv { get; set; }

    [Column("fat_conv")]
    [Precision(25, 6)]
    public decimal? FatConv { get; set; }

    [Column("cod_barra")]
    [StringLength(20)]
    public string? CodBarra { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0220s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
