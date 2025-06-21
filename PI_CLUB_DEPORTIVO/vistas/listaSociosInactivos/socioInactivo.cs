using MySql.Data.MySqlClient;
using PI_CLUB_DEPORTIVO.datos;
using PI_CLUB_DEPORTIVO.vistas.baseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // Esta línea debe estar aquí, no dentro del método
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_CLUB_DEPORTIVO.vistas.listaSociosInactivos
{
    public partial class socioInactivo : BaseForm
    {

        public socioInactivo()
        {
            InitializeComponent();
            this.Load += new EventHandler(socioInactivo_Load);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoScroll = true;
            // Aplicar estilo del BaseForm
            this.TituloBarra = "Lista de Socios Inactivos";
        }

        private void socioInactivo_Load(object sender, EventArgs e)
        {

            // Cargar la lista de socios inactivos con cuota vencida
            CargarSociosInactivos();

            // ✅ Aplicar estilos del BaseForm
            this.TituloBarra = "SOCIOS INACTIVOS"; // cambia el texto del encabezado superior

            EstiloTitulo(label1);

        }

        // Método para cargar los socios inactivos desde el procedimiento almacenado
        private void CargarSociosInactivos()
        {
            MySqlConnection conn = Conexion.getInstancia().CrearConexion();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("obtener_socios_inactivos_vencidos", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    // 🎨 Estilizar DataGridView
                    dataGridView1.BackgroundColor = Color.FromArgb(64, 71, 100); // mismo fondo que el formulario
                    dataGridView1.GridColor = Color.FromArgb(100, 110, 140);      // color sutil para líneas

                    // Bordes de celdas
                    dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridView1.EnableHeadersVisualStyles = false;

                    // Encabezado
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 45, 70);
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(0);

                    // Celdas
                    dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(64, 71, 100);
                    dataGridView1.DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 100, 200);
                    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

                    // Ajustes visuales adicionales
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.AllowUserToResizeRows = false;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dataGridView1.Refresh();

                    // Altura dinámica (con tope)
                    //int totalHeight = dataGridView1.ColumnHeadersHeight;
                    //foreach (DataGridViewRow row in dataGridView1.Rows)
                    //    totalHeight += row.Height;
                    //int maxHeight = 400;
                    //dataGridView1.Height = Math.Min(totalHeight + 10, maxHeight);

                    //// Ancho dinámico
                    //int totalWidth = dataGridView1.RowHeadersWidth;
                    //foreach (DataGridViewColumn col in dataGridView1.Columns)
                    //    if (col.Visible)
                    //        totalWidth += col.Width;
                    //dataGridView1.Width = totalWidth + 10;
                    //// Centrar horizontalmente el DataGridView en el formulario
                    //dataGridView1.Location = new Point(
                    //    (this.ClientSize.Width - dataGridView1.Width) / 2,
                    //    dataGridView1.Location.Y
                    //);

                }
                else
                {
                    MessageBox.Show("No se encontraron socios inactivos con cuotas vencidas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            BackToMenu(this);
        }
    }
}
