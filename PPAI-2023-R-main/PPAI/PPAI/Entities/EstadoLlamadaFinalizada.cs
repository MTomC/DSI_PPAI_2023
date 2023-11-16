using System.Collections.Generic;

namespace PPAI.Entities
{
    // Inheritance class {State}
    public class EstadoLlamadaFinalizada : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoLlamadaFinalizada()); }

        // Constructor
        private EstadoLlamadaFinalizada()
        {
            Id = 3;
            Nombre = "Finalizada";
            Ambito = "Llamada";
        }


        
        // Override methods
        public override bool EsFinalizada() { return true; }

        public override void CancelarLlamada(Llamada llamada, List<CambioEstado> cambios) { }

    }
}