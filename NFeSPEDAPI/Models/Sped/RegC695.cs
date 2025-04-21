using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c695")]
[Index("NroOrdFin", Name = "idx_nro_ord_fin")]
[Index("NroOrdIni", Name = "idx_nro_ord_ini")]
[Index("Ser", Name = "idx_ser")]
public partial class RegC695
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

    [Column("cod_mod")]
    [StringLength(2)]
    public string? CodMod { get; set; }

    [Column("ser")]
    [StringLength(4)]
    public string? Ser { get; set; }

    [Column("nro_ord_ini")]
    [StringLength(9)]
    public string? NroOrdIni { get; set; }

    [Column("nro_ord_fin")]
    [StringLength(9)]
    public string? NroOrdFin { get; set; }

    [Column("dt_doc_ini")]
    public DateOnly? DtDocIni { get; set; }

    [Column("dt_doc_fin")]
    public DateOnly? DtDocFin { get; set; }

    [Column("nom_mest")]
    [StringLength(33)]
    public string? NomMest { get; set; }

    [Column("chv_cod_dig")]
    [StringLength(32)]
    public string? ChvCodDig { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC695s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
