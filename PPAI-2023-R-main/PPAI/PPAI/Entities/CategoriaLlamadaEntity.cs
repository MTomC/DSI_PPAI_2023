using System.Collections.Generic;

namespace PPAI.Entities {
    public class CategoriaLlamadaEntity {
        private string audioMensajeOpciones;
        private string mensajeOpciones;
        private string nombre;
        private int nroOrden;
        private int id;

        private List<OpcionLlamadaEntity> opcion = new List<OpcionLlamadaEntity>();

        public string AudioMensajeOpciones { get => audioMensajeOpciones; set => audioMensajeOpciones = value; }
        public string MensajeOpciones { get => mensajeOpciones; set => mensajeOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        public int Id { get => id; set => id = value; }

        public List<OpcionLlamadaEntity> Opcion { get => opcion; set => opcion = value; }
    }
}
