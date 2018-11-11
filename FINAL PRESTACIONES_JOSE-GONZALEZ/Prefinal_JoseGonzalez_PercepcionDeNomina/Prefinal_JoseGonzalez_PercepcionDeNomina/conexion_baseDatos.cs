using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefinal_JoseGonzalez_PercepcionDeNomina
{
    public static class conexion_baseDatos
    {
        static public MySqlConnection conexion;
        static string server = "localhost";
        static string database = "hotelsancarlos";
        static string uid = "root";
        static string password = "root";
        static string cadenaConexion;
        public static void conectar()
        {
            //string server = "localhost";
            //string database = "hotelsancarlos";
            //string uid = "root";
            //string password = "root";
            //string cadenaConexion;
            cadenaConexion = "SERVER=" + server + ";" + "DATABASE=" +
             database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            conexion = new MySqlConnection(cadenaConexion);


        }
        public static DataTable llenarDataGridView(String sentencia)
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sentencia, conexion);
            da.Fill(dt);


            return dt;

        }

        public static bool OpenConnection()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {

            }
            return false;
        }
        public static bool CloseConnection()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                return false;
            }
        }

        public static string dbUser
        {
            get { return uid; }
            set { uid = value; }
        }

        public static string dbPass
        {
            get { return password; }
            set { password = value; }
        }

        public static string dbServer
        {
            get { return server; }
            set { server = value; }
        }

    }
}
