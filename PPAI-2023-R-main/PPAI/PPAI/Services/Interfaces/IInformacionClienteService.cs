using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IInformacionClienteService {

        List<InformacionClienteEntity> GetAll();

        List<InformacionClienteEntity> GetInformacionClienteById(int id);
    }
}
