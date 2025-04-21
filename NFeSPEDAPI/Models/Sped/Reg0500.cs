using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0500")]
public partial class Reg0500
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

    [Column("dt_alt")]
    public DateOnly? DtAlt { get; set; }

    [Column("cod_nat_cc")]
    [StringLength(2)]
    public string? CodNatCc { get; set; }

    [Column("ind_cta")]
    [StringLength(1)]
    public string? IndCta { get; set; }

    [Column("nivel")]
    [StringLength(5)]
    public string? Nivel { get; set; }

    [Column("cod_cta")]
    [StringLength(60)]
    public string? CodCta { get; set; }

    [Column("nome_cta")]
    [StringLength(60)]
    public string? NomeCta { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0500s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
