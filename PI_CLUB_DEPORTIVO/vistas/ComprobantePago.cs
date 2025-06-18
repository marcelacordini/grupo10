using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_CLUB_DEPORTIVO.vistas.baseForm;

namespace PI_CLUB_DEPORTIVO.vistas
{
    public partial class ComprobantePago : BaseForm
    {
        public ComprobantePago(int ClienteId, string concepto, decimal monto, DateTime fecha, string medioPago)
        {
            InitializeComponent();

            lblSocio.Text = ClienteId.ToString();
            lblConcepto.Text = concepto;
            lblMonto.Text = $"$ {monto:F2}";
            lblFecha.Text = (DateTime.Now).ToString();
            lblMedioPago.Text = medioPago;
            lblComprobante.Text = GenerarNumeroComprobante();
        }

        private string GenerarNumeroComprobante()
        {
            return "CMP-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString($"Comprobante de Pago", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(100, 40));
                ev.Graphics.DrawString($"Socio: {lblSociod.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 80));
                ev.Graphics.DrawString($"Concepto: {lblConcepto.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 110));
                ev.Graphics.DrawString($"Fecha: {lblFecha.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 140));
                ev.Graphics.DrawString($"Monto: {lblMonto.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 170));
                ev.Graphics.DrawString($"Medio de Pago: {lblMedioPago.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 200));
                ev.Graphics.DrawString($"Nro Comprobante: {lblComprobanted.Text}", new Font("Arial", 12), Brushes.Black, new Point(100, 230));
            };

            PrintDialog dialog = new PrintDialog();
            dialog.Document = doc;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
            this.Hide();
        }

    }
}

