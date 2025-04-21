using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_b510")]
public partial class RegB510
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

    [Column("ind_prof")]
    [StringLength(1)]
    public string? IndProf { get; set; }

    [Column("ind_esc")]
    [StringLength(1)]
    public string? IndEsc { get; set; }

    [Column("ind_soc")]
    [StringLength(1)]
    public string? IndSoc { get; set; }

    [Column("cpf")]
    [StringLength(11)]
    public string? Cpf { get; set; }

    [Column("nome")]
    [StringLength(100)]
    public string? Nome { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegB510s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
