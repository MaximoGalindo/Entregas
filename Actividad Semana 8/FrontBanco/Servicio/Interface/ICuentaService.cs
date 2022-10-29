using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSLN.Servicio.Interface
{
    interface ICuentaService
    {
        DataTable CargarCombo();
        bool CrearCuenta(Cuenta c);
    }
}
