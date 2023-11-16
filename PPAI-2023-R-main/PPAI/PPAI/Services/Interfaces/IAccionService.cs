using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IAccionService {

        List<Accion> GetAll();

        Accion GetAccionById(int id);
    }
}
