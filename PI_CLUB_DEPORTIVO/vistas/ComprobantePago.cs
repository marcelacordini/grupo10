using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_CLUB_DEPORTIVO.vistas.baseForm;
using PI_CLUB_DEPORTIVO.datos;

namespace PI_CLUB_DEPORTIVO.vistas
{
    public partial class ComprobantePago : BaseForm
    {
        private int tipo; // 1 = cuota, 2 = actividad
        
        public ComprobantePago(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.Load += FrmComprobantePago_Load;

            lblSocio.Text = "Socio";
            lblConcepto.Text = "Concepto";
            lblMonto.Text = "Monto";
            lblFecha.Text = (DateTime.Now).ToString();
            lblMedioPago.Text = "medioPago";
            lblComprobante.Text = "Comprobante";
        }

        private void FrmComprobantePago_Load(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 1)
                    CargarUltimoPagoCuota();
                else if (tipo == 2)
                    CargarUltimoPagoActividad();
                else
                    throw new Exception("Tipo de pago inválido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CargarUltimoPagoCuota()
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT concat(cl.id, ' - ',cl.nombre, ' ', cl.apellido) AS nombre_socio,c.monto, c.fechaPago, c.formaPago
                             FROM cuota c
                             INNER JOIN cliente cl ON c.cliente_id = cl.id
                             ORDER BY c.id DESC LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            {
                                lblSocio.Text = reader.GetString("nombre_socio");
                                lblConcepto.Text = "Cuota Mensual";
                                lblMonto.Text = $"$ {reader.GetDouble("monto"):F2}";
                                lblFecha.Text = reader.GetDateTime("fechaPago").ToString("dd/MM/yyyy");
                                lblMedioPago.Text = reader.GetString("formaPago");
                                lblComprobante.Text = GenerarNumeroComprobante();
                            }
                            
                        }
                        else
                            throw new Exception("No hay pagos de cuota registrados.");
                    }
                }
            }
        }

        private void CargarUltimoPagoActividad()
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT concat(cl.id, ' - ',cl.nombre, ' ', cl.apellido) AS nombre_socio, a.nombre AS concepto,
                                    a.precio, p.fechaPago, p.formaPago
                             FROM pagoactividad p
                             INNER JOIN cliente cl ON p.idCliente = cl.id
                             INNER JOIN actividad a ON p.idActividad = a.id
                             ORDER BY p.id DESC LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            {
                                lblSocio.Text = reader.GetString("nombre_socio");
                                lblConcepto.Text = reader.GetString("concepto");
                                lblMonto.Text = $"$ {reader.GetDouble("precio"):F2}";
                                lblFecha.Text = reader.GetDateTime("fechaPago").ToString("dd/MM/yyyy");
                                lblMedioPago.Text = reader.GetString("formaPago");
                                lblComprobante.Text = GenerarNumeroComprobante();
                            }
                        }
                        else
                            throw new Exception("No hay pagos de actividad registrados.");
                    }
                }
            }
        }



        private string GenerarNumeroComprobante()
        {
            return "CMP-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }


        private void MostrarDatosEnPantalla(MySqlDataReader reader)
        {
            lblSocio.Text = reader.GetString("nombre_socio");
            lblConcepto.Text = reader.GetString("concepto");
            lblMonto.Text = $"$ {reader.GetDouble("monto"):F2}";
            lblFecha.Text = reader.GetDateTime("fecha_pago").ToString("dd/MM/yyyy");
            lblMedioPago.Text = reader.GetString("medio_pago");
            lblComprobante.Text = "CMP-" + reader.GetInt32("id").ToString("D6");
        }
        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString($"Comprobante de Pago", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(100, 40));
                ev.Graphics.DrawString($"Socio: {lblSocio.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 80));
                ev.Graphics.DrawString($"Concepto: {lblConcepto.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 110));
                ev.Graphics.DrawString($"Fecha: {lblFecha.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 140));
                ev.Graphics.DrawString($"Monto: {lblMonto.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 170));
                ev.Graphics.DrawString($"Medio de Pago: {lblMedioPago.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 200));
                ev.Graphics.DrawString($"Nro Comprobante: {lblComprobante.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 230));
            };

            PrintDialog dialog = new PrintDialog();
            dialog.Document = doc;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
            this.Hide();
        }

    }
}

