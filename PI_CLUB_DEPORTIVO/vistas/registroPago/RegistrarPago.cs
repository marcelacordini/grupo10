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
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                string idCliente = txtClienteID.Text;
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT nombre, apellido, tipoCliente FROM cliente WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@id", idCliente);
                sqlCon.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nombre = reader.GetString("nombre");
                    string apellido = reader.GetString("apellido");
                    string tipo = reader.GetString("tipoCliente");

                    lblClienteResultado.Text = $"Cliente N° {idCliente} - {nombre} {apellido} - {tipo}";

                    if (tipo == "socio")
                    {
                        cmbActividad.Enabled = false;
                        lblActividad.Text = "Cuota";
                    }
                    else
                    {
                        cmbActividad.Enabled = true;
                        dateTimePicker2.Enabled = false;
                        txtMonto.Enabled = false;
                    }
                }

                else
                {
                    MessageBox.Show("Cliente no encontrado.");
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

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                ErrorMsgRequiered(txtMonto, "Monto");
                return;
            }
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                if (lblActividad.Text == "Cuota")
                {
                    MySqlTransaction transaccion = sqlCon.BeginTransaction();

                    // Armar comando INSERT
                    string insertCuota = @"INSERT INTO cuota 
                                        (cliente_id, fechaVencimiento, fechaPago, monto, formaPago, promocion, estado) 
                                        VALUES (@cliente_id, @vencimiento, @fecha, @monto, @forma, @promo,'pagada')";

                    MySqlCommand cmdInsert = new MySqlCommand(insertCuota, sqlCon, transaccion);

                    cmdInsert.Parameters.AddWithValue("@cliente_id", txtClienteID.Text);
                    cmdInsert.Parameters.AddWithValue("@fecha", dateTimePicker1.Value); // fecha de pago
                    cmdInsert.Parameters.AddWithValue("@vencimiento", dateTimePicker2.Value); // fecha de vencimiento
                    cmdInsert.Parameters.AddWithValue("@monto", decimal.Parse(txtMonto.Text));
                    cmdInsert.Parameters.AddWithValue("@forma", cmbFormaPago.SelectedItem?.ToString());
                    cmdInsert.Parameters.AddWithValue("@promo", cmbPromocion.SelectedItem?.ToString());

                    // DEBUG
                    MessageBox.Show("Ejecutando inserción de cuota...");

                    int filasInsertadas = cmdInsert.ExecuteNonQuery();

                    // UPDATE estado socio
                    string updateEstado = @"UPDATE socio 
                            SET estado = 'activo', fechaVencimiento = @vencimiento 
                            WHERE cliente_id = @id";
                    MySqlCommand cmdUpdate = new MySqlCommand(updateEstado, sqlCon, transaccion);
                    cmdUpdate.Parameters.AddWithValue("@id", txtClienteID.Text);
                    cmdUpdate.Parameters.AddWithValue("@vencimiento", dateTimePicker2.Value);

                    // DEBUG
                    MessageBox.Show("Actualizando estado del socio...");

                    int filasActualizadas = cmdUpdate.ExecuteNonQuery();

                    // Confirmar transacción
                    if (filasInsertadas > 0 && filasActualizadas > 0)
                    {
                        transaccion.Commit();
                        MessageBox.Show("✅ Pago de cuota registrado y estado actualizado correctamente.");
                    }
                    else
                    {
                        transaccion.Rollback();
                        MessageBox.Show("❌ No se pudo registrar el pago o actualizar el estado del socio.");
                    }
                }
                else
                {
                    // PAGAR ACTIVIDAD 

                    // Busco ID de Actividad
                    string nombre = cmbActividad.SelectedItem.ToString();
                    string query = "SELECT id, precio FROM actividad WHERE nombre = @nombre";
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int idActividad = 0;
                    double precio = 0.0;

                    if (reader.Read())
                    {
                        idActividad = reader.GetInt32("id");
                        precio = reader.GetDouble(reader.GetOrdinal("precio"));
                        txtMonto.Text = precio.ToString("0.00");

                    }
                    reader.Close(); // 


                    MySqlTransaction transaccion = sqlCon.BeginTransaction();

                    // Armar comando INSERT
                    string insertCuota = @"INSERT INTO pagoactividad (idActividad, idCliente, fechaPago, formaPago)  
                                         VALUES (@idActividad, @cliente_id, @fecha, @forma)";

                    MySqlCommand cmdInsert = new MySqlCommand(insertCuota, sqlCon, transaccion);
                    cmdInsert.Parameters.AddWithValue("@idActividad", idActividad);
                    cmdInsert.Parameters.AddWithValue("@cliente_id", txtClienteID.Text);
                    cmdInsert.Parameters.AddWithValue("@fecha", dateTimePicker1.Value); // fecha de pago
                    cmdInsert.Parameters.AddWithValue("@forma", cmbFormaPago.SelectedItem.ToString());


                    // DEBUG
                    MessageBox.Show("Ejecutando inserción de pago...");

                    int filasInsertadas = cmdInsert.ExecuteNonQuery();

                    // Confirmar transacción
                    if (filasInsertadas > 0)
                    {
                        transaccion.Commit();
                        MessageBox.Show("✅ Pago de actividad registrado.");
                    }
                    else
                    {
                        transaccion.Rollback();
                        MessageBox.Show("❌ No se pudo registrar el pago.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❗ ERROR: {ex.Message}\n{ex.StackTrace}", "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
            //dateTimePicker2.Value = DateTime.Today.AddDays(30);
            txtMonto.Text = "";
            cmbFormaPago.SelectedIndex = -1;
            cmbPromocion.SelectedIndex = -1;
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {

            txtClienteID.Text = "";
            lblClienteResultado.Text = "";

        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = cmbFormaPago.SelectedItem.ToString();
            if (selectedText == "Efectivo")
            {
                cmbPromocion.Text = "1";
                cmbPromocion.Enabled = false;
            }
            else
            {
                cmbPromocion.Enabled = true;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            dateTimePicker2.Value = fechaSeleccionada.AddDays(30);
        }

        private void txtVencimiento_TextChanged(object sender, EventArgs e)
        {

        }
        private void ErrorMsgRequiered(Control control, string field)
        {
            MessageBox.Show($"El campo '{field}' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value.AddDays(30);
        }

        private void cmbActividad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMonto.Enabled = true;
        }
    }

}
