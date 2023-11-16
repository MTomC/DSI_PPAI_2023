using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class ClienteService : IClienteService {
        IClienteDao cdao = new ClienteDao();

        public List<Cliente> GetAll() {
            throw new NotImplementedException();
        }

        public Cliente GetClienteById(int id) {
            return cdao.GetClienteById(id);
        }
    }
}
