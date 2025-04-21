using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c181")]
public partial class RegC181
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

    [Column("cod_mot_rest_compl")]
    [StringLength(5)]
    public string? CodMotRestCompl { get; set; }

    [Column("quant_conv")]
    [Precision(25, 6)]
    public decimal? QuantConv { get; set; }

    [Column("unid")]
    [StringLength(6)]
    public string? Unid { get; set; }

    [Column("cod_mod_saida")]
    [StringLength(2)]
    public string? CodModSaida { get; set; }

    [Column("serie_saida")]
    [StringLength(3)]
    public string? SerieSaida { get; set; }

    [Column("ecf_fab_saida")]
    [StringLength(21)]
    public string? EcfFabSaida { get; set; }

    [Column("num_doc_saida")]
    [StringLength(9)]
    public string? NumDocSaida { get; set; }

    [Column("chv_dfe_saida")]
    [StringLength(44)]
    public string? ChvDfeSaida { get; set; }

    [Column("dt_doc_saida")]
    public DateOnly? DtDocSaida { get; set; }

    [Column("num_item_saida")]
    [StringLength(3)]
    public string? NumItemSaida { get; set; }

    [Column("vl_unit_conv_saida")]
    [Precision(25, 6)]
    public decimal? VlUnitConvSaida { get; set; }

    [Column("vl_unit_icms_op_estoque_conv_saida")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsOpEstoqueConvSaida { get; set; }

    [Column("vl_unit_icms_st_estoque_conv_saida")]
    [Precision(25, 6)]
    public decimal? VlUnitIcmsStEstoqueConvSaida { get; set; }

    [Column("vl_unit_fcp_icms_st_estoque_conv_saida")]
    [Precision(25, 6)]
    public decimal? VlUnitFcpIcmsStEstoqueConvSaida { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC181s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
