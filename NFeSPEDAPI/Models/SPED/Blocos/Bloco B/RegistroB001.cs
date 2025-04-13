using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_B;

/// <summary>
/// Abertura do Bloco B
/// </summary>
/// <remarks></remarks>
public class RegistroB001 : Registro
{
    public RegistroB001() : base("B001")
    {
    }

    public RegistroB001(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|B001|"); // 1
        writer.Append(((int)IndicadorMovimento).ToString() + "|"); // 3
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        IndicadorMovimento = (EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento)data[2].ToEnum<EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento>(EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados);
    }

    public EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento IndicadorMovimento { get; set; } = EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados;
}
