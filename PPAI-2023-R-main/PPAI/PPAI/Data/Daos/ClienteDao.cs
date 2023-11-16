using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using System;
using System.Data;
using TPPav1.Datos;

namespace PPAI.Data.Daos {
    class ClienteDao : IClienteDao {
        public Cliente GetClienteById(int id) {
            Cliente oCliente = new Cliente();
            string consulta = "Select * from Cliente where id = " + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            InformacionClienteDao icdao = new InformacionClienteDao();
            if (tabla.Rows.Count > 0) {
                oCliente.Dni = (int)tabla.Rows[0]["dni"];
                oCliente.NombreCompleto = tabla.Rows[0]["apellido"].ToString() + ", " + tabla.Rows[0]["nombre"].ToString();
                oCliente.NroCelular = (int)tabla.Rows[0]["nroCelular"];

                oCliente.Info = icdao.GetInformacionClienteById((int)tabla.Rows[0]["id"]);
                oCliente.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
            }
            return oCliente;
        }
    }
}
