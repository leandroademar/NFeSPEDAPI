using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b440")]
public partial class RegB440
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

    [Column("ind_oper")]
    [StringLength(1)]
    public string? IndOper { get; set; }

    [Column("cod_part")]
    [StringLength(60)]
    public string? CodPart { get; set; }

    [Column("vl_cont_rt")]
    [Precision(21, 2)]
    public decimal? VlContRt { get; set; }

    [Column("vl_bc_iss_rt")]
    [Precision(21, 2)]
    public decimal? VlBcIssRt { get; set; }

    [Column("vl_iss_rt")]
    [Precision(21, 2)]
    public decimal? VlIssRt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB440s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
