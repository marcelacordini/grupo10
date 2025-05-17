using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using PI_CLUB_DEPORTIVO.entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PI_CLUB_DEPORTIVO.datos
{
    internal class ClienteDao
    {
        public string NuevoCliente(Cliente nuevo)
        {
            string? respuestaBD;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                
                

                // Parametros de entrada SP
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = nuevo.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = nuevo.Apellido;
                comando.Parameters.Add("Doc", MySqlDbType.Decimal).Value = nuevo.Dni;
                comando.Parameters.Add("Cor", MySqlDbType.VarChar).Value = nuevo.Correo;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = nuevo.Telefono;
                comando.Parameters.Add("Dom", MySqlDbType.VarChar).Value = nuevo.Domicilio;
                comando.Parameters.Add("FAlta", MySqlDbType.Date).Value = DateTime.Parse(nuevo.FechaAlta);
                comando.Parameters.Add("AFis", MySqlDbType.Bit).Value = nuevo.AptoFisico;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = nuevo.TipoCliente;

                //Parametros de salida SP
                MySqlParameter ParamSalida = new MySqlParameter();
                
                ParamSalida.ParameterName = "rta";
                ParamSalida.MySqlDbType = MySqlDbType.Int32;
                ParamSalida.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParamSalida);

                // Abrimos la conexión
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
    }
}
