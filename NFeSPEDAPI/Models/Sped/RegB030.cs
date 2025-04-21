using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b030")]
public partial class RegB030
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
    [StringLength(3)]
    public string? Ser { get; set; }

    [Column("num_doc_ini")]
    [StringLength(9)]
    public string? NumDocIni { get; set; }

    [Column("num_doc_fin")]
    [StringLength(9)]
    public string? NumDocFin { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("qtd_canc")]
    [StringLength(255)]
    public string? QtdCanc { get; set; }

    [Column("vl_cont")]
    [Precision(21, 2)]
    public decimal? VlCont { get; set; }

    [Column("vl_isnt_iss")]
    [Precision(21, 2)]
    public decimal? VlIsntIss { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB030s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
