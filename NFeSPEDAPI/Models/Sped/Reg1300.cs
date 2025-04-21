using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1300")]
public partial class Reg1300
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

    [Column("cod_item")]
    [StringLength(60)]
    public string? CodItem { get; set; }

    [Column("dt_fech")]
    public DateOnly? DtFech { get; set; }

    [Column("estq_abert")]
    [Precision(22, 3)]
    public decimal? EstqAbert { get; set; }

    [Column("vol_entr")]
    [Precision(22, 3)]
    public decimal? VolEntr { get; set; }

    [Column("vol_disp")]
    [Precision(22, 3)]
    public decimal? VolDisp { get; set; }

    [Column("vol_saidas")]
    [Precision(22, 3)]
    public decimal? VolSaidas { get; set; }

    [Column("estq_escr")]
    [Precision(22, 3)]
    public decimal? EstqEscr { get; set; }

    [Column("val_aj_perda")]
    [Precision(22, 3)]
    public decimal? ValAjPerda { get; set; }

    [Column("val_aj_ganho")]
    [Precision(22, 3)]
    public decimal? ValAjGanho { get; set; }

    [Column("fech_fisico")]
    [Precision(22, 3)]
    public decimal? FechFisico { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1300s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
