using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c101")]
public partial class RegC101
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

    [Column("vl_fcp_uf_dest")]
    [Precision(21, 2)]
    public decimal? VlFcpUfDest { get; set; }

    [Column("vl_icms_uf_dest")]
    [Precision(21, 2)]
    public decimal? VlIcmsUfDest { get; set; }

    [Column("vl_icms_uf_rem")]
    [Precision(21, 2)]
    public decimal? VlIcmsUfRem { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC101s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
