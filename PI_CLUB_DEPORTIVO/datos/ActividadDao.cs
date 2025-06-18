using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PI_CLUB_DEPORTIVO.datos
{
    internal class ActividadDao
    {
        public (int idActividad, double precio) ObtenerActividadPorNombre(string nombreActividad)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();

                string query = "SELECT id, precio FROM actividad WHERE nombre = @nombre";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreActividad);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            double precio = reader.GetDouble("precio");
                            return (id, precio);
                        }
                        else
                        {
                            throw new Exception("⚠ No se encontró una actividad con ese nombre.");
                        }
                    }
                }
            }
        }
    }
}
