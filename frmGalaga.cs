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
        int puntaje;

        string nombreRecibido;

        private bool gameOverMostrado = false;

        clsNave objNave = new clsNave();
        clsEnemigos objEnemigos = new clsEnemigos();

        private System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerMisil = new System.Windows.Forms.Timer();

        public frmGalaga(string nombreJugadorGalaga)
        {
            InitializeComponent();
            
            //Suscribir al evento KeyDown del formulario
            this.KeyDown += new KeyEventHandler(frmGalaga_KeyDown);
            //Aseguro de que el formulario tenga el foco para recibir eventos de teclado
            this.Focus();

            nombreRecibido = nombreJugadorGalaga;

            lblGameOver.Hide();

            timerEnemigos.Interval = 2000;
            timerEnemigos.Tick += timerEnemigos_Tick;
            timerEnemigos.Start();

            timerMisil.Start();
            timerMisil.Interval = 2;
            timerMisil.Tick += timerMisil_Tick;
        }
             
        //Procedimiento del evento KeyDown(Presionar una tecla) para mover con las flechas la nave y disparar con espacio
        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            objNave.MoverNave(pbNave, e, this);
        }

        private void frmGalaga_Load(object sender, EventArgs e)
        {
            lblNombreJugador.Text = "Jugador: " + nombreRecibido;
        }

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            objEnemigos.Enemigos(this);
        }

        private void timerMisil_Tick(object sender, EventArgs e)
        {
            foreach (var Misil in objNave.listaMisiles.ToList())
            {
                if (Misil != null)
                {
                    Misil.Top -= 10;
                    //Verifico que se intersecten el misil y el enemigo
                    foreach (var Enemigo in objEnemigos.listaEnemigos.ToList())
                    {
                        if (Misil.Bounds.IntersectsWith(Enemigo.Bounds))
                        {
                            //Si hay colisión se oculta el enemigo
                            Enemigo.Visible = false;
                            Misil.Visible = false;
                            puntaje = puntaje + 1;
                            lblPuntaje.Text = "Puntaje: " + puntaje;
                            objEnemigos.listaEnemigos.Remove(Enemigo);
                            objNave.listaMisiles.Remove(Misil);                       
                        }
                        if (pbNave.Bounds.IntersectsWith(Enemigo.Bounds) || Enemigo.Bottom >= this.ClientSize.Height)
                        {
                            objEnemigos.listaEnemigos.Clear();
                            timerEnemigos.Stop();
                            timerMisil.Stop();
                            lblGameOver.Show();
                            lblGameOver.BringToFront();

                            DialogResult resultado = MessageBox.Show(nombreRecibido + " su puntaje fue: " + puntaje + "\n¿Desea volver al menú principal?", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            //Verifico la respuesta del usuario
                            if (resultado == DialogResult.OK)
                            {
                                frmComienzoGalaga frmComienzoGalga = new frmComienzoGalaga();
                                frmComienzoGalga.Show();

                                this.Close();
                            }
                        }
                    }
                }
            }

            /*
            // Verificar colisión de la nave con un enemigo o posición del enemigo
            if (!gameOverMostrado)
            {
                foreach (Control control in Controls)
                {
                    if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "Enemigo")
                    {
                        var Enemigo = (PictureBox)control;
                        if (pbNave.Bounds.IntersectsWith(Enemigo.Bounds) || Enemigo.Bottom >= this.ClientSize.Height)
                        {
                            MostrarGameOver();
                            gameOverMostrado = true;
                            break; // Salir del bucle una vez que se haya mostrado el Game Over
                        }
                    }
                }
            }*/
        }
        /*
        private void MostrarGameOver()
        {
            timerEnemigos.Stop();

            lblGameOver.Show();
            lblGameOver.BringToFront();

            DialogResult resultado = MessageBox.Show(nombreRecibido + " su puntaje fue: " + puntaje + "\n¿Desea volver al menú principal?", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                frmComienzoGalaga frmComienzoGalga = new frmComienzoGalaga();
                frmComienzoGalga.Show();

                // Reiniciar la bandera gameOverMostrado
                gameOverMostrado = false;

                this.Close();
            }
        }*/
    }
}
