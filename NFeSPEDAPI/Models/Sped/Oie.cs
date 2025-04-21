using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.Sped;

[Table("oie")]
public partial class Oie
{
    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [Column("hash")]
    public long Hash { get; set; }

    [Column("cpf_cnpj")]
    [StringLength(14)]
    public string CpfCnpj { get; set; } = null!;

    [Column("nome_contribuinte")]
    [StringLength(255)]
    public string NomeContribuinte { get; set; } = null!;

    [Column("ie")]
    [StringLength(14)]
    public string Ie { get; set; } = null!;

    [Column("finalidade")]
    public int Finalidade { get; set; }

    [Column("estado")]
    public int Estado { get; set; }

    [Column("datainicial")]
    public DateOnly Datainicial { get; set; }

    [Column("datafinal")]
    public DateOnly Datafinal { get; set; }

    [Column("perfil")]
    public int Perfil { get; set; }

    [Column("nomebd")]
    [StringLength(255)]
    public string Nomebd { get; set; } = null!;

    [Column("localizacaoarquivo")]
    public string? Localizacaoarquivo { get; set; }

    [Column("hasharquivo")]
    [StringLength(40)]
    public string? Hasharquivo { get; set; }

    [Column("hasharquivodisco")]
    [StringLength(40)]
    public string? Hasharquivodisco { get; set; }

    [Column("hashrecibo")]
    [StringLength(40)]
    public string? Hashrecibo { get; set; }

    [Column("uf")]
    [StringLength(2)]
    public string Uf { get; set; } = null!;

    [Column("codigo_municipio")]
    [StringLength(7)]
    public string? CodigoMunicipio { get; set; }

    [Column("metadadosvalidacao")]
    public string? Metadadosvalidacao { get; set; }

    [Column("ato_cotepe")]
    public int AtoCotepe { get; set; }

    [Column("id_descritor_validacao")]
    public int? IdDescritorValidacao { get; set; }

    [Column("versao_descritor_validacao")]
    public int? VersaoDescritorValidacao { get; set; }

    [Column("tamanhosemassinatura")]
    public long? Tamanhosemassinatura { get; set; }
}
