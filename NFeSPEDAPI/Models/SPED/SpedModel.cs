using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.SPED;

[Table("sped_arquivos")]
public class SpedModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [Column("cnpj")]
    public string CNPJ { get; set; }

    [Required]
    [Column("nome_empresa")]
    public string NomeEmpresa { get; set; }

    [Required]
    [Column("periodo_inicial")]
    public DateTime PeriodoInicial { get; set; }

    [Required]
    [Column("periodo_final")]
    public DateTime PeriodoFinal { get; set; }

    [Required]
    [Column("data_importacao")]
    public DateTime DataImportacao { get; set; } = DateTime.Now;

    [Column("arquivo_completo")]
    public string ArquivoCompleto { get; set; }

    // Relacionamentos
    public ICollection<SpedBlocoModel> Blocos { get; set; } = new List<SpedBlocoModel>();
}