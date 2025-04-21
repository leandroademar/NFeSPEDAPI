using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1210")]
public partial class Reg1210
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

    [Column("tipo_util")]
    [StringLength(4)]
    public string? TipoUtil { get; set; }

    [Column("nr_doc")]
    [StringLength(255)]
    public string? NrDoc { get; set; }

    [Column("vl_cred_util")]
    [Precision(21, 2)]
    public decimal? VlCredUtil { get; set; }

    [Column("chv_doce")]
    [StringLength(44)]
    public string? ChvDoce { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1210s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
