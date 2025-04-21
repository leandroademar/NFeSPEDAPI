using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b350")]
public partial class RegB350
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

    [Column("cod_ctd")]
    [StringLength(255)]
    public string? CodCtd { get; set; }

    [Column("cta_iss")]
    [StringLength(255)]
    public string? CtaIss { get; set; }

    [Column("cta_cosif")]
    [StringLength(8)]
    public string? CtaCosif { get; set; }

    [Column("qtd_ocor")]
    [StringLength(255)]
    public string? QtdOcor { get; set; }

    [Column("cod_serv")]
    [StringLength(4)]
    public string? CodServ { get; set; }

    [Column("vl_cont")]
    [Precision(21, 2)]
    public decimal? VlCont { get; set; }

    [Column("vl_bc_iss")]
    [Precision(21, 2)]
    public decimal? VlBcIss { get; set; }

    [Column("aliq_iss")]
    [Precision(21, 2)]
    public decimal? AliqIss { get; set; }

    [Column("vl_iss")]
    [Precision(21, 2)]
    public decimal? VlIss { get; set; }

    [Column("cod_inf_obs")]
    [StringLength(6)]
    public string? CodInfObs { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB350s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
