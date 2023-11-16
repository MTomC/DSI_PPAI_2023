﻿

using System.Collections.Generic;

namespace PPAI.Entities
{
    // Inheritance class {State}
    public class EstadoLlamadaEnCurso : Estado
    {
        // Static Instance {Singleton}
        private static Estado _instance;
        // Static GetInstance {Singleton}
        public static Estado GetInstance() { return _instance ?? (_instance = new EstadoLlamadaEnCurso()); }
        
        // Constructor
        private EstadoLlamadaEnCurso()
        {
            Id = 2;
            Nombre = "EnCurso";
            Ambito = "Llamada";
        }

        // Override methods
        public override bool EsEnCurso() { return true; }
        public override void FinalizarLlamada(Llamada llamada, List<CambioEstado> cambios)
        {
            // Obtain ultimo cambio
            var cambio = FindLastCambioEstado(cambios);
            // Calculate Duracion
            llamada.Duracion = CalcularDuracion(cambio);
            // Update Estado y CambioEstado
            UpdateEstado(llamada, cambio, EstadoLlamadaFinalizada.GetInstance());
        }
        
        
    }
}