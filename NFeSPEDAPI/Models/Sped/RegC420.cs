using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c420")]
public partial class RegC420
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

    [Column("cod_tot_par")]
    [StringLength(7)]
    public string? CodTotPar { get; set; }

    [Column("vlr_acum_tot")]
    [Precision(21, 2)]
    public decimal? VlrAcumTot { get; set; }

    [Column("nr_tot")]
    [StringLength(2)]
    public string? NrTot { get; set; }

    [Column("descr_nr_tot")]
    [StringLength(255)]
    public string? DescrNrTot { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC420s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
