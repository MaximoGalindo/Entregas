using BancoSLN;
using DataAPI.DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.DataAcces.Implementaciones
{
    public class ClienteDao : IClienteDao
    {
        public List<Cliente> ConsultarDB()
        {

            List<Cliente> lstClientes = new List<Cliente>();
            DataTable t = HelperDAO.ObtenerInstancia().ConsultarDB("SP_lstClientes");

            foreach (DataRow dr in t.Rows)
            {
                string Nombre = dr["Nombre"].ToString();
                string Apellido = dr["Apellido"].ToString();
                int dni = (int)dr["dni"];

                Cliente aux = new Cliente(Nombre, Apellido, dni);
                lstClientes.Add(aux);
            }
            return lstClientes;                      
        }

        public bool CargarCliente(Cliente oCliente)
        {
            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@dni", oCliente.DNI));
            lParametros.Add(new Parametros("@nombre", oCliente.Nombre));
            lParametros.Add(new Parametros("@apellido", oCliente.Apellido));

            if (HelperDAO.ObtenerInstancia().Transaccion("SP_insertCliente", lParametros) > 0)
                return true;
            else
                return false;
        }
    }
}
