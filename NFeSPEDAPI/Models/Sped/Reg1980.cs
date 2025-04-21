using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1980")]
public partial class Reg1980
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

    [Column("ind_ap")]
    [StringLength(2)]
    public string? IndAp { get; set; }

    [Column("g4_01")]
    [Precision(21, 2)]
    public decimal? G401 { get; set; }

    [Column("g4_02")]
    [Precision(21, 2)]
    public decimal? G402 { get; set; }

    [Column("g4_03")]
    [Precision(21, 2)]
    public decimal? G403 { get; set; }

    [Column("g4_04")]
    [Precision(21, 2)]
    public decimal? G404 { get; set; }

    [Column("g4_05")]
    [Precision(21, 2)]
    public decimal? G405 { get; set; }

    [Column("g4_06")]
    [Precision(21, 2)]
    public decimal? G406 { get; set; }

    [Column("g4_07")]
    [Precision(21, 2)]
    public decimal? G407 { get; set; }

    [Column("g4_08")]
    [Precision(21, 2)]
    public decimal? G408 { get; set; }

    [Column("g4_09")]
    [Precision(21, 2)]
    public decimal? G409 { get; set; }

    [Column("g4_10")]
    [Precision(21, 2)]
    public decimal? G410 { get; set; }

    [Column("g4_11")]
    [Precision(21, 2)]
    public decimal? G411 { get; set; }

    [Column("g4_12")]
    [Precision(21, 2)]
    public decimal? G412 { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1980s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
