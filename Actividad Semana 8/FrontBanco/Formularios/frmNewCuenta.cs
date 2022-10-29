using BancoSLN;
using FrontBanco.Servicio.HTTP;
using FrontBanco.Servicio.Implementaciones;
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
using static System.Net.WebRequestMethods;

namespace BancoSLN
{
    public partial class frmNewCuenta : Form
    {
        frmInformacion formInformacion;

        //Estado estado;

        ServicioCuenta Servicio;
        private Cuenta nueva;
        int doc;

        public frmNewCuenta(frmInformacion Informacion, int dni)
        {
            InitializeComponent();
            formInformacion = Informacion;
            doc = dni;
            Servicio = new ServicioCuenta();
            nueva = new Cuenta();
        }

        private void frmNewCuenta_Load(object sender, EventArgs e)
        {
            CargarCBO();
        }

        private void CargarCBO()
        {
            DataTable tabla = Servicio.CargarCombo() ;
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoCuenta.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCuenta.SelectedIndex = -1;
        }

        private void btnGuardarCuenta_Click(object sender, EventArgs e)
        {
         
            CargarCuenta();

        }

        private async void CargarCuenta()
        {
            nueva.Cliente.DNI = doc;
            nueva.UltimoMovimiento = dtpUltMov.Value;
            nueva.TipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
            nueva.Saldo = Convert.ToInt32(txtSaldo.Text);
            nueva.Estado = "A";

            if(await CargarCuentaAsync(nueva))
            {
                MessageBox.Show("Se registro correctamente la cuenta");                   
                formInformacion.Visible = true;                    
                formInformacion.CargarDGVAsync();                  
                this.Close();
                  
            }
            else
                MessageBox.Show("La cuenta no ah podido ser creada");

        }

        public async Task<bool> CargarCuentaAsync(Cuenta cuenta)
        {
            string url = "https://localhost:7073/cuenta";
            string cuentaJason = JsonConvert.SerializeObject(nueva);
            var data = await ClienteHTTP.GetInstance().PostAsync(url, cuentaJason);
            return data == "true";


        }
    }
}
