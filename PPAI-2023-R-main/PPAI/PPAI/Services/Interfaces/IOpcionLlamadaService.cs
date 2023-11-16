using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IOpcionLlamadaService {

        List<OpcionLlamadaEntity> GetAll();

        OpcionLlamadaEntity GetOpcionLlamadaById(int id);
    }
}
