using System;

namespace PPAI.Entities {
    public class CambioEstado {
        // Fields
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private Estado estado = new Estado();
        private int id;

        // Constructor
        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }
        
        // Getters & Setters
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }
    }
}
