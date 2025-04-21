using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1960")]
public partial class Reg1960
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

    [Column("g1_01")]
    [Precision(21, 2)]
    public decimal? G101 { get; set; }

    [Column("g1_02")]
    [Precision(21, 2)]
    public decimal? G102 { get; set; }

    [Column("g1_03")]
    [Precision(21, 2)]
    public decimal? G103 { get; set; }

    [Column("g1_04")]
    [Precision(21, 2)]
    public decimal? G104 { get; set; }

    [Column("g1_05")]
    [Precision(21, 2)]
    public decimal? G105 { get; set; }

    [Column("g1_06")]
    [Precision(21, 2)]
    public decimal? G106 { get; set; }

    [Column("g1_07")]
    [Precision(21, 2)]
    public decimal? G107 { get; set; }

    [Column("g1_08")]
    [Precision(21, 2)]
    public decimal? G108 { get; set; }

    [Column("g1_09")]
    [Precision(21, 2)]
    public decimal? G109 { get; set; }

    [Column("g1_10")]
    [Precision(21, 2)]
    public decimal? G110 { get; set; }

    [Column("g1_11")]
    [Precision(21, 2)]
    public decimal? G111 { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1960s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
