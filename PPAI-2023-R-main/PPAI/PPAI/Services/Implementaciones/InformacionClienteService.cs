using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class InformacionClienteService : IInformacionClienteService {
        IInformacionClienteDao ldao = new InformacionClienteDao();

        public List<InformacionCliente> GetAll() {
            throw new NotImplementedException();
        }

        public List<InformacionCliente> GetInformacionClienteById(int id) {
            return ldao.GetInformacionClienteById(id);
        }
    }
}
