using System.Collections.Generic;

namespace PPAI.Entities
{
    // Inheritance class {State}
    public class EstadoLlamadaIniciada : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoLlamadaIniciada()); }
        
        // Constructor
        private EstadoLlamadaIniciada()
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
            UpdateEstado(llamada, cambio, EstadoLlamadaEnCurso.GetInstance());
        }

    }
}