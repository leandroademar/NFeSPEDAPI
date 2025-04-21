using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c116")]
public partial class RegC116
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

    [Column("nr_sat")]
    [StringLength(9)]
    public string? NrSat { get; set; }

    [Column("chv_cfe")]
    [StringLength(44)]
    public string? ChvCfe { get; set; }

    [Column("num_cfe")]
    [StringLength(6)]
    public string? NumCfe { get; set; }

    [Column("dt_doc")]
    [StringLength(8)]
    public string? DtDoc { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC116s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
