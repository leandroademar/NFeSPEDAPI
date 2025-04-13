using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_D;

/// <summary>
/// Abertura do Bloco D
/// </summary>
/// <remarks></remarks>
public class RegistroD001 : Registro
{
    public RegistroD001() : base("D001")
    {
    }

    public RegistroD001(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|D001|"); // 1
        writer.Append(((int)IndicadorMovimento).ToString() + "|"); // 3
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        IndicadorMovimento = (EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento)data[2].ToEnum<EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento>(EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados);
    }

    public EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento IndicadorMovimento { get; set; } = EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados;
}
