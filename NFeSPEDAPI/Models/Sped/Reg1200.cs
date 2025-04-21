using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1200")]
public partial class Reg1200
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

    [Column("cod_aj_apur")]
    [StringLength(8)]
    public string? CodAjApur { get; set; }

    [Column("sld_cred")]
    [Precision(21, 2)]
    public decimal? SldCred { get; set; }

    [Column("cred_apr")]
    [Precision(21, 2)]
    public decimal? CredApr { get; set; }

    [Column("cred_receb")]
    [Precision(21, 2)]
    public decimal? CredReceb { get; set; }

    [Column("cred_util")]
    [Precision(21, 2)]
    public decimal? CredUtil { get; set; }

    [Column("sld_cred_fim")]
    [Precision(21, 2)]
    public decimal? SldCredFim { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1200s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
