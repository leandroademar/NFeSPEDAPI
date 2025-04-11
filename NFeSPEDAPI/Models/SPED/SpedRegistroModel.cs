using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.SPED;

[Table("sped_registros")]
public class SpedRegistroModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [Column("bloco_id")]
    public Guid BlocoId { get; set; }

    [Required]
    [Column("codigo_registro")]
    public string CodigoRegistro { get; set; }

    [Required]
    [Column("conteudo")]
    public string Conteudo { get; set; }

    [Column("linha_arquivo")]
    public int LinhaArquivo { get; set; }

    // Referência para o Bloco pai
    [ForeignKey("BlocoId")]
    public SpedBlocoModel Bloco { get; set; }
}