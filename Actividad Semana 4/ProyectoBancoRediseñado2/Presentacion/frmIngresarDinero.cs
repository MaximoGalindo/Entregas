using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBancoRediseñado2
{
    public partial class frmIngresarDinero : Form
    {
        frmInformacion formInformacion;

        DBHelper oBD = new DBHelper();

        int Cbu;
        int documento;

        public frmIngresarDinero(frmInformacion Informacion,int cbu,int dni)
        {
            InitializeComponent();
            Cbu = cbu;
            documento = dni;
            formInformacion = Informacion;      
        }

        private void frmIngresarDinero_Load(object sender, EventArgs e)
        {

        }

        public bool IngresarDineroCuenta()
        {
            Cuenta c = new Cuenta();
            c.CBU = Cbu;
            c.Saldo = Convert.ToDouble(txtIngresoDinero.Text);
            c.UltimoMovimiento = DateTime.Now;

            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@cbu", c.CBU));
            lParametros.Add(new Parametros("@saldo", c.Saldo));
            lParametros.Add(new Parametros("@ultMov", c.UltimoMovimiento));

            if (oBD.Trasacciones("SP_ingresarDinero", lParametros) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAceptarIngreso_Click(object sender, EventArgs e)
        {
            if (IngresarDineroCuenta())
            {
                MessageBox.Show("Se ingreso correctamente");
                formInformacion.CargarCuentaCliente();
                formInformacion.Visible = true;
                this.Close();
            }
        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            formInformacion.Visible = true;
            this.Close();
        }
    }
}
