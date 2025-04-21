using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1110")]
[Index("CodPart", Name = "idx_cod_part")]
[Index("Unid", Name = "idx_unid")]
public partial class Reg1110
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

    [Column("cod_part")]
    [StringLength(60)]
    public string? CodPart { get; set; }

    [Column("cod_mod")]
    [StringLength(2)]
    public string? CodMod { get; set; }

    [Column("ser")]
    [StringLength(4)]
    public string? Ser { get; set; }

    [Column("num_doc")]
    [StringLength(9)]
    public string? NumDoc { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("chv_nfe")]
    [StringLength(44)]
    public string? ChvNfe { get; set; }

    [Column("nr_memo")]
    [StringLength(255)]
    public string? NrMemo { get; set; }

    [Column("qtd")]
    [Precision(22, 3)]
    public decimal? Qtd { get; set; }

    [Column("unid")]
    [StringLength(6)]
    public string? Unid { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1110s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
