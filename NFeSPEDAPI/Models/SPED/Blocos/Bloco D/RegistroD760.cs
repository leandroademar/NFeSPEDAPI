using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_D;

/// <summary>
/// Registro analítico da escrituração consolidada da Nota Fiscal  
/// Fatura Eletrônica de Serviços de Comunicação – NFCom (Código 62)
/// </summary>
/// <remarks></remarks>
public class RegistroD760 : Registro
{
    public RegistroD760() : base("D760")
    {
    }

    public RegistroD760(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|D760|"); // 1
        writer.Append(((int)Origem).ToString() + string.Format("{0:00}", (int)CST_ICMS) + "|"); // 2
        writer.Append(CFOP + "|"); // 3
        writer.Append(string.Format("{0:0.##}", AliquotaICMS) + "|"); // 4
        writer.Append(string.Format("{0:0.##}", ValorOperacao) + "|"); // 5
        writer.Append(string.Format("{0:0.##}", ValorBaseCalculoICMS) + "|"); // 6
        writer.Append(string.Format("{0:0.##}", ValorICMS) + "|"); // 7
        writer.Append(string.Format("{0:0.##}", ValorReducaoBC) + "|"); // 8
        writer.Append(CodigoObservacao0460 + "|"); // 9
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        Origem = (EficazFramework.SPED.Schemas.NFe.OrigemMercadoria)data[2][..1].ToEnum<EficazFramework.SPED.Schemas.NFe.OrigemMercadoria>(EficazFramework.SPED.Schemas.NFe.OrigemMercadoria.Nacional);
        CST_ICMS = (EficazFramework.SPED.Schemas.NFe.CST_ICMS)data[2].Substring(1, 2).ToEnum<EficazFramework.SPED.Schemas.NFe.CST_ICMS>(EficazFramework.SPED.Schemas.NFe.CST_ICMS.CST_00);
        CFOP = data[3];
        AliquotaICMS = data[4].ToNullableDouble();
        ValorOperacao = data[5].ToNullableDouble();
        ValorBaseCalculoICMS = data[6].ToNullableDouble();
        ValorICMS = data[7].ToNullableDouble();
        ValorReducaoBC = data[8].ToNullableDouble();
        CodigoObservacao0460 = data[9];
    }

    public EficazFramework.SPED.Schemas.NFe.OrigemMercadoria Origem { get; set; } = EficazFramework.SPED.Schemas.NFe.OrigemMercadoria.Nacional; // 2
    public EficazFramework.SPED.Schemas.NFe.CST_ICMS CST_ICMS { get; set; } = EficazFramework.SPED.Schemas.NFe.CST_ICMS.CST_00; // 2
    public string CFOP { get; set; } = null; // 3
    public double? AliquotaICMS { get; set; } = default; // 4
    public double? ValorOperacao { get; set; } = default; // 5
    public double? ValorBaseCalculoICMS { get; set; } = default; // 6
    public double? ValorICMS { get; set; } = default; // 7
    public double? ValorReducaoBC { get; set; } = default; // 8
    public string CodigoObservacao0460 { get; set; } = null; // 9
}
