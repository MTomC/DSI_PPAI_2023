

using System;
using System.Collections.Generic;
using System.Linq;

namespace PPAI.Entities 
{
    // Inherited class {State}
    public class Estado {
        private string nombre;
        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }



        // Overriden Methods by inheritance classes
        public virtual bool EsIniciada() { return false; }
        public virtual bool EsEnCurso() { return false; }
        public virtual bool EsFinalizada() { return false; }
        public virtual bool EsCancelada() { return false; }
        public virtual void NuevaRtaOperador(Llamada llamada, List<CambioEstado> cambios) { }

        public virtual Estado CrearProximoEstado() { return null;}
        
        public CambioEstado CrearCambioEstado(Estado estado)
        {
            return new CambioEstado(DateTime.Now, estado);
        }

        public (Estado nvoEstado, CambioEstado nvoCambio) ActualizarEstado(List<CambioEstado> cambios)
        {
            // Update last CambioEstado
            foreach (var i in cambios.Where(i => i.Estado == this))
            {
                i.FechaHoraFin = DateTime.Now;
            }
            // Create new Estado and new CambioEstado
            var nuevoEstado = CrearProximoEstado();
            var nuevoCambioEstado = CrearCambioEstado(nuevoEstado);
            return (nuevoEstado, nuevoCambioEstado);
            


        }
    }
}
