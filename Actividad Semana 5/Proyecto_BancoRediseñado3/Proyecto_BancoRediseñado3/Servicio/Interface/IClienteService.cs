﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BancoRediseñado3.Servicio.Interface
{
    interface IClienteService
    {
        DataTable CargarListaClientes();
        bool CrearCliente(Cliente c);
    }
}
