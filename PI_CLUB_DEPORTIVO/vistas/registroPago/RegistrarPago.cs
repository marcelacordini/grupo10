﻿using PI_CLUB_DEPORTIVO.datos;
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
            EstiloTitulo(label1);
        }

        private int tipoPagoSeleccionado;
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
                            tipoPagoSeleccionado = 1;


                        }
                        else
                        {
                            lblMonto.Text = "Monto";
                            cmbActividad.Enabled = true;
                            lblActividad.Visible = true;
                            cmbActividad.Visible = true;
                            lblFechaVto.Visible = false;
                            dateTimePicker2.Visible = false;
                            lblActividad.Text = "Actividad";
                            tipoPagoSeleccionado = 2;
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

            if (!float.TryParse(txtMonto.Text, out float monto))
            {
                MessageBox.Show("El monto debe ser un número válido.");
                return;
            }

            if (string.IsNullOrEmpty(cmbFormaPago.Text))
            {
                ErrorMsgRequiered(txtMonto, "Forma de Pago");
                return;
            }

            if (string.IsNullOrEmpty(cmbPromocion.Text))
            {
                ErrorMsgRequiered(txtMonto, "Cantidad de cuotas");
                return;
            }

            try
            {
                PagoDao pagoDao = new PagoDao();

                if (tipoPagoSeleccionado == 1)
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
                    {
                        MessageBox.Show("✅ Pago de cuota registrado correctamente y estado del socio actualizado.");
                        tipoPagoSeleccionado = 1;
                        btnComprobante.Visible = true;
                    }
                    else
                        MessageBox.Show("❌ No se pudo registrar el pago o actualizar el estado.");
                }
                else
                {
                    if (string.IsNullOrEmpty(cmbActividad.Text))
                    {
                        ErrorMsgRequiered(txtMonto, "Actividad");
                        return;
                    }


                    bool exito = pagoDao.RegistrarPagoActividad(
                        int.Parse(txtClienteID.Text),
                        cmbActividad.SelectedItem?.ToString(),
                        dateTimePicker1.Value,
                        cmbFormaPago.SelectedItem?.ToString()
                    );

                    if (exito)
                    {
                        MessageBox.Show("✅ Pago de actividad registrado.");
                        tipoPagoSeleccionado = 2;
                        btnComprobante.Visible = true;
                        int tipo = 1;
                    }
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
            try
            {
                // Obtener el nombre de la actividad seleccionada
                string nombreSeleccionado = cmbActividad.SelectedItem.ToString();

                // Instanciar el DAO
                ActividadDao actividadDao = new ActividadDao();

                // Obtener la actividad desde la base de datos
                Actividad actividad = actividadDao.ObtenerActividadPorNombre(nombreSeleccionado);

                // Chequear cupo
                if (actividad.Cupo > 1)

                {
                    // Mostrar los datos en monto del formulario
                    txtMonto.Text = actividad.Precio.ToString("F2");
                    btnRegistrar.Enabled = true;
                    // Restar cupo
                    actividadDao.DescontarCupo(actividad.Id);
                }
                else
                {
                    MessageBox.Show("Actividad sin cupo seleccione otra opción");
                    btnRegistrar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            ComprobantePago comprobantePagoForm = new ComprobantePago(tipoPagoSeleccionado);

            comprobantePagoForm.Show();

            this.Hide();

        }

        private void RegistrarPago_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BackToMenu(this);
            
        }
    }
}
