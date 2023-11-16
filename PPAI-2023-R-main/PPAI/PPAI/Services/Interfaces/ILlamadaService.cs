using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface ILlamadaService {

        List<Llamada> GetAll();

        Llamada GetLlamadaById(int id);

        int RegLlamadaRta(Llamada oLlamada);
    }
}
