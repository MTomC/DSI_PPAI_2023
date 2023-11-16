using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Data.InterfacesDaos {
    interface IInformacionClienteDao {

        List<InformacionClienteEntity> GetInformacionClienteById(int id);
    }
}
