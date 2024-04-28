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
            objNave.MoverNave(pbNave, e, this, objNave.pbMisil);

            //Verificar si la tecla presionada es Escape (Esc)
            if (e.KeyCode == Keys.Escape)
            {
                //Cerrar el formulario
                this.Close();
                frmComienzoGalaga frmComienzoGalaga = new frmComienzoGalaga();
                frmComienzoGalaga.Show();
            }         
        }

        private void frmGalaga_Load(object sender, EventArgs e)
        {
            lblNombreJugador.Text = "Jugador: " + nombreRecibido;
        }

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            objEnemigos.CrearEnemigos(this);
        }

        private void timerMisil_Tick(object sender, EventArgs e)
        {
            //Recorro la listaMisiles
            foreach (var Misil in objNave.listaMisiles.ToList())
            {
                //Si la variable no es nula se mueve el Misil que se creó y almacenó en la lista
                if (Misil != null)
                {
                    Misil.Top -= 10;

                    //Verifico que se intersecten el misil y el enemigo
                    foreach (var Enemigo in objEnemigos.listaEnemigos.ToList())
                    {
                        if (Misil.Bounds.IntersectsWith(Enemigo.Bounds))
                        {
                            //Si se intersectan los elimino
                            Enemigo.Dispose();
                            //Misil.Dispose();
                            Misil.Top -= 1000;
                           
                            puntaje = puntaje + 1;
                            lblPuntaje.Text = "Puntaje: " + puntaje;

                            //Elimino de la lista a los Misiles y Enemigos que se hayan intersectado
                            objEnemigos.listaEnemigos.Remove(Enemigo);
                            objNave.listaMisiles.Remove(Misil);                       
                        }
                        //Condición para finalizar el juego, si el Enemigo choca con la nave o llega al final del formulario, el jugador pierde el juego 
                        if (pbNave.Bounds.IntersectsWith(Enemigo.Bounds) || Enemigo.Bottom >= this.ClientSize.Height)
                        {
                            objEnemigos.listaEnemigos.Clear();
                            timerEnemigos.Stop();
                            timerMisil.Stop();
                            lblGameOver.Show();
                            lblGameOver.BringToFront();
                            
                            DialogResult resultado = MessageBox.Show(nombreRecibido + " su puntaje fue: " + puntaje + "\n¿Desea volver al menú de juego?", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
        }
    }
}
