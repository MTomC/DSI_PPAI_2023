using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Data.InterfacesDaos {
    interface ISubOpcionLlamadaDao {

        SubOpcionLlamadaEntity GetSubOpcionLlamadaById(int id);

        List<SubOpcionLlamadaEntity> GetSubOpcionByOpcionId(int id);
    }
}
