using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasColas
{
    public partial class frmPrincipal : Form
    {
        Pilas oPilas = new Pilas();
        Colas oColas = new Colas();
        private int contadoor_Pilas = 0;
        private int contador_Colas = 0;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMasPilas_Click(object sender, EventArgs e)
        {
            oPilas.añadir(contadoor_Pilas);
            contadoor_Pilas++;
            ltsPilas.Items.Add(contadoor_Pilas.ToString());           
        }

        private void btnMenosPilas_Click(object sender, EventArgs e)
        {                
                  
            oPilas.extraer(contadoor_Pilas);
            contadoor_Pilas--;
            ltsPilas.Items.RemoveAt(contadoor_Pilas);           

        }

        private void btnMasColas_Click(object sender, EventArgs e)
        {
            oColas.añadir(contador_Colas);
            contador_Colas++;
            lstColas.Items.Add(contador_Colas.ToString());
        }

        private void btnMenosColas_Click(object sender, EventArgs e)
        {
            contador_Colas--;
            oColas.extraer(contador_Colas);
            lstColas.Items.RemoveAt(0);
        }
    }
}
