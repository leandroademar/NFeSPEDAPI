using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_1920")]
public partial class Reg1920
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

    [Column("vl_tot_transf_debitos_oa")]
    [Precision(21, 2)]
    public decimal? VlTotTransfDebitosOa { get; set; }

    [Column("vl_tot_aj_debitos_oa")]
    [Precision(21, 2)]
    public decimal? VlTotAjDebitosOa { get; set; }

    [Column("vl_estornos_cred_oa")]
    [Precision(21, 2)]
    public decimal? VlEstornosCredOa { get; set; }

    [Column("vl_tot_transf_creditos_oa")]
    [Precision(21, 2)]
    public decimal? VlTotTransfCreditosOa { get; set; }

    [Column("vl_tot_aj_creditos_oa")]
    [Precision(21, 2)]
    public decimal? VlTotAjCreditosOa { get; set; }

    [Column("vl_estornos_deb_oa")]
    [Precision(21, 2)]
    public decimal? VlEstornosDebOa { get; set; }

    [Column("vl_sld_credor_ant_oa")]
    [Precision(21, 2)]
    public decimal? VlSldCredorAntOa { get; set; }

    [Column("vl_sld_apurado_oa")]
    [Precision(21, 2)]
    public decimal? VlSldApuradoOa { get; set; }

    [Column("vl_tot_ded")]
    [Precision(21, 2)]
    public decimal? VlTotDed { get; set; }

    [Column("vl_icms_recolher_oa")]
    [Precision(21, 2)]
    public decimal? VlIcmsRecolherOa { get; set; }

    [Column("vl_sld_credor_transp_oa")]
    [Precision(21, 2)]
    public decimal? VlSldCredorTranspOa { get; set; }

    [Column("deb_esp_oa")]
    [Precision(21, 2)]
    public decimal? DebEspOa { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("Reg1920s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
