using BancoSLN;
using FrontBanco.Servicio.Implementaciones;
using FrontBanco.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSLN
{
    public partial class frmNewCliente : Form
    {
        frmPrincipal formPrincipal;

        private IClienteService Servicio;                   

        public static List<Cliente> lClientes = new List<Cliente>();

        public frmNewCliente(frmPrincipal principal)
        {
            InitializeComponent(); 
            Servicio = new ServicioCliente();
            formPrincipal = principal;
            
        }

        private void frmNewCliente_Load(object sender, EventArgs e)
        {
            CargarLista();
            formPrincipal.CargarListaAsync();    
        }

        public void CargarLista()
        {
            lClientes = Servicio.CargarLista();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cliente c = new Cliente();
                c.DNI = Convert.ToInt32(txtDNINuevo.Text);
                c.Nombre = txtNombreNuevo.Text;
                c.Apellido = txtApellidoNuevo.Text;

                if (!existe(c))
                {
                    if (Servicio.CrearCliente(c))
                    {
                        MessageBox.Show("Cliente registrado");
                        formPrincipal.CargarListaAsync();
                        CargarLista();
                        formPrincipal.Visible = true;
                        this.Close();
                    }                     
                }
                else
                    MessageBox.Show("Este cliente ya esta registrado");
            }
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
    }
}
