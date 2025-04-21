using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c174")]
public partial class RegC174
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

    [Column("ind_arm")]
    [StringLength(1)]
    public string? IndArm { get; set; }

    [Column("num_arm")]
    [StringLength(255)]
    public string? NumArm { get; set; }

    [Column("descr_compl")]
    [StringLength(255)]
    public string? DescrCompl { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC174s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
