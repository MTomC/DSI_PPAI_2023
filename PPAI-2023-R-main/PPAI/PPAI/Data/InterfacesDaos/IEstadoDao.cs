using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Data.InterfacesDaos {
    interface IEstadoDao {

        Estado GetEstadoById(int id);

        List<Estado> GetAll();
    }
}
