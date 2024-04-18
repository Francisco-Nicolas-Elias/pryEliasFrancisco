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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void galagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComienzoGalaga frmComienzoGalaga = new frmComienzoGalaga();
            frmComienzoGalaga.Show();
            this.Hide();
        }
    }
}
