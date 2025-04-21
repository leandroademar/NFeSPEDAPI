using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c141")]
public partial class RegC141
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

    [Column("num_parc")]
    [StringLength(2)]
    public string? NumParc { get; set; }

    [Column("dt_vcto")]
    public DateOnly? DtVcto { get; set; }

    [Column("vl_parc")]
    [Precision(21, 2)]
    public decimal? VlParc { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC141s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
