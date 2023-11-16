using PPAI.Entities;
using System.Collections.Generic;

namespace PPAI.Data.InterfacesDaos {
    interface IValidacionDao {

        ValidacionEntity GetValidacionById(int id);

        List<ValidacionEntity> GetValidacionBySubOpcionId(int id);

        List<ValidacionEntity> GetValidacionByOpcionId(int id);
    }
}
