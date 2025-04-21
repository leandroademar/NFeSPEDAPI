using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1391")]
public partial class Reg1391
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

    [Column("dt_registro")]
    public DateOnly? DtRegistro { get; set; }

    [Column("qtd")]
    [Precision(21, 2)]
    public decimal? Qtd { get; set; }

    [Column("estq_ini")]
    [Precision(21, 2)]
    public decimal? EstqIni { get; set; }

    [Column("qtd_produz")]
    [Precision(21, 2)]
    public decimal? QtdProduz { get; set; }

    [Column("ent_anid_hid")]
    [Precision(21, 2)]
    public decimal? EntAnidHid { get; set; }

    [Column("outr_entr")]
    [Precision(21, 2)]
    public decimal? OutrEntr { get; set; }

    [Column("perda")]
    [Precision(21, 2)]
    public decimal? Perda { get; set; }

    [Column("cons")]
    [Precision(21, 2)]
    public decimal? Cons { get; set; }

    [Column("sai_ani_hid")]
    [Precision(21, 2)]
    public decimal? SaiAniHid { get; set; }

    [Column("saidas")]
    [Precision(21, 2)]
    public decimal? Saidas { get; set; }

    [Column("estq_fin")]
    [Precision(21, 2)]
    public decimal? EstqFin { get; set; }

    [Column("estq_ini_mel")]
    [Precision(21, 2)]
    public decimal? EstqIniMel { get; set; }

    [Column("prod_dia_mel")]
    [Precision(21, 2)]
    public decimal? ProdDiaMel { get; set; }

    [Column("util_mel")]
    [Precision(21, 2)]
    public decimal? UtilMel { get; set; }

    [Column("prod_alc_mel")]
    [Precision(21, 2)]
    public decimal? ProdAlcMel { get; set; }

    [Column("obs")]
    [StringLength(255)]
    public string? Obs { get; set; }

    [Column("cod_item")]
    [StringLength(60)]
    public string? CodItem { get; set; }

    [Column("tp_residuo")]
    [StringLength(2)]
    public string? TpResiduo { get; set; }

    [Column("qtd_residuo")]
    [Precision(21, 2)]
    public decimal? QtdResiduo { get; set; }

    [Column("qtd_residuo_ddg")]
    [Precision(21, 2)]
    public decimal? QtdResiduoDdg { get; set; }

    [Column("qtd_residuo_wdg")]
    [Precision(21, 2)]
    public decimal? QtdResiduoWdg { get; set; }

    [Column("qtd_residuo_cana")]
    [Precision(21, 2)]
    public decimal? QtdResiduoCana { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1391s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
