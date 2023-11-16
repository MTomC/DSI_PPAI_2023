using System;
using System.Collections.Generic;

namespace PPAI.Entities {
    public class Llamada {
        
        // Fields
        private string detalleAccionRequerida;
        private TimeSpan duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private OpcionLlamadaEntity opcionSeleccionada = new OpcionLlamadaEntity();
        private SubOpcionLlamadaEntity subOpcionSeleccionada = new SubOpcionLlamadaEntity();
        private string auditor;
        private string operador;
        private ClienteEntity cliente = new ClienteEntity();
        private Accion accion = new Accion();
        // New kind of properties
        public Estado Estado { get; set; }

        private List<CambioEstado> cambiosEstado = new List<CambioEstado>();
        private int id;

        public string DescripcionOperador { get; set; }

        public string DetalleAccionRequerida { get => detalleAccionRequerida; set => detalleAccionRequerida = value; }
        public TimeSpan Duracion { get => duracion; set => duracion = value; }
        public bool EncuestaEnviada { get => encuestaEnviada; set => encuestaEnviada = value; }
        public string ObservacionAuditor { get => observacionAuditor; set => observacionAuditor = value; }
        public OpcionLlamadaEntity OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }
        public SubOpcionLlamadaEntity SubOpcionSeleccionada { get => subOpcionSeleccionada; set => subOpcionSeleccionada = value; }
        public string Auditor { get => auditor; set => auditor = value; }
        public string Operador { get => operador; set => operador = value; }
        public ClienteEntity Cliente { get => cliente; set => cliente = value; }
        public Accion Accion { get => accion; set => accion = value; }

        public List<CambioEstado> CambiosEstado { get => cambiosEstado; set => cambiosEstado = value; }
        public int Id { get => id; set => id = value; }

        
        // Methods
        
        public void NuevaRtaOperador()
        {
            Estado.NuevaRtaOperador(this, CambiosEstado); // Delegar la responsabilidad al estado
        }

        public void FinalizarLlamada()
        {
            Estado.FinalizarLlamada(this, CambiosEstado); // Delegar al estado
        }

        public void CancelarLlamada()
        {
            Estado.CancelarLlamada(this, CambiosEstado);
        }

        public bool ValidarInfoCliente(string respuesta, ValidacionEntity validacion) { //esInfoCorrecta
            return Cliente.EsInfoCorrecta(respuesta, validacion);  
        }

        public void CalcularDuracion(DateTime horaFin) {
            DateTime horaInicio = DateTime.Now;
            foreach (CambioEstado cambioEstado in CambiosEstado) {
                if (cambioEstado.Estado.EsEnCurso())
                    horaInicio = cambioEstado.FechaHoraInicio;
            }
            if (horaInicio != null) {
                Duracion = horaFin - horaInicio;
            }
        }
    }
}
