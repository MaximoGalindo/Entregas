using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_BancoRediseñado3.Servicio.Interface;
using Proyecto_BancoRediseñado3.DataAcces.Implementaciones;
using Proyecto_BancoRediseñado3.DataAcces.Interfaces;

namespace Proyecto_BancoRediseñado3
{
    class GestorCuenta : ICuentaService
    {
        private ICuentaDao oDao;

        public GestorCuenta()
        {
            oDao = new CuentaDao();
        }

        public DataTable CargarCombo()
        {
            return oDao.ConsultarDB();
        }

        public bool CrearCuenta(Cuenta c)
        {
            return oDao.CrearCuenta(c);
        }

    }
}
