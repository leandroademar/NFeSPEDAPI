using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1601")]
public partial class Reg1601
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

    [Column("cod_part_ip")]
    [StringLength(60)]
    public string? CodPartIp { get; set; }

    [Column("cod_part_it")]
    [StringLength(60)]
    public string? CodPartIt { get; set; }

    [Column("tot_vs")]
    [Precision(21, 2)]
    public decimal? TotVs { get; set; }

    [Column("tot_iss")]
    [Precision(21, 2)]
    public decimal? TotIss { get; set; }

    [Column("tot_outros")]
    [Precision(21, 2)]
    public decimal? TotOutros { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1601s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
