﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsProyectoBase
{
    public partial class FormPagoOxxo : Form
    {
        private float total;
        public FormPagoOxxo()
        {
            InitializeComponent();
            ImprimirDatos();
        }

        private void ImprimirDatos()
        {
            Font font = new Font(richTextBoxProductosSelec.Font.FontFamily, 14);
            float iva;
            richTextBoxProductosSelec.Clear();
            richTextBoxCantidadSelecc.Clear();
            richTextBoxProductosSelec.Font = font;
            richTextBoxCantidadSelecc.Font = font;
            richTextBoxPrecio.Font = font;

            foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
            {
                richTextBoxProductosSelec.AppendText(var.producto.Nombre + Environment.NewLine);
                richTextBoxCantidadSelecc.AppendText(var.cantidad.ToString() + Environment.NewLine);
                iva = var.costo() * 1.06f;
                richTextBoxPrecio.AppendText(iva.ToString() + Environment.NewLine);
                this.total += var.costo() * 1.06f;
            }
            textBoxTotalCompra.Text = this.total.ToString("F2");
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (FormBaseUsuario.productosSeleccionados.Count == 0)
            {
                MessageBox.Show("No hay ningun producto seleccionado!");
                return;
            }
            foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
            {
                if (var.producto.Categoria == 1)
                {
                    FormBaseUsuario.listaPanes[var.indice].Existencias += var.cantidad;
                }
                else
                {
                    FormBaseUsuario.listaPostres[var.indice].Existencias += var.cantidad;
                }
            }
            FormBaseUsuario.productosSeleccionados.Clear();
            MessageBox.Show("Sus productos se han eliminado de la lista correctamente!");
            this.Close();
        }

        private void buttonDescargar_Click_1(object sender, EventArgs e)
        {
            progressBarDescargarTicket.Minimum = 0;
            progressBarDescargarTicket.Maximum = 100;
            progressBarDescargarTicket.Value = 0;
            Bitmap bitmap = new Bitmap(this.Width, 600);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            progressBarDescargarTicket.Value = 50;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Imagen PNG|*.png";
            saveFileDialog.Title = "Descargando Ticket";
            saveFileDialog.FileName = "ticket.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                progressBarDescargarTicket.Value = 100;
                MessageBox.Show("El ticket se descargó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El ticket no se pudo descargar correctamente.");
                progressBarDescargarTicket.Value = 0;
            }
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            AdmonBD admonBD = new AdmonBD();
            AdmonBDUsuario admonBDUsuario = new AdmonBDUsuario();
            Usuarios user = admonBDUsuario.consultaUnRegistro(FormBaseUsuario.account);
            foreach (ClassCompras obj in FormBaseUsuario.productosSeleccionados)
            {
                Productos aux;
                if (obj.producto.Categoria == 1)
                    aux = FormBaseUsuario.listaPanes[obj.indice];
                else
                    aux = FormBaseUsuario.listaPostres[obj.indice];
                admonBD.actualizar(aux.Id, aux.Nombre, aux.Categoria, aux.Descripcion, aux.Imagen, aux.Precio, aux.Existencias);
                user.Monto += obj.costo();
            }
            user.Monto *= 1.06f;
            admonBDUsuario.actualizar(user.Id, user.NombreCompleto, user.Categoria, user.Cuenta, user.Contrasena, user.Monto);
            FormTicket ticket = new FormTicket(this.total);
            ticket.ShowDialog();
            FormBaseUsuario.productosSeleccionados.Clear();
            this.Close();
        }
    }
}
