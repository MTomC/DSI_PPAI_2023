using System.Collections.Generic;

namespace PPAI.Entities {
    public class SubOpcionLlamadaEntity {
        private string nombre;
        private int nroOrden;
        private int id;

        private List<ValidacionEntity> validacionRequerida = new List<ValidacionEntity>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        public int Id { get => id; set => id = value; }

        public List<ValidacionEntity> ValidacionRequerida { get => validacionRequerida; set => validacionRequerida = value; }
    }
}
