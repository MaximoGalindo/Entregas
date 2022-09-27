using RecetasSLN.datos.Implementaciones;
using RecetasSLN.datos.Interfaces;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicios
{
    class NewRecetaService
    {
        private INewReceta oDAO;

        public NewRecetaService()
        {
            oDAO = new NewRecetaDAO();
        }

        public DataTable CargarComboIngredientes()
        {
            return oDAO.ConsultarDB("SP_CONSULTAR_INGREDIENTES");
        }

        public DataTable CargarComboChef()
        {
            return oDAO.ConsultarDB("SP_CONSULTARCHEF");
        }

        public DataTable CargarComboRecetas()
        {
            return oDAO.ConsultarDB("SP_CONSULTAR_RECETA");
        }

        public int ProximaReceta()
        {
            return oDAO.ProximaReceta();
        }

        public bool ConfirmarReceta(Recetas oReceta)
        {
            if (oDAO.CargarMaestroDetalle(oReceta) == true)
                return true;
            return false;
        }

    }

}
