using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IEstadoService {

        List<Estado> GetAll();

        Estado GetEstadoById(int id);
    }
}
