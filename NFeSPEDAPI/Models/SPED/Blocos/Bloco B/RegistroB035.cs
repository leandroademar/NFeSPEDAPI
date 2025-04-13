﻿using EficazFramework.SPED.Extensions;
using EficazFramework.SPED.Schemas.Primitives;

namespace NFeSPEDAPI.Models.SPED.Blocos.Bloco_B;

/// <summary>
/// Abertura do Bloco B
/// </summary>
/// <remarks></remarks>

public class RegistroB035 : Registro
{
    public RegistroB035() : base("B035")
    {
    }

    public RegistroB035(string linha, string versao) : base(linha, versao)
    {
    }

    public override string EscreveLinha()
    {
        var writer = new System.Text.StringBuilder();
        writer.Append("|B035|"); // 1
        writer.Append(string.Format("{0:0.##}", ValorContabilParcela) + "|"); // 2
        writer.Append(string.Format("{0:0.##}", ValorBcISSParcela) + "|"); // 3
        writer.Append(string.Format("{0:0.##}", AliquotaISS) + "|"); // 4
        writer.Append(string.Format("{0:0.##}", ValorISSParcela) + "|"); // 5
        writer.Append(string.Format("{0:0.##}", ValorOpIsentasNtribISS) + "|"); // 6
        writer.Append(CodigoServico + "|"); // 7
        return writer.ToString();
    }

    public override void LeParametros(string[] data)
    {
        ValorContabilParcela = data[2].ToNullableDouble();
        ValorBcISSParcela = data[3].ToNullableDouble();
        AliquotaISS = data[4].ToNullableDouble();
        ValorISSParcela = data[5].ToNullableDouble();
        ValorOpIsentasNtribISS = data[6].ToNullableDouble();
        CodigoServico = data[7].ToString();
    }

    public double? ValorContabilParcela { get; set; } = default; // 2
    public double? ValorBcISSParcela { get; set; } = default; // 3
    public double? AliquotaISS { get; set; } = default; // 4
    public double? ValorISSParcela { get; set; } = default; // 5
    public double? ValorOpIsentasNtribISS { get; set; } = default; // 6
    public string CodigoServico { get; set; } = null; // 7
}
