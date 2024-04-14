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
    public partial class frmGalaga : Form
    {
        //Paso de movimiento
        private const int paso = 5;

        //Obtengo las coordenadas del PictureBox
        int pictureBoxX = 0;
        int pictureBoxY = 0;

        public frmGalaga()
        {
            InitializeComponent();

            //Suscribir al evento KeyDown del formulario
            this.KeyDown += new KeyEventHandler(frmGalaga_KeyDown);
            //Aseguro de que el formulario tenga el foco para recibir eventos de teclado
            this.Focus();
        }

        void Movimiento_Enemigo()
        {
            Random enemigo = new Random();

            int x, y;

            if (pbEnemigo.Top >= 700)
            {
                x = enemigo.Next(0, 420);
                pbEnemigo.Location = new Point(x, 0);
            }
            else 
            {
                pbEnemigo.Top += 15;
            }
        }


        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            //Obtengo los límites del formulario
            int limitLeft = 0;
            int limitRight = this.ClientSize.Width - pbNave.Width;

            //Verifico qué tecla se presionó y mover el PictureBox en consecuencia
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (pbNave.Left - paso >= limitLeft)  //Verifico límite izquierdo
                    {
                        pbNave.Left -= paso;
                    }
                    break;
                case Keys.Right:
                    if (pbNave.Left + paso <= limitRight)  //Verifico límite derecho
                    {
                        pbNave.Left += paso;
                    }
                    break;
            }
        }

        private void timerEnemigo_Tick(object sender, EventArgs e)
        {
            Movimiento_Enemigo();
        }
    }
}
