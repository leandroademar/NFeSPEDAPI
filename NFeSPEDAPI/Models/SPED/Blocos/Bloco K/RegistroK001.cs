// NOTA: Este registro nunca sofreu alteração desde o primeiro ano da escrituração.
// NOTA: Este registro nunca sofreu alteração desde o primeiro ano da escrituração.
// Não será preciso avaliar qual é a versão do arquivo para diferenciar a forma
// de escrita/leitura.

using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_K;

/// <summary>
/// Abertura do Bloco K
/// </summary>
/// <remarks></remarks>
public class RegistroK001 : Registro
{
    public RegistroK001() : base("K001")
    {
    }

    public RegistroK001(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|K001|"); // 1
        writer.Append(((int)IndicadorMovimento).ToString() + "|"); // 3
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        IndicadorMovimento = (EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento)data[2].ToEnum<EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento>(EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados);
    }

    public EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento IndicadorMovimento { get; set; } = EficazFramework.SPED.Schemas.Primitives.IndicadorMovimento.ComDados;
}
