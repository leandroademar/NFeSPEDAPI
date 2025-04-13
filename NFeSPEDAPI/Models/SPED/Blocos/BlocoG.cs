using EficazFramework.SPED.Schemas.Primitives;
using NFeSPEDAPI.Models.SPED.Blocos.Bloco_G;

namespace NFeSPEDAPI.Models.SPED.Blocos;

/// <summary>
/// Controle do Crédito de ICMS do Ativo Permanente - CIAP
/// </summary>
/// <exclude />
public class BlocoG : Bloco
{

    // Public ReadOnly Property RegistroC000() As Registro0000
    // Get
    // Return Me.Registros.Where(Function(r) r.Codigo = "C000").FirstOrDefault
    // End Get
    // End Property

    public RegistroG110 RegistroG110
    {
        get
        {
            return (RegistroG110)Registros.Where(r => r.Codigo == "G110").FirstOrDefault();
        }
    }

    public IEnumerable<RegistroG125> RegistrosG125
    {
        get
        {
            return Registros.Where(r => r.Codigo == "G125").Cast<RegistroG125>().ToList();
        }
    }

    public IEnumerable<RegistroG130> RegistrosG130
    {
        get
        {
            return Registros.Where(r => r.Codigo == "G130").Cast<RegistroG130>().ToList();
        }
    }
}
