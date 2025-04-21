using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c173")]
public partial class RegC173
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

    [Column("lote_med")]
    [StringLength(255)]
    public string? LoteMed { get; set; }

    [Column("qtd_item")]
    [Precision(22, 3)]
    public decimal? QtdItem { get; set; }

    [Column("dt_fab")]
    public DateOnly? DtFab { get; set; }

    [Column("dt_val")]
    public DateOnly? DtVal { get; set; }

    [Column("ind_med")]
    [StringLength(1)]
    public string? IndMed { get; set; }

    [Column("tp_prod")]
    [StringLength(1)]
    public string? TpProd { get; set; }

    [Column("vl_tab_max")]
    [Precision(21, 2)]
    public decimal? VlTabMax { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC173s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
