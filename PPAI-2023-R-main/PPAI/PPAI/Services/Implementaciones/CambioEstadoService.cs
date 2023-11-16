using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class CambioEstadoService : ICambioEstadoService {
        ICambioEstadoDao cedao = new CambioEstadoDao();

        public List<CambioEstado> GetAll() {
            throw new NotImplementedException();
        }

        public CambioEstado GetCambioEstadoById(int id) {
            return cedao.GetCambioEstadoById(id);
        }
    }
}
