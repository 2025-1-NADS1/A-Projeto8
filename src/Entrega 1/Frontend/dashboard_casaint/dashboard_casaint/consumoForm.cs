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

namespace dashboard_casaint
{
    public partial class consumoForm : Form
    {
        public consumoForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chartConsumo_Click(object sender, EventArgs e)
        {
            chartConsumo.Series.Clear(); // Limpa séries anteriores

            var series = new Series("Consumo Mensal (kWh)");
            series.ChartType = SeriesChartType.Line; // Gráfico de linha
            series.BorderWidth = 3;
            series.Color = Color.Green;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;

            // Simulando dados mês a mês
            series.Points.AddXY("Jan", 320);
            series.Points.AddXY("Fev", 290);
            series.Points.AddXY("Mar", 310);
            series.Points.AddXY("Abr", 280);
            series.Points.AddXY("Mai", 300);
            series.Points.AddXY("Jun", 330);
            series.Points.AddXY("Jul", 350);
            series.Points.AddXY("Ago", 340);
            series.Points.AddXY("Set", 310);
            series.Points.AddXY("Out", 300);
            series.Points.AddXY("Nov", 320);
            series.Points.AddXY("Dez", 360);

            chartConsumo.Series.Add(series);

            chartConsumo.ChartAreas[0].AxisY.Title = "Consumo de energia (kWh)";
            chartConsumo.ChartAreas[0].AxisX.Title = "Meses";
            chartConsumo.Titles.Clear();
            chartConsumo.Titles.Add("Consumo de Energia por Mês/2025");
        }
    }
    }
    

