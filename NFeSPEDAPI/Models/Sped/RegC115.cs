using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NFeSPEDAPI.Models.Sped;

[PrimaryKey("Id", "IdEsct")]
[Table("reg_c115")]
public partial class RegC115
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

    [Column("ind_carga")]
    [StringLength(1)]
    public string? IndCarga { get; set; }

    [Column("cnpj_col")]
    [StringLength(14)]
    public string? CnpjCol { get; set; }

    [Column("ie_col")]
    [StringLength(14)]
    public string? IeCol { get; set; }

    [Column("cpf_col")]
    [StringLength(11)]
    public string? CpfCol { get; set; }

    [Column("cod_mun_col")]
    [StringLength(7)]
    public string? CodMunCol { get; set; }

    [Column("cnpj_entg")]
    [StringLength(14)]
    public string? CnpjEntg { get; set; }

    [Column("ie_entg")]
    [StringLength(14)]
    public string? IeEntg { get; set; }

    [Column("cpf_entg")]
    [StringLength(11)]
    public string? CpfEntg { get; set; }

    [Column("cod_mun_entg")]
    [StringLength(7)]
    public string? CodMunEntg { get; set; }

    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [ForeignKey("IdEsct")]
    [InverseProperty("RegC115s")]
    public virtual Escrituracaofiscal IdEsctNavigation { get; set; } = null!;
}
