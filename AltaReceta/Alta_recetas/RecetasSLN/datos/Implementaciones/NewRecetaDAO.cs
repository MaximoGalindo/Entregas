using RecetasSLN.datos.Interfaces;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.Implementaciones
{
    class NewRecetaDAO : INewReceta
    {
        public DataTable ConsultarDB(string SP)
        {
            return HelperDAO.ObtenerHelper().ConsultarDB(SP);
        }      

        public int ProximaReceta()
        {
            return HelperDAO.ObtenerHelper().SPconParametroSalida("SP_PROXIMARECETA", "@next");
        }

        public bool CargarMaestroDetalle(Recetas oRecetas)
        {
            if (HelperDAO.ObtenerHelper().CargarMaestroDetalle(oRecetas) == true)
                return true;
            return false;
        }
    }
}
