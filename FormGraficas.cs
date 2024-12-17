using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace WinFormsProyectoBase
{
    public partial class FormGraficas : Form
    {
        private bool Modo;
        public FormGraficas()
        {
            InitializeComponent();
        }

        public FormGraficas(bool Modo)
        {
            this.Modo = Modo;
            InitializeComponent();
            Fondo();
            totalVentas();

            AdmonBDUsuario aux = new AdmonBDUsuario();
            List<Usuarios> listaAux = aux.consulta();

            //Listas temporales para los datos
            List<double> montosTemp = new List<double>();
            List<string> nombresTemp = new List<string>();

            //Almacenar en las listas los nombres y montos de usuarios e invitado (excluir al administrador)
            foreach (var usuario in listaAux)
            {
                if (usuario.Categoria != 1)
                {
                    montosTemp.Add(usuario.Monto);
                    nombresTemp.Add(usuario.NombreCompleto);
                }
            }

            //Convertir las listas dinámicas a arreglos
            double[] montos = montosTemp.ToArray();
            string[] nombres = nombresTemp.ToArray();

            //Agregar las barras al gráfico
            var bars = formsPlotGrafica.Plot.AddBar(montos);

            double[] posiciones = new double[nombres.Length]; //Posiciones

            //Asignar al arreglo una posición
            for (int i = 0; i < nombres.Length; i++)
            {
                posiciones[i] = (double)i;
            }

            formsPlotGrafica.Plot.XTicks(positions: posiciones, labels: nombres);   //Agregar las barras al gráfico

            formsPlotGrafica.Plot.XAxis.TickLabelStyle(rotation: 90); //Rotar las etiquetas

            formsPlotGrafica.Plot.XAxis.TickLabelStyle(color: System.Drawing.Color.FromArgb(252, 251, 241));  //Cambiar el color de las etiquetas

            formsPlotGrafica.Plot.YAxis.TickLabelStyle(color: System.Drawing.Color.FromArgb(252, 251, 241)); //Cambiar el color de las etiquetas

            bars.FillColor = System.Drawing.Color.CadetBlue;    //Color de las barras

            bars.FillColor = System.Drawing.Color.CadetBlue;    //Color de las barras

            formsPlotGrafica.Plot.SetAxisLimits(yMin: 0); //Ajustar los márgenes para que no haya espacio debajo de las barras

            formsPlotGrafica.Refresh(); //Se actualiza la gráfica
        }

        public void Fondo()
        {
            if (this.Modo == true)
            {

                //Paneles
                this.panelBase.BackColor = System.Drawing.Color.FromArgb(224, 208, 182);
                this.labelTituloGrafica.ForeColor = Color.FromArgb(252, 251, 241);
                this.labelEjeY.ForeColor = Color.FromArgb(252, 251, 241);
                this.labelEjeX.ForeColor = Color.FromArgb(252, 251, 241);
            }
            else
            {
                //Paneles
                this.panelBase.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
                this.labelTituloGrafica.ForeColor = Color.FromArgb(70, 150, 250);
                this.labelEjeX.ForeColor = Color.FromArgb(70, 150, 250);
                this.labelEjeY.ForeColor = Color.FromArgb(70, 150, 250);
            }
        }

        private void totalVentas()
        {
            string aux = string.Empty;
            AdmonBDUsuario admonBDUsuario = new AdmonBDUsuario();
            List<Usuarios> usuarios = admonBDUsuario.consulta();
            float suma = 0;
            foreach (Usuarios var in usuarios)
                suma += var.Monto;
            aux = Convert.ToString(suma);
            labelSumaVentas.Text = aux;
           
        }
    }
}



