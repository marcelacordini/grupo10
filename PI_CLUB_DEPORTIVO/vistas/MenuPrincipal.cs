using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_CLUB_DEPORTIVO.vistas.baseForm;
using PI_CLUB_DEPORTIVO.vistas.registroCliente;

namespace PI_CLUB_DEPORTIVO.vistas
{
    public partial class MenuPrincipal : BaseForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            EstiloTitulo(lblTitle);
            EstiloBotonPrincipal(btnPagarCuotaoActividad);
            EstiloBotonPrincipal(btnRegistrarCliente);
            EstiloBotonPrincipal(btnSociosConCuotaVencida);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            
            login.Show();

            this.Hide();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistroCliente registroClienteForm = new RegistroCliente();

            registroClienteForm.Show();

            this.Hide();
        }

        private void btnPagarCuotaoActividad_Click(object sender, EventArgs e)
        {
            RegistrarPago registrarPagoForm = new RegistrarPago();

            registrarPagoForm.Show();

            this.Hide();
            
        }

        private void btnSociosConCuotaVencida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VENTANA DE SOCIOSCUENTAVENCIDA", "Info", MessageBoxButtons.OK);
        }
    }
}
