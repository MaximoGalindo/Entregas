using RecetasSLN.dominio;
using RecetasSLN.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmNuevaReceta : Form
    {
        private NewRecetaService ServiceReceta;
        private Recetas oReceta;

        public FrmNuevaReceta()
        {
            InitializeComponent();
            ServiceReceta = new NewRecetaService();
            oReceta = new Recetas();
        }

        private void FrmNuevaReceta_Load(object sender, EventArgs e)
        {
            CargarCombo(ServiceReceta.CargarComboIngredientes(),cboIngredientes);
            CargarCombo(ServiceReceta.CargarComboChef(),cboChef);
            CargarCombo(ServiceReceta.CargarComboRecetas(),cboTipoReceta);
            CantidadIngredientes();
            ProximaReceta();
           
        }

        public void CargarCombo(DataTable tablaC,ComboBox cbo)
        {
            DataTable tabla = tablaC;
            cbo.DataSource = tabla;
            cbo.DisplayMember = tabla.Columns[1].ColumnName;
            cbo.ValueMember = tabla.Columns[0].ColumnName;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtCantidad.Text = "";
            cboChef.SelectedIndex = -1;
            cboIngredientes.SelectedIndex = -1;
            cboTipoReceta.SelectedIndex = -1;
            dgvNuevaReceta.Rows.Clear();
        }

        public void ProximaReceta()
        {
            int id = ServiceReceta.ProximaReceta();
            lblNumeroReceta.Text = "Receta #: " + id; 
        }

        public void CantidadIngredientes()
        {
            int cantidad = dgvNuevaReceta.Rows.Count;
            lbltotal_ingredientes.Text = "Total de Ingredientes: " + cantidad;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (ValidarDatosIngredientes())
            {
                foreach (DataGridViewRow row in dgvNuevaReceta.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(cboIngredientes.Text))
                    {
                        MessageBox.Show("Ingrediente: " + cboIngredientes.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                DataRowView item = (DataRowView)cboIngredientes.SelectedItem;

                int ingrediente = (int)item.Row.ItemArray[0];
                string Nombre = item.Row.ItemArray[1].ToString();
                string unidad = item.Row.ItemArray[2].ToString();
                Ingredientes i = new Ingredientes(ingrediente, Nombre, unidad);
                int Cantidad = Convert.ToInt32(txtCantidad.Text);

                DetalleReceta detalle = new DetalleReceta(i, Cantidad);
                oReceta.AgregarDetalle(detalle);
                dgvNuevaReceta.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], txtCantidad.Text + " " + item.Row.ItemArray[2] });

                CantidadIngredientes();
            }
        }

        public void GuardarReceta()
        {
            oReceta.Nombre = txtNombre.Text;
            oReceta.TipoReceta = (int)cboTipoReceta.SelectedValue;
            oReceta.Chef = (int)cboChef.SelectedValue;

            if (ServiceReceta.ConfirmarReceta(oReceta))
            {
                MessageBox.Show("Se registro Correctamente la receta", "REGISTRO", MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Ah ocurrido un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
           if(ValidarDatosReceta() == true)
                GuardarReceta();

        }

        public bool ValidarDatosReceta()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre a la receta");
                txtNombre.Focus();
                return false;
            }

            if (cboChef.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Chef a la receta");
                cboChef.Focus();
                return false;
            }

            if (cboTipoReceta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de receta");
                cboTipoReceta.Focus();
                return false;
            }

            if (dgvNuevaReceta.Rows.Count < 2)
            {
                MessageBox.Show("AH olvidado Ingredientes?");
                cboIngredientes.Focus();
                return false;
            }         
            return true;
        }

        public bool ValidarDatosIngredientes()
        {
            if (cboIngredientes.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un ingrediente");
                cboIngredientes.Focus();
                return false;
            }

            if (txtCantidad.Text == "" || int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad valida");
                cboIngredientes.Focus();
                return false;
            }

            return true;
        }
    }
}
