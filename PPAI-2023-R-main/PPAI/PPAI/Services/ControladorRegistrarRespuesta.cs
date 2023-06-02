using PPAI.Entities;
using PPAI.Services.Implementaciones;
using PPAI.Services.Interfaces;
using PPAI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Services {
    public class ControladorRegistrarRespuesta {
        LlamadaEntity llamadaActual;
        CategoriaLlamadaEntity categoriaSeleccionada;
        OpcionLlamadaEntity opcionSeleccionada = new OpcionLlamadaEntity();
        SubOpcionLlamadaEntity subopcionSeleccionada = new SubOpcionLlamadaEntity();
        List<ValidacionEntity> validaciones = new List<ValidacionEntity>();
        PantallaRegistrarRespuesta _pantalla;

        IEstadoService estadoService = new EstadoService();
        ILlamadaService llamadaService = new LlamadaService();
        ICategoriaLlamadaService categoriaService = new CategoriaLlamadaService();

        internal void BuscarDatosLlamada() {
            BuscarInfoLlamada();
            List<string> nombreValidaciones = new List<string>();
            foreach (ValidacionEntity validacion in validaciones) {
                nombreValidaciones.Add(validacion.Nombre);
            }
            _pantalla.MostrarDatosLlamada(llamadaActual.Cliente.NombreCompleto, categoriaSeleccionada.Nombre, opcionSeleccionada.Nombre, subopcionSeleccionada.Nombre);
            _pantalla.MostrarValidaciones(nombreValidaciones);
        }

        public void NuevaRtaOperador(int idLlamada, int idCategoria, PantallaRegistrarRespuesta pantalla) {
            llamadaActual = llamadaService.GetLlamadaById(idLlamada); //getCliente
            categoriaSeleccionada = categoriaService.GetCategoriaLlamadaById(idCategoria); //getCategoria
            _pantalla = pantalla;
            EstadoEntity enCurso = null;
            foreach (EstadoEntity estadoE in estadoService.GetAll()) { //*esEnCurso
                if (estadoE.EsEnCurso()) 
                    enCurso = estadoE;
            }
            if (enCurso != null)
                llamadaActual.SetEstadoActual(enCurso, DateTime.Now); //obtenerFechaActual
        }

        public void BuscarInfoLlamada() {
            opcionSeleccionada = llamadaActual.OpcionSeleccionada; //getOpcionSeleccionada
            subopcionSeleccionada = llamadaActual.SubOpcionSeleccionada;
            foreach (ValidacionEntity validacion in subopcionSeleccionada.ValidacionRequerida) {
                validaciones.Add(validacion);
            }
        }

        public void TomarRtaYConfirmacion(string rtaOperador, AccionEntity accion) {
            llamadaActual.DescripcionOperador = rtaOperador;
            LlamarCU28(accion);
            EstadoEntity finalizada = null;
            foreach (EstadoEntity estadoE in estadoService.GetAll()) {  //esFinalizada
                if (estadoE.EsFinalizada())
                    finalizada = estadoE;
            }
            DateTime now = DateTime.Now;
            llamadaActual.CalcularDuracion(now);   //calcularDuracion
            if (finalizada != null)
                llamadaActual.SetEstadoActual(finalizada, now);

            int filasAfectadas = llamadaService.RegLlamadaRta(llamadaActual);
            if (filasAfectadas >= 1)
                FinCU();

            MessageBox.Show("Los datos de la LLamadaActual NO se registraron con éxito..");
        }

        //Flujo Alternativo: CancelarLlamada
        public void CancelarLlamada() {
            EstadoEntity cancelada = null;
            foreach (EstadoEntity estadoE in estadoService.GetAll()) {
                if (estadoE.EsCancelada())
                    cancelada = estadoE;
            }
            DateTime now = DateTime.Now;
            llamadaActual.CalcularDuracion(now);
            if (cancelada != null)
                llamadaActual.SetEstadoActual(cancelada, now);
        }

        public void FinCU() {
            MessageBox.Show("Respuesta registrada con exito");
            _pantalla.Close();
        }

        public void LlamarCU28(AccionEntity accion) {
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
