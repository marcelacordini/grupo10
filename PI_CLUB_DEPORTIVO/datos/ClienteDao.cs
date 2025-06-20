using System;
using System.Data;
using MySql.Data.MySqlClient;
using PI_CLUB_DEPORTIVO.entidades;

namespace PI_CLUB_DEPORTIVO.datos
{
    internal class ClienteDao
    {
        public string NuevoCliente(Cliente nuevo)
        {
            string respuestaBD;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = nuevo.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = nuevo.Apellido;
                comando.Parameters.Add("Doc", MySqlDbType.Decimal).Value = nuevo.Dni;
                comando.Parameters.Add("Cor", MySqlDbType.VarChar).Value = nuevo.Correo;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = nuevo.Telefono;
                comando.Parameters.Add("Dom", MySqlDbType.VarChar).Value = nuevo.Domicilio;
                comando.Parameters.Add("FAlta", MySqlDbType.Date).Value = DateTime.Parse(nuevo.FechaAlta);
                comando.Parameters.Add("AFis", MySqlDbType.Bit).Value = nuevo.AptoFisico;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = nuevo.TipoCliente;

                // Parametro de salida
                MySqlParameter ParamSalida = new MySqlParameter("rta", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(ParamSalida);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuestaBD = Convert.ToString(ParamSalida.Value);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar crear nuevo cliente: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return respuestaBD;
        }

        public Cliente? BuscarPorId(int idCliente)
        {
            Cliente? clienteEncontrado = null;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "SELECT nombre, apellido, tipoCliente FROM cliente WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clienteEncontrado = new Cliente
                            {
                                Id = idCliente,
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.GetString("apellido"),
                                TipoCliente = reader.GetString("tipoCliente")
                            };
                        }
                    }
                }
            }

            return clienteEncontrado;
        }
    }
    
}