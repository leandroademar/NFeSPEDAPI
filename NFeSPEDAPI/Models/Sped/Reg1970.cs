using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1970")]
public partial class Reg1970
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

    [Column("g3_01")]
    [Precision(21, 2)]
    public decimal? G301 { get; set; }

    [Column("g3_02")]
    [Precision(21, 2)]
    public decimal? G302 { get; set; }

    [Column("g3_03")]
    [Precision(21, 2)]
    public decimal? G303 { get; set; }

    [Column("g3_04")]
    [Precision(21, 2)]
    public decimal? G304 { get; set; }

    [Column("g3_05")]
    [Precision(21, 2)]
    public decimal? G305 { get; set; }

    [Column("g3_06")]
    [Precision(21, 2)]
    public decimal? G306 { get; set; }

    [Column("g3_07")]
    [Precision(21, 2)]
    public decimal? G307 { get; set; }

    [Column("g3_t")]
    [Precision(21, 2)]
    public decimal? G3T { get; set; }

    [Column("g3_08")]
    [Precision(21, 2)]
    public decimal? G308 { get; set; }

    [Column("g3_09")]
    [Precision(21, 2)]
    public decimal? G309 { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1970s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
