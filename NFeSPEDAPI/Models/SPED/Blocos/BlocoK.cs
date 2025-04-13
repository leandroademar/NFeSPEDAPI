using EficazFramework.SPED.Schemas.Primitives;
using NFeSPEDAPI.Models.SPED.Blocos.Bloco_K;

namespace NFeSPEDAPI.Models.SPED.Blocos;

/// <summary>
/// Controle da Produção e do Estoque
/// </summary>
/// <exclude />
public class BlocoK : Bloco
{
    public RegistroK001 Registrok001
    {
        get
        {
            return (RegistroK001)Registros.Where(r => r.Codigo == "K001").FirstOrDefault();
        }
    }

    public List<Registrok230> RegistrosK230
    {
        get
        {
            return Registros.Where(r => r.Codigo == "K230").Cast<Registrok230>().ToList();
        }
    }

    public List<RegistroK235> RegistrosK235
    {
        get
        {
            return Registros.Where(r => r.Codigo == "K235").Cast<RegistroK235>().ToList();
        }
    }
}
