using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using TPPav1.Datos;

namespace PPAI.Data.Daos {
    public class CambioEstadoDao : ICambioEstadoDao {
        public CambioEstado GetCambioEstadoById(int id) {
            throw new NotImplementedException();
        }

        public List<CambioEstado> GetCambiosByLlamadaId(int id) {
            List<CambioEstado> lista = new List<CambioEstado>();
            string consulta = "SELECT * FROM CambioEstado WHERE idLlamada = " + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            EstadoDao edao = new EstadoDao();
            if (tabla.Rows.Count > 0) {
                foreach (DataRow fila in tabla.Rows) {
                    var oCambio = new CambioEstado((DateTime)fila["fechaHoraInicio"], 
                        edao.GetEstadoById((int)fila["idEstado"]));
                    //oCambio.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                    lista.Add(oCambio);
                }
            }
            return lista;
        }
    }
}
