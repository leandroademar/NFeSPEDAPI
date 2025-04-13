﻿using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.EFD_ICMS_IPI;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_E;

/// <summary>
/// Informações Adicionais do Ajuste da Apuração do ICMS Difal
/// </summary>
/// <remarks></remarks>
public class RegistroE312 : Registro
{
    public RegistroE312() : base("E312")
    {
    }

    public RegistroE312(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|E312|"); // 01
        writer.Append(NumeroDocArrecadacao + "|"); // 02
        writer.Append(NumeroProcessoRef + "|"); // 03
        writer.Append((int)OrigemProcessoRef + "|"); // 04
        writer.Append(DescricaoProcessoRef + "|"); // 05
        writer.Append(DescricaoComplementar + "|"); // 06
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        NumeroDocArrecadacao = data[2];
        NumeroProcessoRef = data[3];
        OrigemProcessoRef = (IndicadorOrigemProcesso)data[4].ToEnum<IndicadorOrigemProcesso>(IndicadorOrigemProcesso.Outros);
        DescricaoProcessoRef = data[5];
        DescricaoComplementar = data[6];
    }

    public string NumeroDocArrecadacao { get; set; } = null; // 02
    /// <summary>
    /// Número do Processo Referenciado. 15 dígitos
    /// </summary>
    public string NumeroProcessoRef { get; set; } = null; // 03
    public IndicadorOrigemProcesso OrigemProcessoRef { get; set; } = IndicadorOrigemProcesso.Outros; // 04
    public string DescricaoProcessoRef { get; set; } = null; // 05
    public string DescricaoComplementar { get; set; } = null; // 06
}
