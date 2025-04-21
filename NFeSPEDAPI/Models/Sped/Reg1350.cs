using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1350")]
public partial class Reg1350
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

    [Column("serie")]
    [StringLength(255)]
    public string? Serie { get; set; }

    [Column("fabricante")]
    [StringLength(60)]
    public string? Fabricante { get; set; }

    [Column("modelo")]
    [StringLength(255)]
    public string? Modelo { get; set; }

    [Column("tipo_medicao")]
    [StringLength(1)]
    public string? TipoMedicao { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1350s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
