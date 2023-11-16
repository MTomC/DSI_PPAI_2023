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
        public virtual Estado CreateProximoEstado() { return null;}
        
        // -----------------------------------------------------------------------------------------------------------\\
        
        public CambioEstado CreateCambioEstado(Estado estado)
        { return new CambioEstado(DateTime.Now, estado); }

        public CambioEstado FindLastCambioEstado(List<CambioEstado> cambios)
        { return cambios.Find(x => x.Estado == this); }

        public TimeSpan CalcularDuracion(CambioEstado cambio)
        { return cambio.FechaHoraFin - cambio.FechaHoraInicio; }

        public void UpdateEstado(Llamada llamada, CambioEstado cambioEstado)
        {
            // Update FechaHoraFin from CambioEstado
            cambioEstado.FechaHoraFin = DateTime.Now;
            
            // Create new Estado and CambioEstado
            var nuevoEstado = CreateProximoEstado();
            var nuevoCambioEstado = CreateCambioEstado(nuevoEstado);
            
            // Set new Estado and Add new CambioEstado in Llamada
            llamada.Estado = nuevoEstado;
            llamada.CambiosEstado.Add(nuevoCambioEstado);
        }
    }
}
