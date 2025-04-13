using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_I;

/// <summary>
/// Encerramento do Bloco 1
/// </summary>
/// <remarks></remarks>
public class Registro1990 : Registro
{
    public Registro1990() : base("1990")
    {
    }

    public Registro1990(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|1990|"); // 1
        writer.Append(QuantidadeLinhas + "|"); // 2
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        QuantidadeLinhas = data[2].ToNullableInteger();
    }

    public int? QuantidadeLinhas { get; set; }
}
