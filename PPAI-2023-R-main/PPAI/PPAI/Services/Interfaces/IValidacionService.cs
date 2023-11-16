using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Services.Interfaces {
    internal interface IValidacionService {

        List<ValidacionEntity> GetAll();

        ValidacionEntity GetValidacionById(int id);
    }
}
