using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Data.InterfacesDaos {
    interface IAccionDao {

        Accion GetAccionById(int id);

        List<Accion> GetAll();
    }
}
