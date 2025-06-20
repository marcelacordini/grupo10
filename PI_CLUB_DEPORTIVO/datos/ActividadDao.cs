using MySql.Data.MySqlClient;
using PI_CLUB_DEPORTIVO.entidades;
using System;
using System.Data;

namespace PI_CLUB_DEPORTIVO.datos
{
    internal class ActividadDao
    {
        public Actividad ObtenerActividadPorNombre(string nombreActividad)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                string query = "SELECT id, nombre, precio FROM actividad WHERE nombre = @nombre";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreActividad);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Actividad
                            {
                                Id = reader.GetInt32("id"),
                                Nombre = reader.GetString("nombre"),
                                Precio = reader.GetDouble("precio"),
                                Cupo = reader.GetInt32("id"),
                            };
                        }
                        else
                        {
                            throw new Exception("Actividad no encontrada.");
                        }
                    }
                }
            }
        }
        
        public void DescontarCupo(int idActividad)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "UPDATE actividad SET cupo = cupo - 1 WHERE id = @idActividad AND cupo > 0";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idActividad", idActividad);
                cmd.ExecuteNonQuery();
            }
        }
    }


}