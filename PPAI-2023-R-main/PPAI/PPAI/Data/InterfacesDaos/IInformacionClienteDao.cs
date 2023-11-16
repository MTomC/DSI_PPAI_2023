using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Data.InterfacesDaos {
    interface IInformacionClienteDao {

        List<InformacionCliente> GetInformacionClienteById(int id);
    }
}
