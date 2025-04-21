using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c600")]
public partial class RegC600
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

    [Column("cod_mod")]
    [StringLength(2)]
    public string? CodMod { get; set; }

    [Column("cod_mun")]
    [StringLength(7)]
    public string? CodMun { get; set; }

    [Column("ser")]
    [StringLength(4)]
    public string? Ser { get; set; }

    [Column("sub")]
    [StringLength(3)]
    public string? Sub { get; set; }

    [Column("cod_cons")]
    [StringLength(2)]
    public string? CodCons { get; set; }

    [Column("qtd_cons")]
    [StringLength(255)]
    public string? QtdCons { get; set; }

    [Column("vl_doc")]
    [Precision(21, 2)]
    public decimal? VlDoc { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Column("vl_serv")]
    [Precision(21, 2)]
    public decimal? VlServ { get; set; }

    [Column("vl_serv_nt")]
    [Precision(21, 2)]
    public decimal? VlServNt { get; set; }

    [Column("vl_terc")]
    [Precision(21, 2)]
    public decimal? VlTerc { get; set; }

    [Column("vl_da")]
    [Precision(21, 2)]
    public decimal? VlDa { get; set; }

    [Column("vl_bc_icms")]
    [Precision(21, 2)]
    public decimal? VlBcIcms { get; set; }

    [Column("vl_icms")]
    [Precision(21, 2)]
    public decimal? VlIcms { get; set; }

    [Column("vl_pis")]
    [Precision(21, 2)]
    public decimal? VlPis { get; set; }

    [Column("vl_cofins")]
    [Precision(21, 2)]
    public decimal? VlCofins { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC600s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
