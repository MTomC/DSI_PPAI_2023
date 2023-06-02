using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities {
    public class EstadoEntity {
        private string nombre;
        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public bool EsEnCurso() {
            if (Nombre.Contains("EnCurso"))
                return true;
            return false;
        }

        public bool EsFinalizada() {
            if (Nombre.Contains("Finalizada"))
                return true;
            return false;
        }

        internal bool EsCancelada() {
            if (Nombre.Contains("Cancelada"))
                return true;
            return false; ;
        }
    }
}
