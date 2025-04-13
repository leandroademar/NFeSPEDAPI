using EficazFramework.SPED.Schemas.Primitives;
using NFeSPEDAPI.Models.SPED.Blocos.Bloco_B;

namespace NFeSPEDAPI.Models.SPED.Blocos;

/// <summary>
/// </summary>
/// <exclude />
public class BlocoB : Bloco
{
    public RegistroB001 RegistroB001
    {
        get
        {
            return (RegistroB001)Registros.Where(r => r.Codigo == "B001").FirstOrDefault();
        }
    }
}
