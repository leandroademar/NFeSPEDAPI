using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.Sped;

[Table("inconsistencia")]
public partial class Inconsistencium
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("tipo")]
    [MaxLength(1)]
    public char Tipo { get; set; }

    [Column("id_mensagem")]
    [StringLength(100)]
    public string IdMensagem { get; set; } = null!;

    [Column("id_campo")]
    [StringLength(50)]
    public string? IdCampo { get; set; }

    [Column("valor_campo")]
    [StringLength(1024)]
    public string? ValorCampo { get; set; }

    [Column("valor_esperado_campo")]
    [StringLength(256)]
    public string? ValorEsperadoCampo { get; set; }

    [Column("nome_registro")]
    [StringLength(10)]
    public string? NomeRegistro { get; set; }

    [Column("conteudo_linha")]
    [StringLength(2048)]
    public string? ConteudoLinha { get; set; }

    [Column("numero_linha")]
    public long? NumeroLinha { get; set; }

    [Column("id_registro_bd")]
    public long? IdRegistroBd { get; set; }

    [Column("id_registro_pai_bd")]
    public long? IdRegistroPaiBd { get; set; }

    [Column("parametros_mensagem")]
    [StringLength(500)]
    public string? ParametrosMensagem { get; set; }
}
