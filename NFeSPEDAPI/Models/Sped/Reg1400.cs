using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1400")]
public partial class Reg1400
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

    [Column("cod_item_ipm")]
    [StringLength(60)]
    public string? CodItemIpm { get; set; }

    [Column("mun")]
    [StringLength(7)]
    public string? Mun { get; set; }

    [Column("valor")]
    [Precision(21, 2)]
    public decimal? Valor { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1400s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
