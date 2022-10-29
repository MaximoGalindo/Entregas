using BancoSLN;
using DataAPI.DataAcces.Implementaciones;
using DataAPI.DataAcces.Interfaces;
using FrontBanco.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace FrontBanco.Servicio.Implementaciones
{
    public class ServicioCliente : IClienteService
    {
        private IClienteDao oDao;

        public ServicioCliente()
        {
            oDao = new ClienteDao();
        }

        public List<Cliente> CargarLista()
        {
            return oDao.ConsultarDB();
        }

        public bool CrearCliente(Cliente oCliente)
        {
            return oDao.CargarCliente(oCliente);
        }
    }
}
