

using System.Collections.Generic;

namespace PPAI.Entities
{
    // Inheritance class {State}
    public class EstadoEnCurso : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoEnCurso()); }
        
        // Constructor
        private EstadoEnCurso()
        {
            Id = 2;
            Nombre = "EnCurso";
            Ambito = "Llamada";
        }

        // Override methods
        public override bool EsEnCurso() { return true; }
        public override void FinalizarLlamada(Llamada llamada, List<CambioEstado> cambios)
        {
            // Obtain ultimo cambio
            var cambio = FindLastCambioEstado(cambios);
            // Calculate Duracion
            llamada.Duracion = CalcularDuracion(cambio);
            // Update Estado y CambioEstado
            UpdateEstado(llamada, cambio);
        }
        public override Estado CreateProximoEstado() { return EstadoFinalizada.GetInstance(); }

        
    }
}