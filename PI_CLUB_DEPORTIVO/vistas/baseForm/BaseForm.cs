using PI_CLUB_DEPORTIVO.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PI_CLUB_DEPORTIVO.vistas.baseForm
{
    public partial class BaseForm : Form
    {
        protected Font tituloFont = new Font("Segoe UI", 12, FontStyle.Bold);

        public BaseForm()
        {
            InitializeComponent();
            InitUI();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        public void BackToMenu(Form currentForm)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            currentForm.Close();
        }

        /// <summary>
        /// Método para la carga de un icono
        /// </summary>
        /// <param name="control">Elemento a la que se le asignará el icono</param>
        /// <param name="iconCode">Código de Material Icon</param>
        /// <param name="size">Opcional, por defecto es 20</param>
        public void LoadIcon(Control control, string iconCode, float size = 20)
        {
            FontLoader.LoadFonts();

            control.Font = FontLoader.GetIconFont(size);
            control.Text = iconCode;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string TituloBarra
        {
            get => lblTituloHeader.Text;
            set => lblTituloHeader.Text = value;
        }



        private void InitUI()
        {
            LoadIcon(btnClose, "\ue5cd", 20);
            this.BackColor = config.PaletaColores.FondoPrincipal;
            this.panel.BackColor = config.PaletaColores.BarraSuperior;
            this.panel.Dock = DockStyle.Top;
        }

        public void EstiloTitulo(Control elementoTitulo)
        {
            elementoTitulo.Font = this.tituloFont;
            elementoTitulo.ForeColor = config.PaletaColores.AcentoPrincipal;
            elementoTitulo.Text = elementoTitulo.Text.ToUpper();
        }
    }
}
