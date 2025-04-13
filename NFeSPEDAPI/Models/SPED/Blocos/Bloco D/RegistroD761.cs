﻿using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_D;

/// <summary>
/// Informações do fundo de combate à pobreza – FCP – (Código 62)
/// </summary>
/// <remarks></remarks>
public class RegistroD761 : Registro
{
    public RegistroD761() : base("D761")
    {
    }

    public RegistroD761(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|D761|"); // 1
        writer.Append(string.Format("{0:0.##}", ValorFCP) + "|"); // 02
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        ValorFCP = data[2].ToNullableDouble();
    }

    public double? ValorFCP { get; set; } = default; // 02
}
