using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_9;

/// <summary>
/// Abertura do Bloco 9
/// </summary>
public class Registro9001 : Registro
{
    public Registro9001() : base("9001")
    {
    }

    public Registro9001(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        {
            var withBlock = writer;
            withBlock.Append("|9001|"); // texto fixo
            writer.Append(((int)IndicadorMovimento).ToString() + "|"); // 3
        }

        string result = writer.ToString();
        writer = null;
        return result;
    }

    public override void LeParametros(string[] data)
    {
        IndicadorMovimento = (EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento)data[2].ToEnum<EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento>(EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados);
    }

    /// <summary>
    /// Indicador de Movimento no Bloco 9
    /// </summary>
    public EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento IndicadorMovimento { get; set; } = EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados;
}
