using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c191")]
public partial class RegC191
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

    [Column("vl_fcp_op")]
    [Precision(21, 2)]
    public decimal? VlFcpOp { get; set; }

    [Column("vl_fcp_st")]
    [Precision(21, 2)]
    public decimal? VlFcpSt { get; set; }

    [Column("vl_fcp_ret")]
    [Precision(21, 2)]
    public decimal? VlFcpRet { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC191s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
