using BancoSLN;
using FrontBanco.Servicio.HTTP;
using FrontBanco.Servicio.Implementaciones;
using FrontBanco.Servicio.Interface;
using Newtonsoft.Json;
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
    public partial class frmPrincipal : Form
    {
        frmInformacion formInformacion;
        frmNewCliente formCliente;

        IClienteService ServicioCliente;

        public static List<Cliente> lClientes;

        public frmPrincipal()
        {
            InitializeComponent();
            formCliente = new frmNewCliente(this);
            ServicioCliente = new ServicioCliente();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarListaAsync();
            
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

        public async Task CargarListaAsync()
        {
            string url = "https://localhost:7073/api/Cliente";
            string data = await ClienteHTTP.GetInstance().GetAsync(url);
            lClientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
        }

        private void btnInicarSesion_Click(object sender, EventArgs e)
        {
            if (existe())
            {
                formInformacion = new frmInformacion(this, Convert.ToInt32(txtDoc.Text));
                txtDoc.Text = "";
                formInformacion.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("El cliente no esta registrado");
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            formCliente.Visible = true;
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
