using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1010")]
public partial class Reg1010
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

    [Column("ind_exp")]
    [StringLength(1)]
    public string? IndExp { get; set; }

    [Column("ind_ccrf")]
    [StringLength(1)]
    public string? IndCcrf { get; set; }

    [Column("ind_comb")]
    [StringLength(1)]
    public string? IndComb { get; set; }

    [Column("ind_usina")]
    [StringLength(1)]
    public string? IndUsina { get; set; }

    [Column("ind_va")]
    [StringLength(1)]
    public string? IndVa { get; set; }

    [Column("ind_ee")]
    [StringLength(1)]
    public string? IndEe { get; set; }

    [Column("ind_cart")]
    [StringLength(1)]
    public string? IndCart { get; set; }

    [Column("ind_form")]
    [StringLength(1)]
    public string? IndForm { get; set; }

    [Column("ind_aer")]
    [StringLength(1)]
    public string? IndAer { get; set; }

    [Column("ind_giaf1")]
    [StringLength(1)]
    public string? IndGiaf1 { get; set; }

    [Column("ind_giaf3")]
    [StringLength(1)]
    public string? IndGiaf3 { get; set; }

    [Column("ind_giaf4")]
    [StringLength(1)]
    public string? IndGiaf4 { get; set; }

    [Column("ind_rest_ressarc_compl_icms")]
    [StringLength(1)]
    public string? IndRestRessarcComplIcms { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1010s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
