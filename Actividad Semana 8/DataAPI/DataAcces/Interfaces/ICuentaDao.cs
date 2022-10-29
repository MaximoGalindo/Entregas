using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSLN.DataAcces.Interfaces
{
    public interface ICuentaDao
    {
        DataTable ConsultarDB();
        bool CrearCuenta(Cuenta c);
        public List<Cuenta> CargarCuentaClientes(int dni);
    }
}
