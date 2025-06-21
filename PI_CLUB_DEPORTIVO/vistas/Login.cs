using PI_CLUB_DEPORTIVO.datos;
using PI_CLUB_DEPORTIVO.vistas.baseForm;
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
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */

            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */

            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario datosUsuario = new Usuario();
            DataTable resultado = datosUsuario.Log_Usu(txtUsuario.Text.Trim(), txtPass.Text.Trim());

            if (resultado.Rows.Count > 0)
            {
                this.Hide();
                
                MessageBox.Show("Bienvenido " + resultado.Rows[0]["nombre"].ToString());
                
                MenuPrincipal menu = new MenuPrincipal();

                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            EstiloTitulo(label1);
        }
    }
}
