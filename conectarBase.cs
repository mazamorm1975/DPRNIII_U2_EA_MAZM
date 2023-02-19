using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace DPRNIII_U2_A1_MAZM
{
    class conectarBase
    {
        
      

        public static Boolean conectarBaseDatos()
        {
            MySqlDataAdapter buscar;
            try
            {
                string connectionString = "server=localhost; database=dprn3_u2_a1_mazm; user id=root; password=Cu213lona1973;";
                string cadenaConsulta = "SELECT * FROM tb_perfil";

                MySqlConnection connection = new MySqlConnection(connectionString);
                
                    connection.Open();
                    Console.WriteLine("State: {0}", connection.State);
                    Console.WriteLine("connectionString: {0}", connection.ConnectionString);
                    buscar = new MySqlDataAdapter(cadenaConsulta, connection);
                MessageBox.Show("Conexion exitosa con la base de datos = dprn3_u2_a1_mazm ");
                    connection.Close();
                
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

    }
}
