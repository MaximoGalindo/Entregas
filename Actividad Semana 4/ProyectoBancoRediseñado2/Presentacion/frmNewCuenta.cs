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
    public partial class frmNewCuenta : Form
    {
        DBHelper oBD = new DBHelper();
        Cliente cliente = new Cliente();
        int documento;
        frmInformacion formInformacion;

        public frmNewCuenta(frmInformacion Informacion,int dni)
        {
            InitializeComponent();
            documento = dni;
            formInformacion = Informacion;
        }



        private void frmNewCuenta_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        public void CargarCombo()
        {
            DataTable tabla = oBD.ConsultarBD("SP_TipoCuenta");
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoCuenta.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCuenta.SelectedIndex = -1;
        }

        

        public bool ValidarDatos()
        {

            if (cboTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de cuenta");
                return false;
            }

            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Debe ingresar un saldo");
                return false;
            }

            try
            {
                int.Parse(txtSaldo.Text);
            }
            catch
            {
                MessageBox.Show("El valor en saldo no esta permitido");
                return false;
            }
            return true;
        }

       
        private void btnGuardarCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int dni = documento;
                DateTime ultMov = dtpUltMov.Value;
                int tipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
                int saldo = Convert.ToInt32(txtSaldo.Text);
                string estado = "A";

                Cuenta cuenta = new Cuenta(saldo, tipoCuenta, ultMov, dni,estado);
                cliente.AgregarCuenta(cuenta);

                List<Parametros> lParametros = new List<Parametros>();
                lParametros.Add(new Parametros("@saldo", saldo));
                lParametros.Add(new Parametros("@tipoCuenta", tipoCuenta));
                lParametros.Add(new Parametros("@ultMov", ultMov));
                lParametros.Add(new Parametros("@dni", dni));
                lParametros.Add(new Parametros("@estado", estado));

                if (oBD.SPActualizar("SP_insertCuenta", lParametros) > 0)
                {
                    MessageBox.Show("Se registro correctamente la cuenta");
                    formInformacion.Visible = true;                   
                    this.Close();

                    //formInformacion.ShowDialog();
                    //formInformacion.Dispose();

                }
                else
                {
                    MessageBox.Show("La cuenta no ah podido ser creada");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                formInformacion.Visible = true;
                this.Close(); 

                //formInformacion = new frmInformacion(documento);
                //formInformacion.Show();
            }
                
        }

    }
}
