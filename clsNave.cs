using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEliasFrancisco
{
    internal class clsNave
    {
        public System.Windows.Forms.Timer timerMisil = new System.Windows.Forms.Timer();

        //Lista para almacenar los misiles disparados
        public List<PictureBox> listaMisiles = new List<PictureBox>();

        public void MoverNave(PictureBox nave, KeyEventArgs Tecla, frmGalaga frmGalaga)
        {
            PictureBox pbNave = nave;
            //Condición que utilizo para que la nave haga tope en el costado del formulario
            if (Tecla.KeyCode == Keys.Right && pbNave.Location.X < 550)
            {
                pbNave.Left += 30;
            }
            //Condición que utilizo para que la nave haga tope en el costado del formulario
            else if (Tecla.KeyCode == Keys.Left && pbNave.Location.X > 10)
            {
                pbNave.Left -= 30;
            }
            //Condición para que dispare al presionar espacio
            if (Tecla.KeyCode == Keys.Space)
            {
                Disparo(pbNave, frmGalaga);
            }
        }

        //Creo el Misil que va a disparar la Nave
        public void Disparo(PictureBox pbNave, frmGalaga frmGalaga)
        {
            //Creo una nueva instancia de PictureBox para el misil
            PictureBox pbMisil = new PictureBox();
            pbMisil.Size = new System.Drawing.Size(36, 43);
            pbMisil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMisil.Image = Properties.Resources.MisilSinFondo2;
            pbMisil.BackColor = System.Drawing.Color.Transparent;
            pbMisil.Tag = "Misil";
            pbMisil.Left = pbNave.Left + 40;
            pbMisil.Top = pbNave.Top - 50;
            pbMisil.Visible = true;
            //Añado el control PictureBox al formulario
            frmGalaga.Controls.Add(pbMisil);
            //Agrego el Misil a la Lista
            listaMisiles.Add(pbMisil);
            //Hago que el pictureBox creado este al frente de los otros controles en el formulario y se vea 
            pbMisil.BringToFront();
            timerMisil.Start();
        }
    }
}
