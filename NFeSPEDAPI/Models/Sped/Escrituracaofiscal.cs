using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFeSPEDAPI.Models.Sped;

[Table("escrituracaofiscal")]
public partial class Escrituracaofiscal
{
    [Key]
    [Column("id_esct")]
    public long IdEsct { get; set; }

    [Column("hash")]
    public long Hash { get; set; }

    [Column("cpf_cnpj")]
    [StringLength(14)]
    public string CpfCnpj { get; set; } = null!;

    [Column("nome_contribuinte")]
    [StringLength(255)]
    public string NomeContribuinte { get; set; } = null!;

    [Column("ie")]
    [StringLength(14)]
    public string Ie { get; set; } = null!;

    [Column("finalidade")]
    public int Finalidade { get; set; }

    [Column("estado")]
    public int Estado { get; set; }

    [Column("datainicial")]
    public DateOnly Datainicial { get; set; }

    [Column("datafinal")]
    public DateOnly Datafinal { get; set; }

    [Column("perfil")]
    public int Perfil { get; set; }

    [Column("nomebd")]
    [StringLength(255)]
    public string Nomebd { get; set; } = null!;

    [Column("localizacaoarquivo")]
    public string? Localizacaoarquivo { get; set; }

    [Column("hasharquivo")]
    [StringLength(40)]
    public string? Hasharquivo { get; set; }

    [Column("hasharquivodisco")]
    [StringLength(40)]
    public string? Hasharquivodisco { get; set; }

    [Column("hashrecibo")]
    [StringLength(40)]
    public string? Hashrecibo { get; set; }

    [Column("uf")]
    [StringLength(2)]
    public string Uf { get; set; } = null!;

    [Column("codigo_municipio")]
    [StringLength(7)]
    public string? CodigoMunicipio { get; set; }

    [Column("metadadosvalidacao")]
    public string? Metadadosvalidacao { get; set; }

    [Column("ato_cotepe")]
    public int AtoCotepe { get; set; }

    [Column("id_descritor_validacao")]
    public int? IdDescritorValidacao { get; set; }

    [Column("versao_descritor_validacao")]
    public int? VersaoDescritorValidacao { get; set; }

    [Column("tamanhosemassinatura")]
    public long? Tamanhosemassinatura { get; set; }

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0001> Reg0001s { get; set; } = new List<Reg0001>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0002> Reg0002s { get; set; } = new List<Reg0002>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0005> Reg0005s { get; set; } = new List<Reg0005>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0015> Reg0015s { get; set; } = new List<Reg0015>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0100> Reg0100s { get; set; } = new List<Reg0100>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0150> Reg0150s { get; set; } = new List<Reg0150>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0175> Reg0175s { get; set; } = new List<Reg0175>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0190> Reg0190s { get; set; } = new List<Reg0190>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0200> Reg0200s { get; set; } = new List<Reg0200>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0205> Reg0205s { get; set; } = new List<Reg0205>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0206> Reg0206s { get; set; } = new List<Reg0206>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0220> Reg0220s { get; set; } = new List<Reg0220>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0221> Reg0221s { get; set; } = new List<Reg0221>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0300> Reg0300s { get; set; } = new List<Reg0300>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0305> Reg0305s { get; set; } = new List<Reg0305>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0400> Reg0400s { get; set; } = new List<Reg0400>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0450> Reg0450s { get; set; } = new List<Reg0450>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0460> Reg0460s { get; set; } = new List<Reg0460>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0500> Reg0500s { get; set; } = new List<Reg0500>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0600> Reg0600s { get; set; } = new List<Reg0600>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg0990> Reg0990s { get; set; } = new List<Reg0990>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1001> Reg1001s { get; set; } = new List<Reg1001>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1010> Reg1010s { get; set; } = new List<Reg1010>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1100> Reg1100s { get; set; } = new List<Reg1100>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1105> Reg1105s { get; set; } = new List<Reg1105>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1110> Reg1110s { get; set; } = new List<Reg1110>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1200> Reg1200s { get; set; } = new List<Reg1200>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1210> Reg1210s { get; set; } = new List<Reg1210>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1250> Reg1250s { get; set; } = new List<Reg1250>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1255> Reg1255s { get; set; } = new List<Reg1255>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1300> Reg1300s { get; set; } = new List<Reg1300>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1310> Reg1310s { get; set; } = new List<Reg1310>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1320> Reg1320s { get; set; } = new List<Reg1320>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1350> Reg1350s { get; set; } = new List<Reg1350>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1360> Reg1360s { get; set; } = new List<Reg1360>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1370> Reg1370s { get; set; } = new List<Reg1370>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1390> Reg1390s { get; set; } = new List<Reg1390>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1391> Reg1391s { get; set; } = new List<Reg1391>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1400> Reg1400s { get; set; } = new List<Reg1400>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1500> Reg1500s { get; set; } = new List<Reg1500>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1510> Reg1510s { get; set; } = new List<Reg1510>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1601> Reg1601s { get; set; } = new List<Reg1601>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1700> Reg1700s { get; set; } = new List<Reg1700>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1710> Reg1710s { get; set; } = new List<Reg1710>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1800> Reg1800s { get; set; } = new List<Reg1800>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1900> Reg1900s { get; set; } = new List<Reg1900>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1910> Reg1910s { get; set; } = new List<Reg1910>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1920> Reg1920s { get; set; } = new List<Reg1920>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1921> Reg1921s { get; set; } = new List<Reg1921>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1922> Reg1922s { get; set; } = new List<Reg1922>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1923> Reg1923s { get; set; } = new List<Reg1923>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1925> Reg1925s { get; set; } = new List<Reg1925>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1926> Reg1926s { get; set; } = new List<Reg1926>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1960> Reg1960s { get; set; } = new List<Reg1960>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1970> Reg1970s { get; set; } = new List<Reg1970>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1975> Reg1975s { get; set; } = new List<Reg1975>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1980> Reg1980s { get; set; } = new List<Reg1980>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg1990> Reg1990s { get; set; } = new List<Reg1990>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg9001> Reg9001s { get; set; } = new List<Reg9001>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg9900> Reg9900s { get; set; } = new List<Reg9900>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg9990> Reg9990s { get; set; } = new List<Reg9990>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<Reg9999> Reg9999s { get; set; } = new List<Reg9999>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB001> RegB001s { get; set; } = new List<RegB001>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB020> RegB020s { get; set; } = new List<RegB020>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB025> RegB025s { get; set; } = new List<RegB025>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB030> RegB030s { get; set; } = new List<RegB030>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB035> RegB035s { get; set; } = new List<RegB035>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB350> RegB350s { get; set; } = new List<RegB350>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB420> RegB420s { get; set; } = new List<RegB420>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB440> RegB440s { get; set; } = new List<RegB440>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB460> RegB460s { get; set; } = new List<RegB460>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB470> RegB470s { get; set; } = new List<RegB470>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB500> RegB500s { get; set; } = new List<RegB500>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB510> RegB510s { get; set; } = new List<RegB510>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegB990> RegB990s { get; set; } = new List<RegB990>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC001> RegC001s { get; set; } = new List<RegC001>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC100> RegC100s { get; set; } = new List<RegC100>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC101> RegC101s { get; set; } = new List<RegC101>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC105> RegC105s { get; set; } = new List<RegC105>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC110> RegC110s { get; set; } = new List<RegC110>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC111> RegC111s { get; set; } = new List<RegC111>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC112> RegC112s { get; set; } = new List<RegC112>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC113> RegC113s { get; set; } = new List<RegC113>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC114> RegC114s { get; set; } = new List<RegC114>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC115> RegC115s { get; set; } = new List<RegC115>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC116> RegC116s { get; set; } = new List<RegC116>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC120> RegC120s { get; set; } = new List<RegC120>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC130> RegC130s { get; set; } = new List<RegC130>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC140> RegC140s { get; set; } = new List<RegC140>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC141> RegC141s { get; set; } = new List<RegC141>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC160> RegC160s { get; set; } = new List<RegC160>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC165> RegC165s { get; set; } = new List<RegC165>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC170> RegC170s { get; set; } = new List<RegC170>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC171> RegC171s { get; set; } = new List<RegC171>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC172> RegC172s { get; set; } = new List<RegC172>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC173> RegC173s { get; set; } = new List<RegC173>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC174> RegC174s { get; set; } = new List<RegC174>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC175> RegC175s { get; set; } = new List<RegC175>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC176> RegC176s { get; set; } = new List<RegC176>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC177> RegC177s { get; set; } = new List<RegC177>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC178> RegC178s { get; set; } = new List<RegC178>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC179> RegC179s { get; set; } = new List<RegC179>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC180> RegC180s { get; set; } = new List<RegC180>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC181> RegC181s { get; set; } = new List<RegC181>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC185> RegC185s { get; set; } = new List<RegC185>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC186> RegC186s { get; set; } = new List<RegC186>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC190> RegC190s { get; set; } = new List<RegC190>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC191> RegC191s { get; set; } = new List<RegC191>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC195> RegC195s { get; set; } = new List<RegC195>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC197> RegC197s { get; set; } = new List<RegC197>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC300> RegC300s { get; set; } = new List<RegC300>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC310> RegC310s { get; set; } = new List<RegC310>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC320> RegC320s { get; set; } = new List<RegC320>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC321> RegC321s { get; set; } = new List<RegC321>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC330> RegC330s { get; set; } = new List<RegC330>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC350> RegC350s { get; set; } = new List<RegC350>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC370> RegC370s { get; set; } = new List<RegC370>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC380> RegC380s { get; set; } = new List<RegC380>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC390> RegC390s { get; set; } = new List<RegC390>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC400> RegC400s { get; set; } = new List<RegC400>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC405> RegC405s { get; set; } = new List<RegC405>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC410> RegC410s { get; set; } = new List<RegC410>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC420> RegC420s { get; set; } = new List<RegC420>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC425> RegC425s { get; set; } = new List<RegC425>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC430> RegC430s { get; set; } = new List<RegC430>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC460> RegC460s { get; set; } = new List<RegC460>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC465> RegC465s { get; set; } = new List<RegC465>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC470> RegC470s { get; set; } = new List<RegC470>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC480> RegC480s { get; set; } = new List<RegC480>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC490> RegC490s { get; set; } = new List<RegC490>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC500> RegC500s { get; set; } = new List<RegC500>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC510> RegC510s { get; set; } = new List<RegC510>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC590> RegC590s { get; set; } = new List<RegC590>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC591> RegC591s { get; set; } = new List<RegC591>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC595> RegC595s { get; set; } = new List<RegC595>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC597> RegC597s { get; set; } = new List<RegC597>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC600> RegC600s { get; set; } = new List<RegC600>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC601> RegC601s { get; set; } = new List<RegC601>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC610> RegC610s { get; set; } = new List<RegC610>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC690> RegC690s { get; set; } = new List<RegC690>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC695> RegC695s { get; set; } = new List<RegC695>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC790> RegC790s { get; set; } = new List<RegC790>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC791> RegC791s { get; set; } = new List<RegC791>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC800> RegC800s { get; set; } = new List<RegC800>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC810> RegC810s { get; set; } = new List<RegC810>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC815> RegC815s { get; set; } = new List<RegC815>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC850> RegC850s { get; set; } = new List<RegC850>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC855> RegC855s { get; set; } = new List<RegC855>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC857> RegC857s { get; set; } = new List<RegC857>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC860> RegC860s { get; set; } = new List<RegC860>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC870> RegC870s { get; set; } = new List<RegC870>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC880> RegC880s { get; set; } = new List<RegC880>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC890> RegC890s { get; set; } = new List<RegC890>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC895> RegC895s { get; set; } = new List<RegC895>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegC897> RegC897s { get; set; } = new List<RegC897>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegD001> RegD001s { get; set; } = new List<RegD001>();

    [InverseProperty("IdEsctNavigation")]
    public virtual ICollection<RegD100> RegD100s { get; set; } = new List<RegD100>();
}
