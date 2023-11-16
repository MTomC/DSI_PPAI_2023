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
            Id = 1;
            Nombre = "Iniciada";
            Ambito = "Llamada";
        }
        
        // Override methods
        public override bool EsIniciada() { return true; }

        // Method for....
        public override void NuevaRtaOperador(Llamada llamada, List<CambioEstado> cambios)
        {
            var cambio = FindLastCambioEstado(cambios);
            UpdateEstado(llamada, cambio);
        }

        public override Estado CreateProximoEstado() { return EstadoEnCurso.GetInstance(); }



    }
}