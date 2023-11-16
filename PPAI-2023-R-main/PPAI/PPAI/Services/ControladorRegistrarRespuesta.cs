using PPAI.Entities;
using PPAI.Services.Implementaciones;
using PPAI.Services.Interfaces;
using PPAI.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PPAI.Services {
    public class ControladorRegistrarRespuesta {
        Llamada llamadaActual;
        CategoriaLlamadaEntity categoriaSeleccionada;
        OpcionLlamadaEntity opcionSeleccionada = new OpcionLlamadaEntity();
        SubOpcionLlamadaEntity subopcionSeleccionada = new SubOpcionLlamadaEntity();
        List<ValidacionEntity> validaciones = new List<ValidacionEntity>();
        PantallaRegistrarRespuesta pantalla;

        IEstadoService estadoService = new EstadoService();
        ILlamadaService llamadaService = new LlamadaService();
        ICategoriaLlamadaService categoriaService = new CategoriaLlamadaService();

        internal void BuscarDatosLlamada() {
            BuscarInfoLlamada();
            List<string> nombreValidaciones = new List<string>();
            foreach (ValidacionEntity validacion in validaciones) {
                nombreValidaciones.Add(validacion.Nombre);
            }
            pantalla.MostrarDatosLlamada(llamadaActual.Cliente.NombreCompleto, categoriaSeleccionada.Nombre, opcionSeleccionada.Nombre, subopcionSeleccionada.Nombre);
            pantalla.MostrarValidaciones(nombreValidaciones);
        }

        public void NuevaRtaOperador(int idLlamada, int idCategoria, PantallaRegistrarRespuesta pantalla) {
            
            // MODIFICAR ESTO CON LOS NUEVOS MÉTODOS!!!
            
            
            llamadaActual = llamadaService.GetLlamadaById(idLlamada); // Get Llamada from Service
            categoriaSeleccionada = categoriaService.GetCategoriaLlamadaById(idCategoria); // Get Categoria from Service
            this.pantalla = pantalla; // Set Pantalla
            
            llamadaActual.NuevaRtaOperador(); // Delegar la responsabilidad a la llamada
            
            // Creo que esto funciona, NO FUE TESTEADO, Requiere cambios en la BD y los DAO!!!!!!!!!!!!!
        }

        public void BuscarInfoLlamada() {
            opcionSeleccionada = llamadaActual.OpcionSeleccionada; //getOpcionSeleccionada
            subopcionSeleccionada = llamadaActual.SubOpcionSeleccionada;
            foreach (ValidacionEntity validacion in subopcionSeleccionada.ValidacionRequerida) {
                validaciones.Add(validacion);
            }
        }

        public void TomarRtaYConfirmacion(string rtaOperador, Accion accion) {
            llamadaActual.DescripcionOperador = rtaOperador;
            LlamarCU28(accion);
            
            // -----------Version con el patron aplicado-------------------------
            llamadaActual.FinalizarLlamada(); // Delegar a la llamada
            // ------------------------------------------------------------------
            
            /*
            Estado finalizada = null;
            foreach (Estado estadoE in estadoService.GetAll()) {  //esFinalizada
                if (estadoE.EsFinalizada())
                    finalizada = estadoE;
            }
            DateTime now = DateTime.Now;
            llamadaActual.CalcularDuracion(now);   //calcularDuracion
            if (finalizada != null)
                llamadaActual.SetEstadoActual(finalizada, now);
                */

            int filasAfectadas = llamadaService.RegLlamadaRta(llamadaActual);
            if (filasAfectadas >= 1)
                FinCU();

            MessageBox.Show("Los datos de la LLamadaActual NO se registraron con éxito..");
        }

        //Flujo Alternativo: CancelarLlamada
        public void CancelarLlamada() {
            // -----------Version con el patron aplicado-------------------------------------------------\\
            llamadaActual.CancelarLlamada();
            // ------------------------------------------------------------------------------------------\\

            
            /*Estado cancelada = null;
            foreach (Estado estadoE in estadoService.GetAll()) {
                if (estadoE.EsCancelada())
                    cancelada = estadoE;
            }
            DateTime now = DateTime.Now;
            llamadaActual.CalcularDuracion(now);
            if (cancelada != null)
                llamadaActual.SetEstadoActual(cancelada, now);*/
        }

        public void FinCU() {
            MessageBox.Show("Respuesta registrada con exito");
            pantalla.Close();
        }

        public void LlamarCU28(Accion accion) {
            llamadaActual.Accion = accion;
            MessageBox.Show("Accion registrada con exito");
        }

        public bool TomarValidacion(string validacion, string respuesta) { //esValidacion 
            foreach (ValidacionEntity v in validaciones) {
                if (v.Nombre == validacion) {
                    return llamadaActual.ValidarInfoCliente(respuesta, v); //esInfoCorrect
                }
            }
            return false;
        }
    }
}
