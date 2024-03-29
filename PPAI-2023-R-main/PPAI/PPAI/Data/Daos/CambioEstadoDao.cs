﻿using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos;

namespace PPAI.Data.Daos {
    public class CambioEstadoDao : ICambioEstadoDao {
        public CambioEstadoEntity GetCambioEstadoById(int id) {
            throw new NotImplementedException();
        }

        public List<CambioEstadoEntity> GetCambiosByLlamadaId(int id) {
            List<CambioEstadoEntity> lista = new List<CambioEstadoEntity>();
            string consulta = "SELECT * FROM CambioEstado WHERE idLlamada = " + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            EstadoDao edao = new EstadoDao();
            if (tabla.Rows.Count > 0) {
                foreach (DataRow fila in tabla.Rows) {
                    CambioEstadoEntity oCambio = new CambioEstadoEntity();
                    oCambio.Estado = edao.GetEstadoById((int)fila["idEstado"]);
                    oCambio.FechaHoraInicio = (DateTime)fila["fechaHoraInicio"];
                    oCambio.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                    lista.Add(oCambio);
                }
            }
            return lista;
        }
    }
}
