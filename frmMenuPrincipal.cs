using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pryEliasFrancisco
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                string cadenaConexion = "Server = localhost;" + "DataBase = Juego_Rol;" + "Uid = root;" + "Pwd = ;";

                MySqlConnection conexion = new MySqlConnection(cadenaConexion);

                conexion.Open();

                MessageBox.Show("Apertura BD");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Server = localhost;
        //DataBase = Juego_Rol
        //Uid = root
        //pwd = ;         
    }
}
