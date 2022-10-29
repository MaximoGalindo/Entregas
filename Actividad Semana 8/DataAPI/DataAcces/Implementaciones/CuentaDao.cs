using BancoSLN;
using BancoSLN.DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSLN.DataAcces.Implementaciones
{
    public class CuentaDao : ICuentaDao
    {
        Cliente cliente = new Cliente();
        public DataTable ConsultarDB()
        {
            return HelperDAO.ObtenerInstancia().ConsultarDB("SP_TipoCuenta");
        }


        public List<Cuenta> CargarCuentaClientes(int dni)
        {
            List<Cuenta> lstCuenta = new List<Cuenta>();
            HelperDAO helper = HelperDAO.ObtenerInstancia();
            DataTable t = helper.ConsultaDBParametros("cargarCuentaCliente", "@dni", dni);    


            foreach (DataRow row in t.Rows)
            {
                Cuenta cuenta = new Cuenta();               
                cuenta.CBU = Convert.ToInt32(row["cbu"].ToString());
                cuenta.Saldo = Convert.ToDouble(row["saldo"].ToString());
                cuenta.TipoCuenta = Convert.ToInt32(row["id_cuenta"].ToString());
                cuenta.UltimoMovimiento = Convert.ToDateTime(row["ultMov"].ToString());
                cuenta.Estado = row["estado"].ToString();
                
                lstCuenta.Add(cuenta);
            }

            return lstCuenta;

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
  

