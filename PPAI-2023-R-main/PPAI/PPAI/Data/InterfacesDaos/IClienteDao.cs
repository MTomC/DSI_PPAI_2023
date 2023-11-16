using PPAI.Entities;

namespace PPAI.Data.InterfacesDaos {
    interface IClienteDao {

        ClienteEntity GetClienteById(int id);
    }
}
