using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_CLUB_DEPORTIVO.util;

namespace PI_CLUB_DEPORTIVO.vistas.registroCliente
{
    public partial class PopUpConfirmacion : Form
    {
        public PopUpConfirmacion(string clienteId, string tipoCliente)
        {
            InitializeComponent();

            lblId.Text = clienteId;
            lblTipoCliente.Text = tipoCliente;
            if (TipoClienteConst.NO_SOCIO.Equals(tipoCliente))
            {
                btnEmitirCarnet.Visible = false;
            }
        }

        public static void MostrarPopUp(string clienteId, string tipoCliente)
        {
            using (PopUpConfirmacion popup = new PopUpConfirmacion(clienteId, tipoCliente))
            {
                popup.ShowDialog();
            }
        }

        public void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmitirCarnet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo carnet...", "Impresión de carnet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
