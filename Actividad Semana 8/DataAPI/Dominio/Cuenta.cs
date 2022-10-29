using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSLN
{
    public class Cuenta
    {
        public int CBU { get; set; }
        public double Saldo { get; set; }
        public int TipoCuenta { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public string Estado { get; set; }

        public Cliente Cliente { set; get; }

        public Cuenta()
        {
            CBU = 0;
            Saldo = 0;
            TipoCuenta = 0;
            UltimoMovimiento = DateTime.Today;
            Estado = "A";
            Cliente = new Cliente();
        }

        public Cuenta(double saldo, int tipoCuenta, DateTime ultimoMovimiento, Cliente cliente, string estado)
        {
            Saldo = saldo;
            TipoCuenta = tipoCuenta;
            UltimoMovimiento = ultimoMovimiento;
            Cliente = cliente;
            Estado = estado;
        }

        public override string ToString()
        {
            return CBU.ToString();

        }

    }
}
