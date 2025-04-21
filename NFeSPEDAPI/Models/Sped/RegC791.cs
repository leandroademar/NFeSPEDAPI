using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c791")]
public partial class RegC791
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

    [Column("uf")]
    [StringLength(2)]
    public string? Uf { get; set; }

    [Column("vl_bc_icms_st")]
    [Precision(21, 2)]
    public decimal? VlBcIcmsSt { get; set; }

    [Column("vl_icms_st")]
    [Precision(21, 2)]
    public decimal? VlIcmsSt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC791s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
