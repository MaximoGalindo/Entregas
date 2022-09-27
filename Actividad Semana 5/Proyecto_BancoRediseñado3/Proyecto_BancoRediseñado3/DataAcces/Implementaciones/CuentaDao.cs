using Proyecto_BancoRediseñado3.DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3.DataAcces.Implementaciones
{
    class CuentaDao : ICuentaDao
    {
        Cliente cliente = new Cliente();

        public DataTable ConsultarDB()
        {
            return HelperDAO.ObtenerInstancia().ConsultarDB("SP_TipoCuenta");
        }

        public bool CrearCuenta(Cuenta oCuenta)
        {
            Cuenta cuenta = new Cuenta(oCuenta.Saldo, oCuenta.TipoCuenta, oCuenta.UltimoMovimiento, oCuenta.Cliente, oCuenta.Estado);
            cliente.AgregarCuenta(cuenta);

            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@saldo", oCuenta.Saldo));
            lParametros.Add(new Parametros("@tipoCuenta", oCuenta.TipoCuenta));
            lParametros.Add(new Parametros("@ultMov", oCuenta.UltimoMovimiento));
            lParametros.Add(new Parametros("@dni", oCuenta.Cliente.DNI));
            lParametros.Add(new Parametros("@estado", oCuenta.Estado));
            if (HelperDAO.ObtenerInstancia().Transaccion("SP_insertCuenta", lParametros) > 0)
                return true;
            else
                return false;
        }


    }
}
