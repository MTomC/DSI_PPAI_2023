using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Data.InterfacesDaos {
    interface IOpcionLlamadaDao {

        OpcionLlamadaEntity GetOpcionLlamadaById(int id);

        List<OpcionLlamadaEntity> GetOpcionByCategoriaId(int id);
    }
}
