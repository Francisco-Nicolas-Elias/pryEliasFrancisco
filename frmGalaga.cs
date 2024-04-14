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

        //Función para mover la nave con las flechas 
        void Mover_Con_Flechas()
        {
            //Si la bandera es true ingresa 
            if (derecha == true)
            {
                //Condición que utilizo para que la nave haga tope en el costado del formulario
                if (pbNave.Left < 550)
                {
                    pbNave.Left += 30;
                }
            }

            if (izquierda == true)
            {
                //Condición que utilizo para que la nave haga tope en el costado del formulario
                if (pbNave.Left > 10)
                {
                    pbNave.Left -= 30;
                }
            }
        }

        //Función para el movimiento del enemigo
        void Movimiento_Enemigo()
        {
            //Creo una instancia de la clase random para generar números aleatorios donde saldrán los enemigos 
            Random enemigo = new Random();

            //Variables para almacenar los posiciones aleatorias donde se moverán los enemigos 
            int posicionUno, posicionDos;

            if (pbEnemigo.Top >= 700)
            {
                //Asigno a posicionUno el número aleatorio(Que representa la nueva posición horizontal del enemigo)
                posicionUno = enemigo.Next(0, 584);
                pbEnemigo.Location = new Point(posicionUno, 0);
            }
            if (pbEnemigoDos.Top >= 500)
            {
                //Asigno a posicionDos el número aleatorio(Que representa la nueva posición horizontal del segundo enemigo)
                posicionDos = enemigo.Next(0, 584);
                pbEnemigoDos .Location = new Point(posicionDos, 0);
            }
            else 
            {
                //Incremento la posición vertical
                pbEnemigo.Top += 30;
                pbEnemigoDos.Top += 20;
            }
        }
        
        //Función para crear el pictureBox que contiene el Misil
        void Agregar_Misil()
        {
            PictureBox pbMisil = new PictureBox();
            pbMisil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMisil.Image = Properties.Resources.misil;
            pbMisil.BackColor = System.Drawing.Color.Transparent;
            pbMisil.Tag = "Misil";
            pbMisil.Left = pbNave.Left + 8;
            pbMisil.Top = pbNave.Top - 50;
            //Añado el control PictureBox al formulario
            this.Controls.Add(pbMisil);
            //Hago que el pictureBox creado este al frente de los otros controles en el formulario y se vea 
            pbMisil.BringToFront();
        }

        //Función para el movimiento del misil 
        void Movimiento_Misil()
        {
            //Con este bucle foreach recorro todos los controles que estan contenidos en esto formulario 
            foreach (Control controlActual in this.Controls)
            {
                //En esta condición ingresa si el control es un pictureBox y su propiedad Tag es "Misil", la cual le asigne al pictureBox del Misil 
                if (controlActual is PictureBox && controlActual.Tag == "Misil")
                {
                    //Si el control es el pictureBox hago que se mueva
                    controlActual.Top -= 30;
                    if(controlActual.Top < 10)
                    {
                        this.Controls.Remove(controlActual);
                    }
                }
            }
        }
        
        //Función en la cual si se intersectan los pictureBox del misil y enemigo desaparece el enemigo
        void Resultado_Juego()
        {
            //Con este bucle foreach recorro todos los controles que estan contenidos en esto formulario 
            foreach (Control misil in this.Controls)
            {
                //Con este bucle foreach recorro todos los controles que estan contenidos en esto formulario 
                foreach (Control enemigo in this.Controls)
                {
                    //En esta condición ingresa si el control es un pictureBox y su propiedad Tag es "Misil", la cual le asigne al pictureBox del Misil
                    if (misil is PictureBox && misil.Tag == "Misil")
                    {
                        //En esta condición ingresa si el control es un pictureBox y su propiedad Tag es "Enemigo", la cual le asigne a los pictureBox de los Enemigos
                        if (enemigo is PictureBox && enemigo.Tag == "Enemigo")
                        {
                            //Si los límites de los dos pictureBox se intersectan significa que colisionan, entonces ingresa 
                            if (misil.Bounds.IntersectsWith(enemigo.Bounds))
                            {
                                //Muevo al enemigo hacia arriba simulando la muerte del mismo 
                                enemigo.Top -= 1000;
                                
                                //Incremento un punto en el puntaje del jugador
                                puntaje = puntaje + 1;

                                //Muestro en un label el puntaje 
                                lblPuntaje.Text = "Puntaje: " + puntaje;
                            }
                        }
                    }
                }
            }
            //Si la nave choca con alguno de los enemigos ingresa y hago que finalice el juego 
            if(pbNave.Bounds.IntersectsWith(pbEnemigoDos.Bounds) || pbNave.Bounds.IntersectsWith(pbEnemigo.Bounds) || pbEnemigo.Bottom >= this.ClientSize.Height)
            {
                timerNave.Stop();
                timerEnemigo.Stop();
                timerMisil.Stop();
                lblGameOver.Show();
                lblGameOver.BringToFront();

                DialogResult resultado = MessageBox.Show("Su puntaje fue: " + puntaje + "\n¿Desea volver al menú principal?", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Verifico la respuesta del usuario
                if (resultado == DialogResult.OK)
                {
                    frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                    frmMenuPrincipal.Show();

                    this.Close();
                }
            }
        }

        //Procedimiento del evento KeyDown(Presionar una tecla) para mover con las flechas la nave y disparar con espacio
        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            //Si presiona la flecha derecha pongo la bandera en true para poder generar el movimiento que cree en la función Mover_Con_Flechas
            if (e.KeyCode == Keys.Right)
            {
                derecha = true;
            }

            //Si presiona la flecha izquierda pongo la bandera en true para poder generar el movimiento que cree en la función Mover_Con_Flechas
            if (e.KeyCode == Keys.Left)
            {
                izquierda = true;
            }

            //Si presiona el espacio pongo la bandera en true para poder generar el movimiento que cree en la función Movimiento_Misil
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

        //Procedimiento del evento KeyUp(Cuando se suelta la tecla) cambio las banderas a false para que no dispare ni se mueva la nave sola 
        private void frmGalaga_KeyUp(object sender, KeyEventArgs e)
        {
            //Cuando se sueltan las teclas cambio las banderas a false para detener las acciones que realizan dichas teclas
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
