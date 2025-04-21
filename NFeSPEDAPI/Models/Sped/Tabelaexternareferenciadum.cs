using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.Sped;

[Table("tabelaexternareferenciada")]
public partial class Tabelaexternareferenciadum
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("tipo")]
    [StringLength(255)]
    public string Tipo { get; set; } = null!;

    [Column("versao")]
    public int Versao { get; set; }

    [Column("listaufs")]
    [StringLength(100)]
    public string? Listaufs { get; set; }

    [Column("hash")]
    public long Hash { get; set; }
}
