using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.datos
{
    internal class Conexion
    {
    
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() 
        {
            this.baseDatos = "proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "root";
        }


        public MySqlConnection CrearConexion()
        {

            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }

            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null) 
            {
                con = new Conexion(); 
            }
            return con;
        }

    }
}
