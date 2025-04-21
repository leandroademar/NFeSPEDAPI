using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1921")]
public partial class Reg1921
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

    [Column("descr_compl_aj")]
    [StringLength(255)]
    public string? DescrComplAj { get; set; }

    [Column("vl_aj_apur")]
    [Precision(21, 2)]
    public decimal? VlAjApur { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1921s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
