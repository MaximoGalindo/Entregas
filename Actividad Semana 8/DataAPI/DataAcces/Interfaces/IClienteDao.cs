using BancoSLN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.DataAcces.Interfaces
{
    public interface IClienteDao
    {
        List<Cliente> ConsultarDB();
        bool CargarCliente(Cliente oCliente);
    }
}
