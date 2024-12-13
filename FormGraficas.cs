using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsProyectoBase
{
    public partial class FormGraficas : Form
    {
        private bool Modo;
        public FormGraficas()
        {
            InitializeComponent();
            // Crear el control Chart
            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(600, 400); // Ajustar tamaño
            chart.Location = new System.Drawing.Point(10, 10); // Posición

            // Agregar un área de gráfico
            ChartArea chartArea = new ChartArea("Area1");
            chart.ChartAreas.Add(chartArea);

            // Crear una serie de datos
            Series series = new Series("Datos");
            series.ChartType = SeriesChartType.Bar; // Tipo de gráfico (barra)
            series.Points.AddXY("Enero", 10); // (Categoría, Valor)
            series.Points.AddXY("Febrero", 20);
            series.Points.AddXY("Marzo", 30);
            series.Points.AddXY("Abril", 40);

            // Agregar la serie al Chart
            chart.Series.Add(series);

            // Agregar el control al formulario
            this.Controls.Add(chart);
        }
    
        public FormGraficas(bool Modo)
        {
            this.Modo = Modo;
            InitializeComponent();
            Fondo();

        }
        public void Fondo()
        {
            if (this.Modo == true)
            {

                //Paneles
                this.panelBase.BackColor = Color.FromArgb(244, 241, 235);
                this.panel1.BackColor = Color.FromArgb(252, 251, 241);
                this.panel2.BackColor = Color.FromArgb(252, 251, 241);
                this.panel3.BackColor = Color.FromArgb(252, 251, 241);
                this.panel4.BackColor = Color.FromArgb(252, 251, 241);
                this.panel5.BackColor = Color.FromArgb(252, 251, 241);
            }
            else
            {
                //Paneles
                this.panelBase.BackColor = Color.FromArgb(46, 51, 73);
                this.panel1.BackColor = Color.Silver;
                this.panel2.BackColor = Color.Silver;
                this.panel3.BackColor = Color.Silver;
                this.panel4.BackColor = Color.Silver;
                this.panel5.BackColor = Color.Silver;
            }
        }
    }
}
