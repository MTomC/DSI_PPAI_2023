using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class AccionService : IAccionService {
        IAccionDao adao = new AccionDao();

        public List<Accion> GetAll() {
            return adao.GetAll();
        }

        public Accion GetAccionById(int id) {
            return adao.GetAccionById(id);
        }
    }
}
