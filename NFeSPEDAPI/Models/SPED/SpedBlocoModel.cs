using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.SPED;

[Table("sped_blocos")]
public class SpedBlocoModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [Column("sped_id")]
    public Guid SpedId { get; set; }

    [Required]
    [Column("codigo_bloco")]
    public string CodigoBloco { get; set; }

    [Required]
    [Column("descricao")]
    public string Descricao { get; set; }

    // Referência para o SPED pai
    [ForeignKey("SpedId")]
    public SpedModel Sped { get; set; }

    // Relacionamento com os registros
    public ICollection<SpedRegistroModel> Registros { get; set; } = new List<SpedRegistroModel>();
}