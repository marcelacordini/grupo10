using PI_CLUB_DEPORTIVO.datos;
using PI_CLUB_DEPORTIVO.entidades;
using System;
using System.Windows.Forms;
using PI_CLUB_DEPORTIVO.vistas.baseForm;
using System.Drawing;


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
            {
                if (!int.TryParse(txtClienteID.Text, out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    ClienteDao dao = new ClienteDao();
                    Cliente? cliente = dao.BuscarPorId(idCliente);

                    if (cliente != null)
                    {
                        lblClienteResultado.Text = $"Cliente N° {cliente.Id} - {cliente.Nombre} {cliente.Apellido} - {cliente.TipoCliente}";

                        if (cliente.TipoCliente == "socio")
                        {
                            lblActividad.Text = "Cuota";
                            cmbActividad.Visible = false;
                            lblActividad.Visible = false;
                            dateTimePicker2.Visible = true;
                            lblMonto.Text = "Monto Cuota";


                        }
                        else
                        {
                            cmbActividad.Enabled = true;
                            lblActividad.Visible = true;
                            cmbActividad.Visible = true;
                            lblFechaVto.Visible = false;
                            dateTimePicker2.Visible = false;
                            lblActividad.Text = "Actividad";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❗ Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                ErrorMsgRequiered(txtMonto, "Monto");
                return;
            }

            try
            {
                PagoDao pagoDao = new PagoDao();

                if (lblActividad.Text == "Cuota")
                {
                    bool exito = pagoDao.RegistrarPagoCuota(
                        int.Parse(txtClienteID.Text),
                        dateTimePicker1.Value,
                        dateTimePicker2.Value,
                        decimal.Parse(txtMonto.Text),
                        cmbFormaPago.SelectedItem?.ToString(),
                        cmbPromocion.SelectedItem?.ToString()
                    );

                    if (exito)
                        MessageBox.Show("✅ Pago de cuota registrado correctamente y estado del socio actualizado.");

                    else
                        MessageBox.Show("❌ No se pudo registrar el pago o actualizar el estado.");
                }
                else
                {
                    bool exito = pagoDao.RegistrarPagoActividad(
                        int.Parse(txtClienteID.Text),
                        cmbActividad.SelectedItem?.ToString(),
                        dateTimePicker1.Value,
                        cmbFormaPago.SelectedItem?.ToString()
                    );

                    if (exito)
                        MessageBox.Show("✅ Pago de actividad registrado.");
                    else
                        MessageBox.Show("❌ No se pudo registrar el pago.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❗ Error: ");
            }
        }


        private void ErrorMsgRequiered(Control control, string field)
        {
            MessageBox.Show($"El campo '{field}' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtMonto.Text = "";


                if (cmbFormaPago.Items.Count > 0)
                    cmbFormaPago.SelectedIndex = -1;

                if (cmbPromocion.Items.Count > 0)
                {
                    cmbPromocion.SelectedIndex = -1;
                    cmbPromocion.Enabled = true; // Por si venía de efectivo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❗ Error al limpiar campos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtClienteID.Text = "";
            lblClienteResultado.Text = "";
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.SelectedItem == null)
                return;

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
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(30);
        }

        private void cmbActividad_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
