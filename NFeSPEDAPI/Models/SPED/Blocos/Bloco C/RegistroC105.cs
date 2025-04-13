using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.EFD_ICMS_IPI;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_C;

/// <summary>
/// REGISTRO C105: OPERAÇÕES COM ICMS ST RECOLHIDO PARA UF DIVERSA
/// DO DESTINATÁRIO DO DOCUMENTO FISCAL (CÓDIGO 55).
/// </summary>
/// <remarks></remarks>
public class RegistroC105 : Registro
{
    public RegistroC105() : base("C105")
    {
    }

    public RegistroC105(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|C105|"); // 1
        writer.Append((int)Operacao + "|"); // 2
        writer.Append(SiglaUFdestino_IcmsST + "|"); // 3
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        Operacao = (IndicadorTipoOperacao)data[2].ToEnum<IndicadorTipoOperacao>(IndicadorTipoOperacao.CombustiveleLubrificantes);
        SiglaUFdestino_IcmsST = data[3];
    }

    public IndicadorTipoOperacao Operacao { get; set; } = IndicadorTipoOperacao.CombustiveleLubrificantes; // 2
    public string SiglaUFdestino_IcmsST { get; set; } = null; // 3
}
