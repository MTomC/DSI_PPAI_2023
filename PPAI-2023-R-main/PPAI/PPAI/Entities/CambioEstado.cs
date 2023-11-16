using System;

namespace PPAI.Entities {
    public class CambioEstado {
        // Fields
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public Estado Estado { get; set; }
        public int Id { get; set; }

        // Constructor
        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            FechaHoraInicio = fechaHoraInicio;
            Estado = estado;
        }
        
    }
}
