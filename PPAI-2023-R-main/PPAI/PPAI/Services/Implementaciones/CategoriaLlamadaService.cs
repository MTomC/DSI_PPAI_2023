using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PPAI.Services.Implementaciones {
    public class CategoriaLlamadaService : ICategoriaLlamadaService {
        ICategoriaLlamadaDao cldao = new CategoriaLlamadaDao();

        public List<CategoriaLlamadaEntity> GetAll() {
            throw new NotImplementedException();
        }

        public CategoriaLlamadaEntity GetCategoriaLlamadaById(int id) {
            return cldao.GetCategoriaLlamadaByid(id);
        }
    }
}
