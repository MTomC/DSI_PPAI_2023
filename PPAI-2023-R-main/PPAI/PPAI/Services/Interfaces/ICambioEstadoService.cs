using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface ICambioEstadoService {

        List<CambioEstado> GetAll();

        CambioEstado GetCambioEstadoById(int id);
    }
}
