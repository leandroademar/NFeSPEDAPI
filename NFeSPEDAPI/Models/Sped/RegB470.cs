using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b470")]
public partial class RegB470
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

    [Column("vl_cont")]
    [Precision(21, 2)]
    public decimal? VlCont { get; set; }

    [Column("vl_mat_terc")]
    [Precision(21, 2)]
    public decimal? VlMatTerc { get; set; }

    [Column("vl_mat_prop")]
    [Precision(21, 2)]
    public decimal? VlMatProp { get; set; }

    [Column("vl_sub")]
    [Precision(21, 2)]
    public decimal? VlSub { get; set; }

    [Column("vl_isnt")]
    [Precision(21, 2)]
    public decimal? VlIsnt { get; set; }

    [Column("vl_ded_bc")]
    [Precision(21, 2)]
    public decimal? VlDedBc { get; set; }

    [Column("vl_bc_iss")]
    [Precision(21, 2)]
    public decimal? VlBcIss { get; set; }

    [Column("vl_bc_iss_rt")]
    [Precision(21, 2)]
    public decimal? VlBcIssRt { get; set; }

    [Column("vl_iss")]
    [Precision(21, 2)]
    public decimal? VlIss { get; set; }

    [Column("vl_iss_rt")]
    [Precision(21, 2)]
    public decimal? VlIssRt { get; set; }

    [Column("vl_ded")]
    [Precision(21, 2)]
    public decimal? VlDed { get; set; }

    [Column("vl_iss_rec")]
    [Precision(21, 2)]
    public decimal? VlIssRec { get; set; }

    [Column("vl_iss_st")]
    [Precision(21, 2)]
    public decimal? VlIssSt { get; set; }

    [Column("vl_iss_rec_uni")]
    [Precision(21, 2)]
    public decimal? VlIssRecUni { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB470s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
