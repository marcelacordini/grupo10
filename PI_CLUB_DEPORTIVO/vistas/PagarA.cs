using PI_CLUB_DEPORTIVO.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Reflection;

namespace PI_CLUB_DEPORTIVO.vistas
{
    public partial class PagarA : Form
    {
        public Comprobante doc = new Comprobante();
        public PagarA()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
            this.Hide();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                /*
                --------------------------------------------------------
                -------------------------
                * Consulta simple que proyecta los datos necesarios para rellenar el documento
                * En este caso se trata del comprobante de pago de una actividad
                --------------------------------------------------------
                ------------------------------------ */

                query = "SELECT id, nombreap, CONCAT(nombre, ' ', apellido), c.monto, c.fecha " +
               "FROM cliente cl INNER JOIN cuota c ON cl.id = c.cuota_id " +
               "WHERE cl.id = @idCliente";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idCliente", txtNro.Text);


                query = ("select id, nombreap, concat(nombre, ' ', apellido), c.monto, c.fecha " + 
                         "from cliente cl inner join cuota c on cl.id = c.cuota_id" + 
                         txtNro.Text); // <<<------ usamos el dato ingresado por el usuario
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // usamos la consulta y la conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
                    doc.numero_f = Convert.ToInt32(reader.GetString(0));
                    doc.curso_f = reader.GetString(1);
                    doc.alumno_f = reader.GetString(2);
                    doc.monto_f = (float)Convert.ToDouble(reader.GetString(3));
                    doc.fecha_f = (DateTime)Convert.ToDateTime(reader.GetString(4));
                    if (optEfvo.Checked == true) // Evaluamos que opcion es la seleccionada
                    {
                        doc.forma_f = "Efectivo";
                        /* ---------------------------------
                        * Pago en efvo se descuenta 10%
                        * --------------------------------- */
                        doc.monto_f = (float)(doc.monto_f * 0.90);
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }
                    btnComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número de inscripcion inexistente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }
    }
}




