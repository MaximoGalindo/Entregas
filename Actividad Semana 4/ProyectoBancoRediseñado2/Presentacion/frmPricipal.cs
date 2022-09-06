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
    public partial class frmPrincipal : Form
    {
        frmInformacion formInformacion;
        frmNewCliente formCliente;
        List<Cliente> lClientes = new List<Cliente>();
        DBHelper oBD = new DBHelper();
       

        public frmPrincipal()
        {
            InitializeComponent();
            formCliente = new frmNewCliente(this);
    
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarClientes();

        }
           

        private bool existe()
        {
            int Documento = Convert.ToInt32(txtDoc.Text);
            for (int i = 0; i < lClientes.Count; i++)
            {
                if (lClientes[i].DNI == Documento)
                {
                    return true;
                }
            }
            return false;
        }

        public void CargarClientes()
        {
            DataTable tabla = oBD.ConsultarBD("SP_lstClientes");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Cliente c = new Cliente();
                c.DNI = Convert.ToInt32(tabla.Rows[i][0]);
                c.Nombre = tabla.Rows[i][1].ToString();
                c.Apellido = tabla.Rows[i][2].ToString();

                lClientes.Add(c);
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            formCliente.Visible = true;
            this.Hide();
        }

        private void btnInicarSesion_Click(object sender, EventArgs e)
        {
            if (existe())
            {                
                formInformacion = new frmInformacion(this,Convert.ToInt32(txtDoc.Text));
                txtDoc.Text = "";
                formInformacion.Visible = true;
                this.Hide();               
            }
            else
            {
                MessageBox.Show("El cliente no esta registrado");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInforme formInforme = new frmInforme();
            formInforme.ShowDialog();
            formInforme.Dispose();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte formReporte = new frmReporte();
            formReporte.ShowDialog();
            formReporte.Dispose();
        }
    }
}
