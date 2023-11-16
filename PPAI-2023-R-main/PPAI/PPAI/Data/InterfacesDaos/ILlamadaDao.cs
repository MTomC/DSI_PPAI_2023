using PPAI.Entities;

namespace PPAI.Data.InterfacesDaos {
    interface ILlamadaDao {

        Llamada GetLlamadaById(int id);

        int RegLlamadaRta(Llamada oLlamada);
    }
}
