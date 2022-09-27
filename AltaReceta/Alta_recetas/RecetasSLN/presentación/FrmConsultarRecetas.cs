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
    public partial class FrmConsultarRecetas : Form
    {
        private NewRecetaService ServiceFormulario;


        public FrmConsultarRecetas()
        {
            InitializeComponent();
            ServiceFormulario = new NewRecetaService();
        }

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        public void CargarCombo()
        {
            DataTable tabla = ServiceFormulario.CargarComboRecetas();
            cboTipoReceta.DataSource = tabla;
            cboTipoReceta.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoReceta.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoReceta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoReceta.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboTipoReceta.SelectedItem;

            string Nombre = item.Row.ItemArray[0].ToString();
            string TipoReceta = item.Row.ItemArray[1].ToString();


        }
    }
}
