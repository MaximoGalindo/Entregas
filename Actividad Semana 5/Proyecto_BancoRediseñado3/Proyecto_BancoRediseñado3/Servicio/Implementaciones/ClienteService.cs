using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_BancoRediseñado3.Servicio.Interface;
using Proyecto_BancoRediseñado3.DataAcces.Interfaces;
using Proyecto_BancoRediseñado3.DataAcces.Implementaciones;

namespace Proyecto_BancoRediseñado3
{
    class ClienteService: IClienteService 
    {
        private IClienteDao oDao;

        public ClienteService()
        {
            oDao = new ClienteDao();
        }

        public DataTable CargarListaClientes()
        {
            return oDao.ConsultarDB();
        }

        public bool CrearCliente(Cliente c)
        {
            return oDao.CargarCliente(c);
        }
    }
}
