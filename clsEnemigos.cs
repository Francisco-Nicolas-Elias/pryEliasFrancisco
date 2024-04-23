using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEliasFrancisco
{
    internal class clsEnemigos
    {
        public System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();

        //Lista para almacenar los enemigos generados
        public List<PictureBox> listaEnemigos = new List<PictureBox>();

        public clsEnemigos()
        {
            timerEnemigos.Interval = 20; // Puedes ajustar el intervalo según la velocidad deseada
            timerEnemigos.Tick += timerEnemigos_Tick;
        }

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            foreach (var pctEnemigo in listaEnemigos)
            {
                if (pctEnemigo != null)
                {
                    pctEnemigo.Top += 4;
                }
            }
        }

        public void CrearEnemigos(frmGalaga frmGalaga)
        {
            PictureBox pbEnemigo = new PictureBox();
            Random random = new Random();
            int posicionX = random.Next(0, 600);

            pbEnemigo.Image = pryEliasFrancisco.Properties.Resources.EnemigoNuevo;
            pbEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnemigo.Tag = "Enemigo";
            pbEnemigo.BackColor = Color.Transparent;
            pbEnemigo.Location = new Point(posicionX, 0);
            pbEnemigo.Visible = true;
            //Añado el control PictureBox al formulario
            frmGalaga.Controls.Add(pbEnemigo);
            //Agrego el Enemigo a la Lista
            listaEnemigos.Add(pbEnemigo); 
            pbEnemigo.BringToFront();

            timerEnemigos.Start();
        }
    }
}
