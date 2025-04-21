using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c405")]
public partial class RegC405
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

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("cro")]
    [StringLength(3)]
    public string? Cro { get; set; }

    [Column("crz")]
    [StringLength(6)]
    public string? Crz { get; set; }

    [Column("num_coo_fin")]
    [StringLength(9)]
    public string? NumCooFin { get; set; }

    [Column("gt_fin")]
    [Precision(21, 2)]
    public decimal? GtFin { get; set; }

    [Column("vl_brt")]
    [Precision(21, 2)]
    public decimal? VlBrt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC405s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
