using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1255")]
public partial class Reg1255
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

    [Column("cod_mot_rest_compl")]
    [StringLength(5)]
    public string? CodMotRestCompl { get; set; }

    [Column("vl_credito_icms_op_mot")]
    [Precision(21, 2)]
    public decimal? VlCreditoIcmsOpMot { get; set; }

    [Column("vl_icms_st_rest_mot")]
    [Precision(21, 2)]
    public decimal? VlIcmsStRestMot { get; set; }

    [Column("vl_fcp_st_rest_mot")]
    [Precision(21, 2)]
    public decimal? VlFcpStRestMot { get; set; }

    [Column("vl_icms_st_compl_mot")]
    [Precision(21, 2)]
    public decimal? VlIcmsStComplMot { get; set; }

    [Column("vl_fcp_st_compl_mot")]
    [Precision(21, 2)]
    public decimal? VlFcpStComplMot { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1255s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
