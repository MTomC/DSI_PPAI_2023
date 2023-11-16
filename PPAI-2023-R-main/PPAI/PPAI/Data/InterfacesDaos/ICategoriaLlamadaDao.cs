using PPAI.Entities;

namespace PPAI.Data.InterfacesDaos {
    interface ICategoriaLlamadaDao {

        CategoriaLlamadaEntity GetCategoriaLlamadaByid(int id);
    }
}
