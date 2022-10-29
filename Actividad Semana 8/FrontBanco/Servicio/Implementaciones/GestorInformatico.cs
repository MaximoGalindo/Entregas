using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BancoSLN;
using BancoSLN.DataAcces.Implementaciones;

namespace BancoSLN
{
    class GestorInformatico
    {
        CuentaDao oDao = new CuentaDao();
        public DataTable MostrarNombre(int dni)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();
            return helper.ConsultaDBParametros("cargarCliente", "@dni", dni);  
        }

        public List<Cuenta> ObtenerCuentas(int dni)
        {
            return oDao.CargarCuentaClientes(dni);
        }

        public bool BajaLogica(int cbu,string estado)
        {
            HelperDAO helper = HelperDAO.ObtenerInstancia();
            if (helper.BajaLogica(cbu, estado) > 0)
                return true;
            else
                return false;
        }

    }
}
