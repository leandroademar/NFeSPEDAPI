using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c140")]
public partial class RegC140
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

    [Column("ind_emit")]
    [StringLength(1)]
    public string? IndEmit { get; set; }

    [Column("ind_tit")]
    [StringLength(2)]
    public string? IndTit { get; set; }

    [Column("desc_tit")]
    [StringLength(255)]
    public string? DescTit { get; set; }

    [Column("num_tit")]
    [StringLength(255)]
    public string? NumTit { get; set; }

    [Column("qtd_parc")]
    [StringLength(2)]
    public string? QtdParc { get; set; }

    [Column("vl_tit")]
    [Precision(21, 2)]
    public decimal? VlTit { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC140s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
