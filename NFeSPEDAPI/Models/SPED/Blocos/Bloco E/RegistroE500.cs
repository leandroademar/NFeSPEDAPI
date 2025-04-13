using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.EFD_ICMS_IPI;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_E;

/// <summary>
/// Período de Apuração do IPI
/// </summary>
/// <remarks></remarks>
public class RegistroE500 : Registro
{
    public RegistroE500() : base("E500")
    {
    }

    public RegistroE500(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|E500|"); // 1
        writer.Append(((int)IndicadorPeriodo).ToString() + "|"); // 2
        writer.Append(DataInicial.ToSpedString() + "|"); // 3
        writer.Append(DataFinal.ToSpedString() + "|"); // 4
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        IndicadorPeriodo = (IndicadorPeriodoIPI)data[2].ToEnum<IndicadorPeriodoIPI>(IndicadorPeriodoIPI.Mensal);
        DataInicial = data[3].ToDate(); // 3
        DataFinal = data[4].ToDate(); //4
    }

    public IndicadorPeriodoIPI IndicadorPeriodo { get; set; } = IndicadorPeriodoIPI.Mensal; //2
    public DateTime? DataInicial { get; set; } = default; // 3
    public DateTime? DataFinal { get; set; } = default; // 4 

    // Registros Filhos
    //public RegistroE510 RegistroE510 { get; set; } = null;
}
