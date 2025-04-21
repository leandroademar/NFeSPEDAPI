using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c112")]
public partial class RegC112
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

    [Column("cod_da")]
    [StringLength(1)]
    public string? CodDa { get; set; }

    [Column("uf")]
    [StringLength(2)]
    public string? Uf { get; set; }

    [Column("num_da")]
    [StringLength(255)]
    public string? NumDa { get; set; }

    [Column("cod_aut")]
    [StringLength(255)]
    public string? CodAut { get; set; }

    [Column("vl_da")]
    [Precision(21, 2)]
    public decimal? VlDa { get; set; }

    [Column("dt_vcto")]
    public DateOnly? DtVcto { get; set; }

    [Column("dt_pgto")]
    public DateOnly? DtPgto { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC112s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
