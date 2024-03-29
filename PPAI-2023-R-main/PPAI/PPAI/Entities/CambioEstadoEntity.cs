﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities {
    public class CambioEstadoEntity {
        private DateTime fechaHoraInicio;
        private EstadoEntity estado = new EstadoEntity();
        private int id;

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public EstadoEntity Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }
    }
}
