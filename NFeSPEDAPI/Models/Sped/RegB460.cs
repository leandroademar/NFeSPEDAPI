using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b460")]
public partial class RegB460
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

    [Column("ind_ded")]
    [StringLength(1)]
    public string? IndDed { get; set; }

    [Column("vl_ded")]
    [Precision(21, 2)]
    public decimal? VlDed { get; set; }

    [Column("num_proc")]
    [StringLength(255)]
    public string? NumProc { get; set; }

    [Column("ind_proc")]
    [StringLength(1)]
    public string? IndProc { get; set; }

    [Column("proc")]
    [StringLength(255)]
    public string? Proc { get; set; }

    [Column("cod_inf_obs")]
    [StringLength(6)]
    public string? CodInfObs { get; set; }

    [Column("ind_obr")]
    [StringLength(1)]
    public string? IndObr { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB460s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
