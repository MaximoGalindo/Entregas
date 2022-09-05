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
    public partial class frmReporte : Form
    {
        DBHelper oBD = new DBHelper();
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            //cboEstado.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public string estado()
        {
            string estado = "";
            if (rbtA.Checked == true)
                estado = "A";                    
            else if (rbtB.Checked == true)
                estado = "B";
            return estado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            DataTable tabla = oBD.Reporte(estado());           
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",tabla));

            this.reportViewer1.RefreshReport();
        }
    }
}
