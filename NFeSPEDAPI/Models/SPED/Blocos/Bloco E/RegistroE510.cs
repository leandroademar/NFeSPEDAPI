using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_E;

/// <summary>
/// Consolidação dos Valores do IPI
/// </summary>
/// <remarks></remarks>
public class RegistroE510 : Registro
{
    public RegistroE510() : base("E510")
    {
    }

    public RegistroE510(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|E510|"); // 1
        writer.Append(CFOP + "|"); // 2
        writer.Append($"{(int)CST:00}" + "|"); // 3
        writer.Append(string.Format("{0:0.##}", ValorContabil) + "|"); // 4
        writer.Append(string.Format("{0:0.##}", BaseDeCalculo) + "|"); // 5
        writer.Append(string.Format("{0:0.##}", ValorIpi) + "|"); // 6
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        CFOP = data[2];
        CST = (EficazFramework.SPED.Schemas.NFe.CST_IPI)data[3].ToEnum<EficazFramework.SPED.Schemas.NFe.CST_IPI>(EficazFramework.SPED.Schemas.NFe.CST_IPI.OutrasSaidas);
        ValorContabil = data[4].ToNullableDouble();
        BaseDeCalculo = data[5].ToNullableDouble();
        ValorIpi = data[6].ToNullableDouble();
    }

    public string CFOP { get; set; } = default; // 2
    public EficazFramework.SPED.Schemas.NFe.CST_IPI CST { get; set; } = EficazFramework.SPED.Schemas.NFe.CST_IPI.OutrasSaidas; // 3
    public double? ValorContabil { get; set; } = default; // 4
    public double? BaseDeCalculo { get; set; } = default; // 5
    public double? ValorIpi { get; set; } = default; // 6
}
