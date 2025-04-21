using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c800")]
public partial class RegC800
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

    [Column("cod_sit")]
    [StringLength(2)]
    public string? CodSit { get; set; }

    [Column("num_cfe")]
    [StringLength(6)]
    public string? NumCfe { get; set; }

    [Column("dt_doc")]
    public DateOnly? DtDoc { get; set; }

    [Column("vl_cfe")]
    [Precision(21, 2)]
    public decimal? VlCfe { get; set; }

    [Column("vl_pis")]
    [Precision(21, 2)]
    public decimal? VlPis { get; set; }

    [Column("vl_cofins")]
    [Precision(21, 2)]
    public decimal? VlCofins { get; set; }

    [Column("cnpj_cpf")]
    [StringLength(14)]
    public string? CnpjCpf { get; set; }

    [Column("nr_sat")]
    [StringLength(9)]
    public string? NrSat { get; set; }

    [Column("chv_cfe")]
    [StringLength(44)]
    public string? ChvCfe { get; set; }

    [Column("vl_desc")]
    [Precision(21, 2)]
    public decimal? VlDesc { get; set; }

    [Column("vl_merc")]
    [Precision(21, 2)]
    public decimal? VlMerc { get; set; }

    [Column("vl_out_da")]
    [Precision(21, 2)]
    public decimal? VlOutDa { get; set; }

    [Column("vl_icms")]
    [Precision(21, 2)]
    public decimal? VlIcms { get; set; }

    [Column("vl_pis_st")]
    [Precision(21, 2)]
    public decimal? VlPisSt { get; set; }

    [Column("vl_cofins_st")]
    [Precision(21, 2)]
    public decimal? VlCofinsSt { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC800s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
