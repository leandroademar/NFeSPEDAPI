using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1975")]
public partial class Reg1975
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

    [Column("aliq_imp_base")]
    [Precision(21, 2)]
    public decimal? AliqImpBase { get; set; }

    [Column("g3_10")]
    [Precision(21, 2)]
    public decimal? G310 { get; set; }

    [Column("g3_11")]
    [Precision(21, 2)]
    public decimal? G311 { get; set; }

    [Column("g3_12")]
    [Precision(21, 2)]
    public decimal? G312 { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1975s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
