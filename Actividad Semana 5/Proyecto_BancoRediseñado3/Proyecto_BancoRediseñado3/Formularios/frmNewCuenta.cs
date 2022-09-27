using Proyecto_BancoRediseñado3.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BancoRediseñado3
{
    public partial class frmNewCuenta : Form
    {
        frmInformacion formInformacion;

        //Estado estado;
        //GestorCuenta GCuenta;
        private ICuentaService oCuentaService;
    
        int doc;

        public frmNewCuenta(frmInformacion Informacion,int dni)
        {
            InitializeComponent();
            formInformacion = Informacion;
            doc = dni;
            //GCuenta = new GestorCuenta();
            oCuentaService = new ServiceFactoryImplementation().CrearGestorCuenta();
        }

        private void frmNewCuenta_Load(object sender, EventArgs e)
        {
            CargarCBO();
        }

        private void CargarCBO()
        {
            DataTable tabla = oCuentaService.CargarCombo() ;
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoCuenta.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCuenta.SelectedIndex = -1;
        }

        private void btnGuardarCuenta_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta();

            c.Cliente.DNI = doc;
            c.UltimoMovimiento = dtpUltMov.Value;
            c.TipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
            c.Saldo = Convert.ToInt32(txtSaldo.Text);
            c.Estado = "A";

            if (oCuentaService.CrearCuenta(c))
            {
                MessageBox.Show("Se registro correctamente la cuenta");
                formInformacion.Visible = true;
                formInformacion.CargarDGV();
                this.Close();
            }
            else
                MessageBox.Show("La cuenta no ah podido ser creada");

        }

     
    }
}
