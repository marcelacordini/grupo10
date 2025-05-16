using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_CLUB_DEPORTIVO.vistas.registroCliente
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtCorreo.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            optAPFalse.Checked = false;
            optAPTrue.Checked = false;
            optSocio.Checked = false;
            optNoSocio.Checked = false;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                ErrorMessageBoxRequiered(txtNombre, "Nombre");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                ErrorMessageBoxRequiered(txtApellido, "Apellido");
                return;
            }

            if (string.IsNullOrEmpty(txtDni.Text))
            {
                ErrorMessageBoxRequiered(txtDni, "DNI");
                return;
            }

            if(!optAPFalse.Checked && !optAPTrue.Checked)
            {
                ErrorMessageBoxRequiered(optAPTrue, "Apto físico");
                return;
            }

            if(!optSocio.Checked && ! optNoSocio.Checked)
            {
                ErrorMessageBoxRequiered(optSocio, "Tipo Socio");
                return;
            }
        }

        private void ErrorMessageBoxRequiered(Control control, string field)
        {
            MessageBox.Show($"El campo '{field}' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void onlyNumberKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
