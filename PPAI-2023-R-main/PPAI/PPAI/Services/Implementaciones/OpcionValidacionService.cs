using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class OpcionValidacionService : IOpcionValidacionService {
        IOpcionValidacionDao ldao = new OpcionValidacionDao();

        public List<OpcionValidacionEntity> GetAll() {
            throw new NotImplementedException();
        }

        public OpcionValidacionEntity GetOpcionValidacionById(int id) {
            return ldao.GetOpcionValidacionById(id);
        }
    }
}
