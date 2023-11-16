using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IClienteService {

        List<Cliente> GetAll();

        Cliente GetClienteById(int id);
    }
}
