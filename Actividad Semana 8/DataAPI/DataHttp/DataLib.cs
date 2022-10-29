using BancoSLN;
using BancoSLN.DataAcces.Implementaciones;
using BancoSLN.DataAcces.Interfaces;
using DataAPI.DataAcces.Implementaciones;
using DataAPI.DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.DataHttp
{
    public class DataLib : IDataLib
    {
        private ICuentaDao oDaoCuenta;
        private IClienteDao oDaoCliente;

        public DataLib()
        {
            oDaoCuenta = new CuentaDao();
            oDaoCliente = new ClienteDao();
        }


        /////////////////////////////////////////////////////// CLIENTES////////////////////////////////////////////////////////////////

        public List<Cliente> GetClientes()
        {
            return oDaoCliente.ConsultarDB();
        }


        /////////////////////////////////////////////////////// CUENTAS ////////////////////////////////////////////////////////////////
              

        public bool CrearCuenta(Cuenta cuenta)
        {
            return oDaoCuenta.CrearCuenta(cuenta);
        }
        
        public List<Cuenta> GetCuentas(int dni)
        {
            return oDaoCuenta.CargarCuentaClientes(dni);
        }                    


    }
}
