using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0100")]
public partial class Reg0100
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

    [Column("nome")]
    [StringLength(60)]
    public string? Nome { get; set; }

    [Column("cpf")]
    [StringLength(11)]
    public string? Cpf { get; set; }

    [Column("crc")]
    [StringLength(15)]
    public string? Crc { get; set; }

    [Column("cnpj")]
    [StringLength(14)]
    public string? Cnpj { get; set; }

    [Column("cep")]
    [StringLength(8)]
    public string? Cep { get; set; }

    [Column("endereco")]
    [StringLength(60)]
    public string? Endereco { get; set; }

    [Column("num")]
    [StringLength(10)]
    public string? Num { get; set; }

    [Column("compl")]
    [StringLength(60)]
    public string? Compl { get; set; }

    [Column("bairro")]
    [StringLength(60)]
    public string? Bairro { get; set; }

    [Column("fone")]
    [StringLength(11)]
    public string? Fone { get; set; }

    [Column("fax")]
    [StringLength(11)]
    public string? Fax { get; set; }

    [Column("email")]
    [StringLength(60)]
    public string? Email { get; set; }

    [Column("cod_mun")]
    [StringLength(7)]
    public string? CodMun { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0100s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
