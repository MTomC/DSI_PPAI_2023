using PPAI.Entities;

namespace PPAI.Data.InterfacesDaos {
    interface ICambioEstadoDao {

        CambioEstado GetCambioEstadoById(int id);
    }
}
