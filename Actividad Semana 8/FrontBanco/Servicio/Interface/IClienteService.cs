using BancoSLN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontBanco.Servicio.Interface
{
    interface IClienteService
    {
        bool CrearCliente(Cliente oCliente);
        List<Cliente> CargarLista();
    }
}
