using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_0015")]
[Index("UfSt", Name = "idx_chave_duplicidade")]
public partial class Reg0015
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

    [Column("uf_st")]
    [StringLength(2)]
    public string? UfSt { get; set; }

    [Column("ie_st")]
    [StringLength(14)]
    public string? IeSt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg0015s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
