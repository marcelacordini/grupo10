using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using PI_CLUB_DEPORTIVO.util;


namespace PI_CLUB_DEPORTIVO.vistas.registroCliente
{
    public partial class PopUpConfirmacion : Form
    {
        private readonly string _nombreCliente;

        public PopUpConfirmacion(string clienteId, string tipoCliente, string nombreCliente)
        {
            InitializeComponent();

            lblId.Text = clienteId;
            lblTipoCliente.Text = tipoCliente;
            _nombreCliente = nombreCliente;

            if (TipoClienteConst.NO_SOCIO.Equals(tipoCliente))
            {
                btnEmitirCarnet.Visible = false;
            }
        }
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


        public static void MostrarPopUp(string clienteId, string tipoCliente, string nombreCliente)
        {
            using (PopUpConfirmacion popup = new PopUpConfirmacion(clienteId, tipoCliente, nombreCliente))
            {
                popup.ShowDialog();
            }
        }

        /*
        public static void MostrarPopUp(string clienteId, string tipoCliente)
        {
            using (PopUpConfirmacion popup = new PopUpConfirmacion(clienteId, tipoCliente))
            {
                popup.ShowDialog();
            }
        }
        */

        public void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmitirCarnet_Click(object sender, EventArgs e)

        {
            string clienteId = lblId.Text;
            string tipoCliente = lblTipoCliente.Text;
            string nombreCliente = _nombreCliente;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = $"Carnet_{clienteId}.pdf";
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string rutaArchivo = saveFileDialog.FileName;

            // Tamaño tipo tarjeta (85mm x 54mm)
            iTextSharp.text.Rectangle carnetSize = new iTextSharp.text.Rectangle(242, 153);
            Document doc = new Document(carnetSize, 10, 10, 10, 10);

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Fuentes
                var fontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD);
                var fontCampo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9f);
                var fontCampoBold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9f, iTextSharp.text.Font.BOLD);

                // Logo (Ver con el grupo)
                // string logoPath = @"C:\ruta\al\logo.png"; // CAMBIAR si el grupo quiere poner un logo
                /*if (System.IO.File.Exists(logoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(40f, 40f);
                    logo.Alignment = Element.ALIGN_LEFT;
                    doc.Add(logo);
                }*/

                // Título centrado
                Paragraph titulo = new Paragraph("CLUB DEPORTIVO", fontTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                doc.Add(new Paragraph("\n"));

                // Tabla con datos
                PdfPTable tabla = new PdfPTable(2);
                tabla.WidthPercentage = 100;
                tabla.SetWidths(new float[] { 30f, 70f });

                tabla.AddCell(new PdfPCell(new Phrase("ID:", fontCampoBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                tabla.AddCell(new PdfPCell(new Phrase(clienteId, fontCampo)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

                tabla.AddCell(new PdfPCell(new Phrase("Nombre:", fontCampoBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                tabla.AddCell(new PdfPCell(new Phrase(nombreCliente, fontCampo)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

                tabla.AddCell(new PdfPCell(new Phrase("Tipo:", fontCampoBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                tabla.AddCell(new PdfPCell(new Phrase(tipoCliente, fontCampo)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

                tabla.AddCell(new PdfPCell(new Phrase("Fecha:", fontCampoBold)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                tabla.AddCell(new PdfPCell(new Phrase(DateTime.Now.ToString("dd/MM/yyyy"), fontCampo)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

                doc.Add(tabla);

                doc.Close();

                MessageBox.Show("Carnet generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = rutaArchivo,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el carnet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
