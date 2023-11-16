using System.Collections.Generic;

namespace PPAI.Entities
{
    public class EstadoLlamadaCancelada : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoLlamadaCancelada()); }

        // Constructor
        private EstadoLlamadaCancelada()
        {
            Id = 4;
            Nombre = "Cancelada";
            Ambito = "Llamada";
        }
        
        // Overriding boolean method {State}
        public override bool EsCancelada() { return true; }
        public override void CancelarLlamada(Llamada llamada, List<CambioEstado> cambios) { }

        
    }
}