using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c130")]
public partial class RegC130
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

    [Column("vl_serv_nt")]
    [Precision(21, 2)]
    public decimal? VlServNt { get; set; }

    [Column("vl_bc_issqn")]
    [Precision(21, 2)]
    public decimal? VlBcIssqn { get; set; }

    [Column("vl_issqn")]
    [Precision(21, 2)]
    public decimal? VlIssqn { get; set; }

    [Column("vl_bc_irrf")]
    [Precision(21, 2)]
    public decimal? VlBcIrrf { get; set; }

    [Column("vl_irrf")]
    [Precision(21, 2)]
    public decimal? VlIrrf { get; set; }

    [Column("vl_bc_prev")]
    [Precision(21, 2)]
    public decimal? VlBcPrev { get; set; }

    [Column("vl_prev")]
    [Precision(21, 2)]
    public decimal? VlPrev { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC130s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
