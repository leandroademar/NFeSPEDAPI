using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c172")]
public partial class RegC172
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

    [Column("vl_bc_issqn")]
    [Precision(21, 2)]
    public decimal? VlBcIssqn { get; set; }

    [Column("aliq_issqn")]
    [Precision(8, 2)]
    public decimal? AliqIssqn { get; set; }

    [Column("vl_issqn")]
    [Precision(21, 2)]
    public decimal? VlIssqn { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC172s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
