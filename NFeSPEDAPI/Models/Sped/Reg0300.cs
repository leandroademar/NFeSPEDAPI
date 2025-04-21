using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0300")]
[Index("CodPrnc", Name = "idx_cod_prnc")]
public partial class Reg0300
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

    [Column("cod_ind_bem")]
    [StringLength(60)]
    public string? CodIndBem { get; set; }

    [Column("ident_merc")]
    [StringLength(1)]
    public string? IdentMerc { get; set; }

    [Column("descr_item")]
    [StringLength(255)]
    public string? DescrItem { get; set; }

    [Column("cod_prnc")]
    [StringLength(60)]
    public string? CodPrnc { get; set; }

    [Column("cod_cta")]
    [StringLength(60)]
    public string? CodCta { get; set; }

    [Column("nr_parc")]
    [StringLength(3)]
    public string? NrParc { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0300s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
