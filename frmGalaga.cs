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
        bool derecha, izquierda, espacio;

        int puntaje;

        public frmGalaga()
        {
            InitializeComponent();
            
            //Suscribir al evento KeyDown del formulario
            this.KeyDown += new KeyEventHandler(frmGalaga_KeyDown);
            //Aseguro de que el formulario tenga el foco para recibir eventos de teclado
            this.Focus();

            lblGameOver.Hide();
            
        }

        void Mover_Con_Flechas()
        {
            if (derecha == true)
            {
                if (pbNave.Left < 550)
                {
                    pbNave.Left += 30;
                }
            }

            if (izquierda == true)
            {
                if (pbNave.Left > 10)
                {
                    pbNave.Left -= 30;
                }
            }
        }

        void Movimiento_Enemigo()
        {
            Random enemigo = new Random();

            int x, y;

            if (pbEnemigo.Top >= 700)
            {
                x = enemigo.Next(0, 584);
                pbEnemigo.Location = new Point(x, 0);
            }
            if (pbEnemigoDos.Top >= 500)
            {
                y = enemigo.Next(0, 584);
                pbEnemigoDos .Location = new Point(y, 0);
            }
            else 
            {
                pbEnemigo.Top += 15;
                pbEnemigoDos.Top += 10;
            }
        }
        
        void Agregar_Misil()
        {
            PictureBox pbMisil = new PictureBox();
            pbMisil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMisil.Image = Properties.Resources.misil;
            pbMisil.BackColor = System.Drawing.Color.Transparent;
            pbMisil.Tag = "Misil";
            pbMisil.Left = pbNave.Left + 8;
            pbMisil.Top = pbNave.Top - 50;
            this.Controls.Add(pbMisil);
            pbMisil.BringToFront();
        }

        void Movimiento_Misil()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Misil")
                {
                    x.Top -= 20;
                    if(x.Top < 10)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }
        
        void Resultado_Juego()
        {
            foreach (Control misil in this.Controls)
            {
                foreach (Control enemigo in this.Controls)
                {
                    if(misil is PictureBox && misil.Tag == "Misil")
                    {
                        if (enemigo is PictureBox && enemigo.Tag == "Enemigo")
                        {
                            if (misil.Bounds.IntersectsWith(enemigo.Bounds))
                            {
                                enemigo.Top -= 1000;

                                puntaje = puntaje + 1;

                                lblPuntaje.Text = "Puntaje: " + puntaje;
                            }
                        }
                    }
                }
            }
            if(pbNave.Bounds.IntersectsWith(pbEnemigoDos.Bounds) || pbNave.Bounds.IntersectsWith(pbEnemigo.Bounds))
            {
                timerNave.Stop();
                timerEnemigo.Stop();
                timerMisil.Stop();
                lblGameOver.Show();
                lblGameOver.BringToFront();

                DialogResult resultado = MessageBox.Show("Su puntaje fue: " + puntaje + "\n¿Desea volver al menú principal?", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (resultado == DialogResult.OK)
                {
                    frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                    frmMenuPrincipal.Show();

                    this.Close();
                }
            }
        }

        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                derecha = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                izquierda = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                espacio = true;
                Agregar_Misil();
            }
        }

        private void timerEnemigo_Tick(object sender, EventArgs e)
        {
            Movimiento_Enemigo();
            Resultado_Juego();
        }

        private void timerNave_Tick(object sender, EventArgs e)
        {
            Mover_Con_Flechas();          
        }

        private void frmGalaga_Load(object sender, EventArgs e)
        {
           
        }

        private void timerMisil_Tick(object sender, EventArgs e)
        {
            Movimiento_Misil();
        }

        private void frmGalaga_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                derecha = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                izquierda = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                espacio = false;
            }
        }
    }
}
