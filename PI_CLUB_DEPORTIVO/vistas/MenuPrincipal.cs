using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_CLUB_DEPORTIVO.vistas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VENTANA DE REGISTRO", "Info", MessageBoxButtons.OK);
        }

        private void btnPagarCuotaoActividad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VENTANA DE PAGO", "Info", MessageBoxButtons.OK);
        }

        private void btnSociosConCuotaVencida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VENTANA DE SOCIOSCUENTAVENCIDA", "Info", MessageBoxButtons.OK);
        }
    }
}
