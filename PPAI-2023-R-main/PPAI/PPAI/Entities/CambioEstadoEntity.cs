using System;

namespace PPAI.Entities {
    public class CambioEstadoEntity {
        // Fields
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private EstadoEntity estado = new EstadoEntity();
        private int id;

        // Constructor
        public CambioEstadoEntity(DateTime fechaHoraInicio, EstadoEntity estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }
        
        // Getters & Setters
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public EstadoEntity Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }
    }
}
