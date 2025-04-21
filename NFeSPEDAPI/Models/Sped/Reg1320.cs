using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1320")]
public partial class Reg1320
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

    [Column("num_bico")]
    [StringLength(255)]
    public string? NumBico { get; set; }

    [Column("nr_interv")]
    [StringLength(255)]
    public string? NrInterv { get; set; }

    [Column("mot_interv")]
    [StringLength(50)]
    public string? MotInterv { get; set; }

    [Column("nom_interv")]
    [StringLength(30)]
    public string? NomInterv { get; set; }

    [Column("cnpj_interv")]
    [StringLength(14)]
    public string? CnpjInterv { get; set; }

    [Column("cpf_interv")]
    [StringLength(11)]
    public string? CpfInterv { get; set; }

    [Column("val_fecha")]
    [Precision(22, 3)]
    public decimal? ValFecha { get; set; }

    [Column("val_abert")]
    [Precision(22, 3)]
    public decimal? ValAbert { get; set; }

    [Column("vol_aferi")]
    [Precision(22, 3)]
    public decimal? VolAferi { get; set; }

    [Column("vol_vendas")]
    [Precision(22, 3)]
    public decimal? VolVendas { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1320s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
