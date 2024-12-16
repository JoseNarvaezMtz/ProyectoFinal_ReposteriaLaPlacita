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

            AdmonBDUsuario aux = new AdmonBDUsuario();
            List<Usuarios> listaAux = aux.consulta();

            // Listas temporales para los datos
            List<double> montosTemp = new List<double>();
            List<string> nombresTemp = new List<string>();

            // Filtrar los usuarios y llenar las listas
            foreach (var usuario in listaAux)
            {
                if (usuario.Categoria != 1)
                {
                    montosTemp.Add(usuario.Monto);
                    nombresTemp.Add(usuario.NombreCompleto);
                }
            }

            // Convertir las listas dinámicas a arreglos
            double[] montos = montosTemp.ToArray();
            string[] nombres = nombresTemp.ToArray();

            // Agregar las barras al gráfico
            var bars = formsPlotGrafica.Plot.AddBar(montos);

            // Crear un arreglo de posiciones de tipo double
            double[] posiciones = new double[nombres.Length];

            // Rellenar el arreglo con valores usando un bucle for
            for (int i = 0; i < nombres.Length; i++)
            {
                posiciones[i] = (double)i;
            }

            // Agregar las barras al gráfico
            formsPlotGrafica.Plot.XTicks(positions: posiciones, labels: nombres);

            formsPlotGrafica.Plot.XAxis.TickLabelStyle(rotation: 90);
            // Cambiar el color de las etiquetas en el eje X

            formsPlotGrafica.Plot.XAxis.TickLabelStyle(color: System.Drawing.Color.FromArgb(252, 251, 241));

            // Cambiar el color de las etiquetas en el eje Y
            formsPlotGrafica.Plot.YAxis.TickLabelStyle(color: System.Drawing.Color.FromArgb(252, 251, 241));

            bars.FillColor = System.Drawing.Color.CadetBlue;

            // Ajustar los márgenes para que no haya espacio debajo de las barras
            formsPlotGrafica.Plot.SetAxisLimits(yMin: 0);

            // Actualizar la gráfica
            formsPlotGrafica.Refresh();
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
    }
}
