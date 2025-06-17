using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using PI_CLUB_DEPORTIVO.datos;
using PI_CLUB_DEPORTIVO.entidades;
using PI_CLUB_DEPORTIVO.util;
using PI_CLUB_DEPORTIVO.vistas.baseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace PI_CLUB_DEPORTIVO.vistas
{
    public partial class RegistrarPago : BaseForm
    {
        public RegistrarPago()

        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string idCliente = txtClienteID.Text;

                using (MySqlConnection con = new MySqlConnection("tu_conexion"))
                {
                    con.Open();
                    string query = "SELECT nombre, apellido, tipo_cliente FROM cliente WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idCliente);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nombre = reader.GetString("nombre");
                        string apellido = reader.GetString("apellido");
                        string tipo = reader.GetString("tipo_cliente");

                        lblClienteResultado.Text = $"Cliente N° {idCliente} - {nombre} {apellido} - {tipo}";

                        if (tipo == "socio")
                        {
                            cmbActividad.Enabled = false;
                        }
                        else
                        {
                            cmbActividad.Enabled = true;
                        }
                    }
                                    
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.");
                    }
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


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("tu_conexion"))
            {
                con.Open();
                
                string query = "INSERT INTO cuota (cliente_id, fecha_vencimiento, fecha,  monto, forma_pago, promocion, estado) " +
                               "VALUES (@cliente_id, @vencimiento, @fecha,  @monto, @forma, @promo, 'pagada')";

                
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cliente_id", txtClienteID.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(txtFecha.Text));
                cmd.Parameters.AddWithValue("@vencimiento", DateTime.Parse(txtVencimiento.Text));
                cmd.Parameters.AddWithValue("@monto", decimal.Parse(txtMonto.Text.Replace("$", "").Trim()));
                cmd.Parameters.AddWithValue("@forma", cmbFormaPago.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@promo", cmbPromocion.SelectedItem.ToString());

                
                string updateEstado = "UPDATE socio SET estado = 'activo' WHERE cliente_id = @id";
                MySqlCommand cmdUpdate = new MySqlCommand(updateEstado, con);
                cmdUpdate.Parameters.AddWithValue("@id", txtClienteID.Text);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Pago registrado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el pago.");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtVencimiento.Text = DateTime.Now.ToShortDateString();
            txtMonto.Text = "";
            cmbFormaPago.SelectedIndex = -1;
            cmbPromocion.SelectedIndex = -1;
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {

            txtClienteID.Text = "";
            lblCliente.Text = "";

        }

        
    }


}
