using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0150")]
public partial class Reg0150
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

    [Column("cod_part")]
    [StringLength(60)]
    public string? CodPart { get; set; }

    [Column("nome")]
    [StringLength(100)]
    public string? Nome { get; set; }

    [Column("cod_pais")]
    [StringLength(5)]
    public string? CodPais { get; set; }

    [Column("cnpj")]
    [StringLength(14)]
    public string? Cnpj { get; set; }

    [Column("cpf")]
    [StringLength(11)]
    public string? Cpf { get; set; }

    [Column("ie")]
    [StringLength(14)]
    public string? Ie { get; set; }

    [Column("cod_mun")]
    [StringLength(7)]
    public string? CodMun { get; set; }

    [Column("suframa")]
    [StringLength(9)]
    public string? Suframa { get; set; }

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

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0150s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
