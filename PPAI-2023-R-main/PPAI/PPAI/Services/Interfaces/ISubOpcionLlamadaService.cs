using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface ISubOpcionLlamadaService {

        List<SubOpcionLlamadaEntity> GetAll();

        SubOpcionLlamadaEntity GetSubOpcionLlamadaById(int id);
    }
}
