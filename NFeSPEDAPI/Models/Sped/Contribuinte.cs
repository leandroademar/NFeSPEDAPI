using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.Sped;

[Table("contribuinte")]
public partial class Contribuinte
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("nome")]
    [StringLength(255)]
    public string Nome { get; set; } = null!;

    [Column("cpf_cnpj")]
    [StringLength(14)]
    public string CpfCnpj { get; set; } = null!;

    [Column("ie")]
    [StringLength(14)]
    public string Ie { get; set; } = null!;

    [Column("cod_mun")]
    [StringLength(7)]
    public string CodMun { get; set; } = null!;

    [Column("uf")]
    [StringLength(2)]
    public string Uf { get; set; } = null!;

    [Column("im")]
    [StringLength(255)]
    public string? Im { get; set; }

    [Column("suframa")]
    [StringLength(9)]
    public string? Suframa { get; set; }

    [Column("ind_ativ")]
    public int IndAtiv { get; set; }

    [Column("nomebd")]
    [StringLength(255)]
    public string Nomebd { get; set; } = null!;

    [Column("hash")]
    public long Hash { get; set; }

    [Column("id_descritor_contribuinte")]
    public int? IdDescritorContribuinte { get; set; }

    [Column("versao_descritor_contribuinte")]
    public int? VersaoDescritorContribuinte { get; set; }
}
