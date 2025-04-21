using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1100")]
public partial class Reg1100
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

    [Column("ind_doc")]
    [StringLength(1)]
    public string? IndDoc { get; set; }

    [Column("nro_de")]
    [StringLength(14)]
    public string? NroDe { get; set; }

    [Column("dt_de")]
    public DateOnly? DtDe { get; set; }

    [Column("nat_exp")]
    [StringLength(1)]
    public string? NatExp { get; set; }

    [Column("nro_re")]
    [StringLength(12)]
    public string? NroRe { get; set; }

    [Column("dt_re")]
    public DateOnly? DtRe { get; set; }

    [Column("chc_emb")]
    [StringLength(18)]
    public string? ChcEmb { get; set; }

    [Column("dt_chc")]
    public DateOnly? DtChc { get; set; }

    [Column("dt_avb")]
    public DateOnly? DtAvb { get; set; }

    [Column("tp_chc")]
    [StringLength(2)]
    public string? TpChc { get; set; }

    [Column("pais")]
    [StringLength(3)]
    public string? Pais { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1100s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
