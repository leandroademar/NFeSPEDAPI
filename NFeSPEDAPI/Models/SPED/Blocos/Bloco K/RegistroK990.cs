using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_K;

/// <summary>
/// Encerramento do Bloco K
/// </summary>
/// <remarks></remarks>
public class RegistroK990 : Registro
{
    public RegistroK990() : base("K990")
    {
    }

    public RegistroK990(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|K990|"); // 1
        writer.Append(QuantidadeLinhas + "|"); // 2
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        QuantidadeLinhas = data[2].ToNullableInteger();
    }

    public int? QuantidadeLinhas { get; set; }
}
