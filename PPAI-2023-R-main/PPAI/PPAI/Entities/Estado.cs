using System;
using System.Collections.Generic;

namespace PPAI.Entities 
{
    // Inherited class {State}
    public class Estado {
        // Fields
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ambito { get; set; }


        // Overriden Methods -----------------------------------------------------------------------------------------\\
        public virtual bool EsIniciada() { return false; }
        public virtual bool EsEnCurso() { return false; }
        public virtual bool EsFinalizada() { return false; }
        public virtual bool EsCancelada() { return false; }
        public virtual void NuevaRtaOperador(Llamada llamada, List<CambioEstado> cambios) { }
        public virtual void FinalizarLlamada(Llamada llamada, List<CambioEstado> cambios) { }

        public virtual void CancelarLlamada(Llamada llamada, List<CambioEstado> cambios)
        {
            var cambio = FindLastCambioEstado(cambios);
            UpdateEstado(llamada, cambio, EstadoCancelada.GetInstance());
        }
        protected virtual Estado CreateProximoEstado() { return null;}
        
        // -----------------------------------------------------------------------------------------------------------\\

        protected CambioEstado FindLastCambioEstado(List<CambioEstado> cambios)
        { return cambios.Find(x => x.Estado == this); }

        protected TimeSpan CalcularDuracion(CambioEstado cambio)
        { return cambio.FechaHoraFin - cambio.FechaHoraInicio; }

        protected void UpdateEstado(Llamada llamada, CambioEstado cambioEstado, Estado nuevoEstado)
        {
            // Update FechaHoraFin from CambioEstado
            cambioEstado.FechaHoraFin = DateTime.Now;
            
            // Create new Estado and CambioEstado
            var nuevoCambioEstado = new CambioEstado(DateTime.Now, nuevoEstado);
            
            // Set new Estado and Add new CambioEstado in Llamada
            llamada.Estado = nuevoEstado;
            llamada.CambiosEstado.Add(nuevoCambioEstado);
        }
    }
}
