using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c175")]
public partial class RegC175
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

    [Column("ind_veic_oper")]
    [StringLength(1)]
    public string? IndVeicOper { get; set; }

    [Column("cnpj")]
    [StringLength(14)]
    public string? Cnpj { get; set; }

    [Column("uf")]
    [StringLength(2)]
    public string? Uf { get; set; }

    [Column("chassi_veic")]
    [StringLength(17)]
    public string? ChassiVeic { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC175s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
