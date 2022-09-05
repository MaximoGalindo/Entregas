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
    public partial class frmNewCliente : Form
    {
        frmPrincipal formPrincipal;

        DBHelper oBD = new DBHelper();

        public List<Cliente> lClientes = new List<Cliente>();

        
        public frmNewCliente(frmPrincipal principal)
        {
            InitializeComponent();
            formPrincipal = principal;
        }

        private void frmNewCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
            formPrincipal.CargarClientes();
        }
        
        private bool existe(Cliente c)
        {
            for (int i = 0; i < lClientes.Count; i++)
            {
                if (lClientes[i].DNI == c.DNI)
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

        public bool ValidarDatos()
        {
            if (txtDNINuevo.Text == "")
            {
                MessageBox.Show("Debe ingresar un Documento");
                return false;
            }
            try
            {
                int.Parse(txtDNINuevo.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un dato numerico");
                return false;
            }

            if (txtNombreNuevo.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }

            if (txtApellidoNuevo.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPrincipal.Visible = true;
            this.Close();            
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    Cliente c = new Cliente();
                    c.DNI = Convert.ToInt32(txtDNINuevo.Text);
                    c.Nombre = txtNombreNuevo.Text;
                    c.Apellido = txtApellidoNuevo.Text;

                    if (!existe(c))
                    {
                        List<Parametros> lParametros = new List<Parametros>();
                        lParametros.Add(new Parametros("@dni", c.DNI));
                        lParametros.Add(new Parametros("@nombre", c.Nombre));
                        lParametros.Add(new Parametros("@apellido", c.Apellido));

                        if (oBD.Trasacciones("SP_insertCliente", lParametros) > 0)
                        {
                            MessageBox.Show("Cliente registrado");
                            formPrincipal.CargarClientes();
                            CargarClientes();
                            formPrincipal.Visible = true;
                            this.Close();
                            //formPrincipal = new frmPrincipal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El cliente ya existe");
                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("EL cliente no pudo ser registrado");
            }
  
        }

        
    }
}
