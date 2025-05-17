using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_CLUB_DEPORTIVO.entidades;
using PI_CLUB_DEPORTIVO.util;
using PI_CLUB_DEPORTIVO.vistas.registroCliente.controles;

namespace PI_CLUB_DEPORTIVO.vistas.registroCliente
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ffNombre.Text)) 
            {
                ErrorMsgRequiered(ffNombre, "Nombre");
                return;
            }

            if (string.IsNullOrEmpty(ffApellido.Text)) 
            {
                ErrorMsgRequiered(ffApellido, "Apellido");
                return;
            }

            if (string.IsNullOrEmpty(ffDni.Text)) 
            {
                ErrorMsgRequiered(ffDni, "DNI");
                return;
            }

            if (!optAPFalse.Checked && !optAPTrue.Checked) 
            {
                ErrorMsgRequiered(optAPTrue, "Apto físico");
                return;
            }

            if (!optSocio.Checked && !optNoSocio.Checked) 
            {
                ErrorMsgRequiered(gbTipoCliente, "Tipo de cliente");
                return;
            }

            string nombre = ffNombre.Text.Trim();
            string apellido = ffApellido.Text.Trim();
            string dni = ffDni.Text.Trim();
            string correo = ffCorreo.Text.Trim();
            string telefono = ffTelefono.Text.Trim();
            string domicilio = ffDomicilio.Text.Trim();
            string fechaAlta = DateTime.Today.ToString("yyyy-mm-dd");
            bool aptoFisico = optAPTrue.Checked;

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                ErrorMsg(ffCorreo, "Por favor, introduzca en correo válido.");
                return;
            }

            if (optSocio.Checked)
            {
                Socio nuevoSocio = new Socio(
                    nombre,
                    apellido,
                    dni,
                    correo,
                    telefono,
                    domicilio,
                    fechaAlta,
                    aptoFisico,
                    EstadoSocioConst.ACTIVO,
                    DateTime.Today.AddDays(30).ToString("yyyy-mm-dd")
                    );

                MostrarMensajeInfo(nuevoSocio.ToString());
                
                PopUpConfirmacion.MostrarPopUp("12345", TipoClienteConst.SOCIO);
                
                LimpiarCampos(sender, e);
            }

            if (optNoSocio.Checked) {
                NoSocio nuevoNoSocio = new NoSocio(
                    nombre,
                    apellido,
                    dni,
                    correo,
                    telefono,
                    domicilio,
                    fechaAlta,
                    aptoFisico
                    );

                MostrarMensajeInfo(nuevoNoSocio.ToString());

                PopUpConfirmacion.MostrarPopUp("12345", TipoClienteConst.NO_SOCIO);

                LimpiarCampos(sender, e);
            }
        }

        private void ErrorMsgRequiered(Control control, string field)
        {
            MessageBox.Show($"El campo '{field}' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void ErrorMsg(Control control, string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void OnlyNumberKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void MostrarMensajeInfo(string mensaje)
        {
            MessageBox.Show(mensaje, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos(object sender, EventArgs e)
        {
            ffNombre.Text = "";
            ffApellido.Text = "";
            ffDni.Text = "";
            ffCorreo.Text = "";
            ffDomicilio.Text = "";
            ffTelefono.Text = "";
            optAPFalse.Checked = false;
            optAPTrue.Checked = false;
            optSocio.Checked = false;
            optNoSocio.Checked = false;
        }
    }
}
