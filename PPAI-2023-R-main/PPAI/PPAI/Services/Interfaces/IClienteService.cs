using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IClienteService {

        List<ClienteEntity> GetAll();

        ClienteEntity GetClienteById(int id);
    }
}
