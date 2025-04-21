using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0305")]
public partial class Reg0305
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

    [Column("cod_ccus")]
    [StringLength(60)]
    public string? CodCcus { get; set; }

    [Column("func")]
    [StringLength(255)]
    public string? Func { get; set; }

    [Column("vida_util")]
    [StringLength(3)]
    public string? VidaUtil { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0305s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
