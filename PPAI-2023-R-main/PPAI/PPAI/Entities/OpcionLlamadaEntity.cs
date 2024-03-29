﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities {
    public class OpcionLlamadaEntity {
        private string audioMensajeSubopciones;
        private string mensajeSubopciones;
        private string nombre;
        private int nroOrden;
        private int id;

        private List<SubOpcionLlamadaEntity> subopcionLlamada = new List<SubOpcionLlamadaEntity>();
        private List<ValidacionEntity> validacionesRequeridas = new List<ValidacionEntity>();

        public string AudioMensajeSubopciones { get => audioMensajeSubopciones; set => audioMensajeSubopciones = value; }
        public string MensajeSubopciones { get => mensajeSubopciones; set => mensajeSubopciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        public int Id { get => id; set => id = value; }

        public List<SubOpcionLlamadaEntity> SubopcionLlamada { get => subopcionLlamada; set => subopcionLlamada = value; }
        public List<ValidacionEntity> ValidacionesRequeridas { get => validacionesRequeridas; set => validacionesRequeridas = value; }
    }
}
