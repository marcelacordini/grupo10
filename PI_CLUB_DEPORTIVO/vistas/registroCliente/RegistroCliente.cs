using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_CLUB_DEPORTIVO.vistas.registroCliente.controles;

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
                ErrorMsgRequiered(optSocio, "Tipo Socio");
                return;
            }
        }

        private void ErrorMsgRequiered(Control control, string field)
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
