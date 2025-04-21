using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c179")]
public partial class RegC179
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

    [Column("bc_st_orig_dest")]
    [Precision(21, 2)]
    public decimal? BcStOrigDest { get; set; }

    [Column("icms_st_rep")]
    [Precision(21, 2)]
    public decimal? IcmsStRep { get; set; }

    [Column("icms_st_compl")]
    [Precision(21, 2)]
    public decimal? IcmsStCompl { get; set; }

    [Column("bc_ret")]
    [Precision(21, 2)]
    public decimal? BcRet { get; set; }

    [Column("icms_ret")]
    [Precision(21, 2)]
    public decimal? IcmsRet { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC179s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
