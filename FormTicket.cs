using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Text;

namespace WinFormsProyectoBase
{
    public partial class FormTicket : Form
    {
        private float total;
        public FormTicket()
        {
            InitializeComponent();
        }
        public FormTicket(float total)
        {
            this.total = total;
            InitializeComponent();
            ImprimirDatos();
        }
        private void ImprimirDatos()
        {
            System.Drawing.Font font = new System.Drawing.Font(richTextBoxProductos.Font.FontFamily, 14);
            float iva;
            richTextBoxProductos.Clear();
            richTextBoxCantidad.Clear();
            richTextBoxPrecio.Clear();
            richTextBoxPrecioImp.Clear();
            richTextBoxProductos.Font = font;
            richTextBoxCantidad.Font = font;
            richTextBoxPrecio.Font = font;
            richTextBoxPrecioImp.Font = font;

            foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
            {
                richTextBoxProductos.AppendText(var.producto.Nombre + Environment.NewLine);
                richTextBoxCantidad.AppendText(var.cantidad.ToString() + Environment.NewLine);
                richTextBoxPrecio.AppendText(var.producto.Precio + Environment.NewLine);
                iva = var.costo() * 1.06f;
                richTextBoxPrecioImp.AppendText(iva.ToString() + Environment.NewLine);
                this.total += var.costo() * 1.06f;
            }
            textBoxTotalCompra.Text = this.total.ToString("F2");
        }
        private void buttonDescargar_Click(object sender, EventArgs e)
        {
            //Descarga el documento
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF|*.pdf";
            saveFileDialog.Title = "Guardar Ticket de Compra";
            saveFileDialog.FileName = "TicketCompra.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaSeleccionada = saveFileDialog.FileName;
                //Barrita de descarga
                progressBarDescargarTicket.Minimum = 0;
                progressBarDescargarTicket.Maximum = 100;
                progressBarDescargarTicket.Value = 0;

                //Crea el archivo PFD
                using (FileStream fs = new FileStream(rutaSeleccionada, FileMode.Create))
                {
                    Document doc = new Document(PageSize.LETTER, 12, 12, 15, 15);
                    PdfWriter pw = PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    progressBarDescargarTicket.Value = 20;
                    //Título del documento y autor
                    doc.AddAuthor("Café La Plasita");
                    doc.AddTitle("Ticket de Compra");
                    //Fuente del texto
                    iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font boldFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font slogan = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 18, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    //Logo de la tienda
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "LogoNegro.png"));
                    logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                    logo.ScaleAbsoluteHeight(100);
                    logo.ScaleAbsoluteWidth(100);
                    doc.Add(logo);
                    //Encabezado
                    Paragraph centro = new Paragraph("\"Delicia tras delicia para endulzar tu pancita\"", slogan);
                    centro.Alignment = Element.ALIGN_CENTER;
                    doc.Add(centro);
                    doc.Add(Chunk.NEWLINE);
                    //Añadir hora actual
                    string horaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    doc.Add(new Paragraph("Hora: " + horaActual, standarFont));
                    doc.Add(Chunk.NEWLINE);
                    //Encabezado de las columnas
                    PdfPTable Compra = new PdfPTable(4);
                    Compra.WidthPercentage = 100;
                    //Títulos de la tablita
                    PdfPCell ColumnaProducto = new PdfPCell(new Phrase("Producto", standarFont));
                    ColumnaProducto.BorderWidth = 0;
                    ColumnaProducto.BorderWidthBottom = 0.75f;

                    PdfPCell ColumnaCantidad = new PdfPCell(new Phrase("Cantidad", standarFont));
                    ColumnaCantidad.BorderWidth = 0;
                    ColumnaCantidad.BorderWidthBottom = 0.75f;

                    PdfPCell ColumnaPrecio = new PdfPCell(new Phrase("Precio Individual", standarFont));
                    ColumnaPrecio.BorderWidth = 0;
                    ColumnaPrecio.BorderWidthBottom = 0.75f;

                    PdfPCell ColumnaPrecioImpuestos = new PdfPCell(new Phrase("Precio Total + IMPUESTOS", standarFont));
                    ColumnaPrecioImpuestos.BorderWidth = 0;
                    ColumnaPrecioImpuestos.BorderWidthBottom = 0.75f;
                    //Añadir las celdas
                    Compra.AddCell(ColumnaProducto);
                    Compra.AddCell(ColumnaCantidad);
                    Compra.AddCell(ColumnaPrecio);
                    Compra.AddCell(ColumnaPrecioImpuestos);
                    //Actualizar la barra de descarga
                    for (int i = 0; i < 100; i += 10)
                    {
                        progressBarDescargarTicket.Value = i;
                    }
                    //Agregando Impuestos
                    float IMP;
                    //Mostrando en la tabla
                    foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
                    {
                        //Producto
                        PdfPCell CeldaProducto = new PdfPCell(new Phrase(var.producto.Nombre, standarFont));
                        CeldaProducto.BorderWidth = 0;
                        Compra.AddCell(CeldaProducto);

                        //Cantidad
                        PdfPCell CeldaCantidad = new PdfPCell(new Phrase(var.cantidad.ToString(), standarFont));
                        CeldaCantidad.BorderWidth = 0;
                        Compra.AddCell(CeldaCantidad);
                        //Precio
                        PdfPCell CeldaPrecio = new PdfPCell(new Phrase(var.producto.Precio.ToString("F2"), standarFont));
                        CeldaPrecio.BorderWidth = 0;
                        Compra.AddCell(CeldaPrecio);
                        //Precio + impuestos
                        IMP = var.costo() * 1.06f;
                        PdfPCell CeldaPrecioImpuestos = new PdfPCell(new Phrase(IMP.ToString("F2"), standarFont));
                        CeldaPrecioImpuestos.BorderWidth = 0;
                        Compra.AddCell(CeldaPrecioImpuestos);
                    }
                    doc.Add(Compra);
                    progressBarDescargarTicket.Value = 80;
                    //Añadir total al final
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Paragraph("Total: $" + this.total.ToString("F2"), standarFont));
                    //Cierra el documento
                    doc.Close();
                    pw.Close();
                    progressBarDescargarTicket.Value = 100;
                }
                MessageBox.Show("El ticket se descargó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnSalirUs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

