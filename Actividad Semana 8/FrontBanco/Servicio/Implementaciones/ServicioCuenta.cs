using BancoSLN;
using BancoSLN.DataAcces.Implementaciones;
using BancoSLN.DataAcces.Interfaces;
using BancoSLN.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontBanco.Servicio.Implementaciones
{
    public class ServicioCuenta : ICuentaService
    {
        private ICuentaDao oDao;

        public ServicioCuenta()
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
