using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c160")]
public partial class RegC160
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

    [Column("cod_part")]
    [StringLength(60)]
    public string? CodPart { get; set; }

    [Column("veic_id")]
    [StringLength(7)]
    public string? VeicId { get; set; }

    [Column("qtd_vol")]
    [StringLength(255)]
    public string? QtdVol { get; set; }

    [Column("peso_brt")]
    [Precision(21, 2)]
    public decimal? PesoBrt { get; set; }

    [Column("peso_liq")]
    [Precision(21, 2)]
    public decimal? PesoLiq { get; set; }

    [Column("uf_id")]
    [StringLength(2)]
    public string? UfId { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC160s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
