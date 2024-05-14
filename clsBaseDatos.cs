using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace pryEliasFrancisco
{
    internal class clsBaseDatos
    {
        /*
        static void ConectarBD()
        {
            try
            {
                string CadenaConexion = "Server=localhost;Port=3306;Database=juegorol;Uid=root;Password=";

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        public void CargarPuntaje(string Jugador, Int32 Puntaje)
        {
            try
            {
                
                //string CadenaConexion = "Server=localhost;Port=3306;Database=juegorol;Uid=root;Password=";

                //MySqlConnection conexion = new MySqlConnection(CadenaConexion);
                //conexion.Open();
                

                ConectarBD();

                //Query para insertar un dato de texto en la tabla
                string query = "INSERT INTO jugadas (Jugador, Puntaje) VALUES (@Jugador, @Puntaje)";

                using (MySqlCommand command = new MySqlCommand(query, conectar))
                {
                    //Asigno el valor de variables
                    command.Parameters.AddWithValue("@Jugardor", Jugador);
                    command.Parameters.AddWithValue("@Puntaje", Puntaje);

                    //Ejecuto el comando
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/       
    }
}
