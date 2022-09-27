using Proyecto_BancoRediseñado3.DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3.DataAcces.Implementaciones
{
    class ClienteDao : IClienteDao
    {
        public DataTable ConsultarDB()
        {
            return HelperDAO.ObtenerInstancia().ConsultarDB("SP_lstClientes");
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
