using PI_CLUB_DEPORTIVO.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PI_CLUB_DEPORTIVO.vistas.baseForm
{
    public partial class BaseForm : Form
    {
        protected Font tituloFont = new Font("Segoe UI", 14, FontStyle.Bold);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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

        public void EstiloTitulo(Label elementoTitulo)
        {
            elementoTitulo.Font = this.tituloFont;
            elementoTitulo.ForeColor = config.PaletaColores.AcentoPrincipal;
            elementoTitulo.Text = elementoTitulo.Text.ToUpper();
            elementoTitulo.TextAlign = ContentAlignment.MiddleCenter; 
        }
        
        public void EstiloBotonPrincipal(Control boton)
        {
            boton.Padding = new Padding(10);
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
