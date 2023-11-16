using System.Collections.Generic;

namespace PPAI.Entities {
    public class Cliente {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;
        private int id;

        private List<InformacionCliente> info = new List<InformacionCliente>();

        public int Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int NroCelular { get => nroCelular; set => nroCelular = value; }
        public int Id { get => id; set => id = value; }

        public List<InformacionCliente> Info { get => info; set => info = value; }

        public bool EsInfoCorrecta(string respuesta, ValidacionEntity validacion) {
            foreach (InformacionCliente info in Info) {
                if (info.EsValidacion(validacion))
                    return info.EsInfoCorrecta(respuesta); 
            }
            return false;
        }
    }
}
