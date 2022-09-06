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
    public partial class frmRetirarDinero : Form
    {   
        frmInformacion formInformacion;

        DBHelper oBD = new DBHelper();

        int Cbu;
        double Saldo;
        int documento;

        public frmRetirarDinero(frmInformacion Informacion,int cbu, double saldo, int dni)
        {
            InitializeComponent();
            Cbu = cbu;
            Saldo = saldo;
            documento = dni;
            formInformacion = Informacion;
        }

        private void frmRetirarDinero_Load(object sender, EventArgs e)
        {

        }

        public bool RetirarDineroCuenta()
        {            
            Cuenta c = new Cuenta();
            c.CBU = Cbu;
            c.Saldo = Convert.ToDouble(txtRetirarDInero.Text);
            c.UltimoMovimiento = DateTime.Now;

            List<Parametros> lParametros = new List<Parametros>();
            lParametros.Add(new Parametros("@cbu", c.CBU));
            lParametros.Add(new Parametros("@saldo", c.Saldo));
            lParametros.Add(new Parametros("@ultMov", c.UltimoMovimiento));

            if (c.Saldo <= Saldo)
            {
                if (oBD.Trasacciones("SP_retirarDinero", lParametros) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
               
        }

        private void btnAceptarEgreso_Click(object sender, EventArgs e)
        {
            if (RetirarDineroCuenta())
            {
                MessageBox.Show("Se retiro correctamente");
                formInformacion.CargarCuentaCliente();
                formInformacion.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("El dinero en la cuenta no es suficiente");
            }
        }

        private void btnCancelarEgreso_Click(object sender, EventArgs e)
        {
            formInformacion.Visible = true;
            this.Close();
        }
    }
}
