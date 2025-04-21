using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c860")]
public partial class RegC860
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

    [Column("nr_sat")]
    [StringLength(9)]
    public string? NrSat { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("doc_ini")]
    [StringLength(6)]
    public string? DocIni { get; set; }

    [Column("doc_fim")]
    [StringLength(6)]
    public string? DocFim { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC860s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
