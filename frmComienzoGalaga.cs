using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEliasFrancisco
{
    public partial class frmComienzoGalaga : Form
    {
        public frmComienzoGalaga()
        {
            InitializeComponent();
            this.AcceptButton = btnComenzar;
        }
        private void txtNombreJugador_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreJugador.Text != "")
            {
                btnComenzar.Enabled = true;
            }
            else
            {
                btnComenzar.Enabled = false;
            }
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            string nombreJugador = txtNombreJugador.Text;


            frmGalaga frmGalaga = new frmGalaga(nombreJugador);
            frmGalaga.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
