using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using TPPav1.Datos;

namespace PPAI.Data.Daos {
    class AccionDao : IAccionDao {
        public Accion GetAccionById(int id) {
            Accion oAccion = new Accion();
            string consulta = "SELECT * FROM Accion WHERE id =" + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0) {
                oAccion.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                oAccion.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
            }
            return oAccion;
        }

        public List<Accion> GetAll() {
            List<Accion> lista = new List<Accion>();
            string consulta = "Select * from Accion";

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0) {
                foreach (DataRow fila in tabla.Rows) {
                    Accion oAccion = new Accion();
                    oAccion.Descripcion = fila["descripcion"].ToString();
                    oAccion.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                    lista.Add(oAccion);
                }
            }
            return lista;
        }
    }
}
