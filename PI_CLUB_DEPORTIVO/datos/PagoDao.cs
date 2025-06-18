using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PI_CLUB_DEPORTIVO.datos
{
    internal class PagoDao
    {
        public bool RegistrarPagoCuota(int clienteId, DateTime fechaPago, DateTime fechaVencimiento, decimal monto, string formaPago, string promocion)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                MySqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    string insertCuota = @"INSERT INTO cuota 
                        (cliente_id, fechaVencimiento, fechaPago, monto, formaPago, promocion, estado) 
                        VALUES (@cliente_id, @vencimiento, @fecha, @monto, @forma, @promo, 'pagada')";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertCuota, conn, transaccion))
                    {
                        cmdInsert.Parameters.AddWithValue("@cliente_id", clienteId);
                        cmdInsert.Parameters.AddWithValue("@fecha", fechaPago);
                        cmdInsert.Parameters.AddWithValue("@vencimiento", fechaVencimiento);
                        cmdInsert.Parameters.AddWithValue("@monto", monto);
                        cmdInsert.Parameters.AddWithValue("@forma", formaPago);
                        cmdInsert.Parameters.AddWithValue("@promo", promocion);
                        cmdInsert.ExecuteNonQuery();
                    }

                    string updateEstado = @"UPDATE socio 
                        SET estado = 'activo', fechaVencimiento = @vencimiento 
                        WHERE cliente_id = @id";

                    using (MySqlCommand cmdUpdate = new MySqlCommand(updateEstado, conn, transaccion))
                    {
                        cmdUpdate.Parameters.AddWithValue("@id", clienteId);
                        cmdUpdate.Parameters.AddWithValue("@vencimiento", fechaVencimiento);
                        int updated = cmdUpdate.ExecuteNonQuery();

                        if (updated > 0)
                        {
                            transaccion.Commit();
                            return true;
                        }
                        else
                        {
                            transaccion.Rollback();
                            return false;
                        }
                    }
                }
                catch
                {
                    transaccion.Rollback();
                    throw;
                }
            }
        }

        public bool RegistrarPagoActividad(int clienteId, string nombreActividad, DateTime fechaPago, string formaPago)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                MySqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    int idActividad = 0;
                    string queryActividad = "SELECT id FROM actividad WHERE nombre = @nombre";
                    using (MySqlCommand cmdActividad = new MySqlCommand(queryActividad, conn, transaccion))
                    {
                        cmdActividad.Parameters.AddWithValue("@nombre", nombreActividad);
                        using (MySqlDataReader reader = cmdActividad.ExecuteReader())
                        {
                            if (reader.Read())
                                idActividad = reader.GetInt32("id");
                            else
                                throw new Exception("Actividad no encontrada.");
                        }
                    }

                    string insertPago = @"INSERT INTO pagoactividad 
                        (idActividad, idCliente, fechaPago, formaPago) 
                        VALUES (@idActividad, @idCliente, @fechaPago, @formaPago)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertPago, conn, transaccion))
                    {
                        cmdInsert.Parameters.AddWithValue("@idActividad", idActividad);
                        cmdInsert.Parameters.AddWithValue("@idCliente", clienteId);
                        cmdInsert.Parameters.AddWithValue("@fechaPago", fechaPago);
                        cmdInsert.Parameters.AddWithValue("@formaPago", formaPago);

                        int filas = cmdInsert.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            transaccion.Commit();
                            return true;
                        }
                        else
                        {
                            transaccion.Rollback();
                            return false;
                        }
                    }
                }
                catch
                {
                    transaccion.Rollback();
                    throw;
                }
            }
        }
    }
}
