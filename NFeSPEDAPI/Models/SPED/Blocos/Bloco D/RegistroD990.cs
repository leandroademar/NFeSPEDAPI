﻿using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_D;

/// <summary>
/// Encerramento do Bloco D
/// </summary>
/// <remarks></remarks>
public class RegistroD990 : Registro
{
    public RegistroD990() : base("D990")
    {
    }

    public RegistroD990(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|D990|"); // 1
        writer.Append(QuantidadeLinhas + "|"); // 2
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        QuantidadeLinhas = data[2].ToNullableInteger();
    }

    public int? QuantidadeLinhas { get; set; }
}
