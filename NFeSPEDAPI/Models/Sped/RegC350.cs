using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c350")]
public partial class RegC350
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

    [Column("ser")]
    [StringLength(4)]
    public string? Ser { get; set; }

    [Column("sub_ser")]
    [StringLength(3)]
    public string? SubSer { get; set; }

    [Column("num_doc")]
    [StringLength(6)]
    public string? NumDoc { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("cnpj_cpf")]
    [StringLength(14)]
    public string? CnpjCpf { get; set; }

    [Column("vl_merc")]
    [Precision(21, 2)]
    public decimal? VlMerc { get; set; }

    [Column("vl_doc")]
    [Precision(21, 2)]
    public decimal? VlDoc { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Column("vl_pis")]
    [Precision(21, 2)]
    public decimal? VlPis { get; set; }

    [Column("vl_cofis")]
    [Precision(21, 2)]
    public decimal? VlCofis { get; set; }

    [Column("cod_cta")]
    [StringLength(255)]
    public string? CodCta { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC350s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
