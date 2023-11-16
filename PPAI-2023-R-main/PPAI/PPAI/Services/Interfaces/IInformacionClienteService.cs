using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IInformacionClienteService {

        List<InformacionCliente> GetAll();

        List<InformacionCliente> GetInformacionClienteById(int id);
    }
}
