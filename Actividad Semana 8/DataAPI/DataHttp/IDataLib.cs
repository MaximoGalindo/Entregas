using BancoSLN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.DataHttp
{
    public interface IDataLib
    {
        List<Cuenta> GetCuentas(int dni);
        bool CrearCuenta(Cuenta cuenta);
        List<Cliente> GetClientes();
    }
}
