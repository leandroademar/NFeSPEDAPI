using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1370")]
public partial class Reg1370
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

    [Column("num_bico")]
    [StringLength(3)]
    public string? NumBico { get; set; }

    [Column("cod_item")]
    [StringLength(60)]
    public string? CodItem { get; set; }

    [Column("num_tanque")]
    [StringLength(3)]
    public string? NumTanque { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1370s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
