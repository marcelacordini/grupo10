using MySql.Data.MySqlClient;
using System;
using System.Data;

/*namespace PI_CLUB_DEPORTIVO.datos
{
    internal class PagoActividadDao
    {
        public bool RegistrarPagoActividad(int idCliente, string nombreActividad, DateTime fechaPago, string formaPago)
        {
            bool exito = false;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // 1. Obtener ID y precio de la actividad
                int idActividad = 0;

                string consultaActividad = "SELECT id FROM actividad WHERE nombre = @nombre";
                using (MySqlCommand cmdActividad = new MySqlCommand(consultaActividad, sqlCon))
                {
                    cmdActividad.Parameters.AddWithValue("@nombre", nombreActividad);
                    using (MySqlDataReader reader = cmdActividad.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idActividad = reader.GetInt32("id");
                        }
                        else
                        {
                            throw new Exception("La actividad no existe.");
                        }
                    }
                }

                // 2. Registrar el pago
                using (MySqlTransaction transaccion = sqlCon.BeginTransaction())
                {
                    string insertPago = @"INSERT INTO pagoactividad (idActividad, idCliente, fechaPago, formaPago)
                                          VALUES (@idActividad, @idCliente, @fechaPago, @formaPago)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertPago, sqlCon, transaccion))
                    {
                        cmdInsert.Parameters.AddWithValue("@idActividad", idActividad);
                        cmdInsert.Parameters.AddWithValue("@idCliente", idCliente);
                        cmdInsert.Parameters.AddWithValue("@fechaPago", fechaPago);
                        cmdInsert.Parameters.AddWithValue("@formaPago", formaPago);

                        int filas = cmdInsert.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            transaccion.Commit();
                            exito = true;
                        }
                        else
                        {
                            transaccion.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago de la actividad: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return exito;
        }
    }
}
*/

