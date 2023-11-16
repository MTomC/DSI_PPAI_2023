using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class LlamadaService : ILlamadaService {
        ILlamadaDao ldao = new LlamadaDao();

        public List<Llamada> GetAll() {
            throw new NotImplementedException();
        }

        public Llamada GetLlamadaById(int id) {
            return ldao.GetLlamadaById(id);
        }

        public int RegLlamadaRta(Llamada oLlamada) {
            return ldao.RegLlamadaRta(oLlamada);
        }
    }
}
