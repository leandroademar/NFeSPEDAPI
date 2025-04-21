using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0205")]
[Index("CodAntItem", Name = "idx_cod_ant_item")]
[Index("DtFim", Name = "idx_dt_fim")]
[Index("DtIni", Name = "idx_dt_ini")]
public partial class Reg0205
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

    [Column("descr_ant_item")]
    [StringLength(255)]
    public string? DescrAntItem { get; set; }

    [Column("dt_ini")]
    public DateOnly? DtIni { get; set; }

    [Column("dt_fim")]
    public DateOnly? DtFim { get; set; }

    [Column("cod_ant_item")]
    [StringLength(60)]
    public string? CodAntItem { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0205s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
