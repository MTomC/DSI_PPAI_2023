using System.Collections.Generic;

namespace PPAI.Entities
{
    // Inheritance class {State}
    public class EstadoIniciada : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoIniciada()); }
        
        // Constructor
        private EstadoIniciada()
        {
            
        }
        
        // Overriding boolean method {State}
        public override bool EsIniciada() { return true; }

        // Method for....
        public override void NuevaRtaOperador(Llamada llamada, List<CambioEstado> cambios)
        {
            // Update CambioEstado and get the New Estado and CambioEstado
            var estadoActualizado = ActualizarEstado(cambios);
            
            // Set new Estado and Add new CambioEstado in Llamada
            llamada.Estado = estadoActualizado.nvoEstado;
            llamada.CambiosEstado.Add(estadoActualizado.nvoCambio);
        }

        public override Estado CrearProximoEstado() { return EstadoEnCurso.GetInstance(); }



    }
}