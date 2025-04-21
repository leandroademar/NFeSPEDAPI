using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.Sped;

[Table("tabela_uf")]
public partial class TabelaUf
{
    [Key]
    [Column("codigo")]
    public int Codigo { get; set; }

    [Column("sigla")]
    [StringLength(2)]
    public string Sigla { get; set; } = null!;

    [Column("descricao")]
    [StringLength(45)]
    public string? Descricao { get; set; }

    [Column("nomesecretaria")]
    [StringLength(120)]
    public string? Nomesecretaria { get; set; }
}
