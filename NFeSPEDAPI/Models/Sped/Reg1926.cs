using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1926")]
public partial class Reg1926
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

    [Column("cod_or")]
    [StringLength(3)]
    public string? CodOr { get; set; }

    [Column("vl_or")]
    [Precision(21, 2)]
    public decimal? VlOr { get; set; }

    [Column("dt_vcto")]
    public DateOnly? DtVcto { get; set; }

    [Column("cod_rec")]
    [StringLength(255)]
    public string? CodRec { get; set; }

    [Column("num_proc")]
    [StringLength(60)]
    public string? NumProc { get; set; }

    [Column("ind_proc")]
    [StringLength(1)]
    public string? IndProc { get; set; }

    [Column("proc")]
    [StringLength(255)]
    public string? Proc { get; set; }

    [Column("txt_compl")]
    [StringLength(255)]
    public string? TxtCompl { get; set; }

    [Column("mes_ref")]
    [StringLength(6)]
    public string? MesRef { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1926s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
