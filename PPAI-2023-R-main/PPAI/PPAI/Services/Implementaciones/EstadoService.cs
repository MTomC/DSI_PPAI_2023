using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class EstadoService : IEstadoService {
        IEstadoDao ledao = new EstadoDao();

        public List<Estado> GetAll() {
            return ledao.GetAll();
        }

        public Estado GetEstadoById(int id) {
            return ledao.GetEstadoById(id);
        }
    }

}
