using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface ICategoriaLlamadaService {

        List<CategoriaLlamadaEntity> GetAll();

        CategoriaLlamadaEntity GetCategoriaLlamadaById(int id);
    }
}
