using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.Interfaces
{
    interface INewReceta
    {
        DataTable ConsultarDB(string SP);
        int ProximaReceta();
        bool CargarMaestroDetalle(Recetas oReceta);
    }
}
