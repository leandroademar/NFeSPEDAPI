﻿using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_D;

/// <summary>
/// Outras obrigações Tributárias, Ajustes e Infos. de Valores
/// Provenientes de Documento Fiscal
/// </summary>
/// <remarks></remarks>
public class RegistroD195 : Registro
{
    public RegistroD195() : base("D195")
    {
    }

    public RegistroD195(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|D195|"); // 1
        writer.Append(CodigoObs0460 + "|"); // 02
        writer.Append(Descricao + "|"); // 03
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        CodigoObs0460 = data[2];
        Descricao = data[3];
    }

    public string CodigoObs0460 { get; set; } = null; // 02
    public string Descricao { get; set; } = null; // 03

    // // Navigation Properties

    public List<RegistroD197> RegistrosD197 { get; set; } = new List<RegistroD197>();
}
