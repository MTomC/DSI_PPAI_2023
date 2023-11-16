using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using TPPav1.Datos;

namespace PPAI.Data.Daos {
    public class InformacionClienteDao : IInformacionClienteDao {
        public List<InformacionCliente> GetInformacionClienteById(int ID) {
            List<InformacionCliente> lista = new List<InformacionCliente>();
            string consulta = "Select * from InformacionCliente where idCliente = " + ID;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            OpcionValidacionDao ovdao = new OpcionValidacionDao();
            ValidacionDao vdao = new ValidacionDao();
            if (tabla.Rows.Count > 0) {
                foreach (DataRow fila in tabla.Rows) {
                    InformacionCliente info = new InformacionCliente();
                    info.DatoAValidar = fila["datoAValidar"].ToString();
                    info.Tipo = fila["tipo"].ToString();
                    info.OpcionCorrecta = ovdao.GetOpcionValidacionById((int)fila["idOpcionCorrecta"]);
                    info.Validacion = vdao.GetValidacionById((int)fila["idValidacion"]);
                    info.Id = Int32.Parse(tabla.Rows[0]["idInfoCliente"].ToString());
                    lista.Add(info);
                }
            }
            return lista;
        }
    }
}
