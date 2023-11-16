using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IOpcionValidacionService {

        List<OpcionValidacionEntity> GetAll();

        OpcionValidacionEntity GetOpcionValidacionById(int id);
    }
}
