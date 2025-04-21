using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b035")]
public partial class RegB035
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

    [Column("vl_cont_p")]
    [Precision(21, 2)]
    public decimal? VlContP { get; set; }

    [Column("vl_bc_iss_p")]
    [Precision(21, 2)]
    public decimal? VlBcIssP { get; set; }

    [Column("aliq_iss")]
    [Precision(21, 2)]
    public decimal? AliqIss { get; set; }

    [Column("vl_iss_p")]
    [Precision(21, 2)]
    public decimal? VlIssP { get; set; }

    [Column("vl_isnt_iss_p")]
    [Precision(21, 2)]
    public decimal? VlIsntIssP { get; set; }

    [Column("cod_serv")]
    [StringLength(4)]
    public string? CodServ { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB035s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
