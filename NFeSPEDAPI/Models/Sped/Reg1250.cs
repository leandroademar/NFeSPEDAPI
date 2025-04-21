using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1250")]
public partial class Reg1250
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

    [Column("vl_credito_icms_op")]
    [Precision(21, 2)]
    public decimal? VlCreditoIcmsOp { get; set; }

    [Column("vl_icms_st_rest")]
    [Precision(21, 2)]
    public decimal? VlIcmsStRest { get; set; }

    [Column("vl_fcp_st_rest")]
    [Precision(21, 2)]
    public decimal? VlFcpStRest { get; set; }

    [Column("vl_icms_st_compl")]
    [Precision(21, 2)]
    public decimal? VlIcmsStCompl { get; set; }

    [Column("vl_fcp_st_compl")]
    [Precision(21, 2)]
    public decimal? VlFcpStCompl { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1250s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
