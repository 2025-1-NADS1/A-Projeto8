using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeSensores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLerSensores_Click(object sender, EventArgs e)
        {
            // Simular a leitura dos sensores com seus IDs e tipos de leitura
            Random random = new Random();

            // Sensor 1 (Quarto 1)
            int tempSensor1 = random.Next(18, 26);
            int umidSensor1 = random.Next(40, 70);
            int movSensor1 = random.Next(0, 2);

            // Sensor 2 (Quarto 2)
            int tempSensor2 = random.Next(19, 27);
            int umidSensor2 = random.Next(45, 75);
            int movSensor2 = random.Next(0, 2);

            // Sensor 3 (Sala)
            int tempSensor3 = random.Next(20, 30);
            int umidSensor3 = random.Next(50, 80);
            int movSensor3 = random.Next(0, 2);

            // Sensor 4 (Cozinha)
            int tempSensor4 = random.Next(22, 32); // Temperaturas na cozinha podem ser mais altas
            int umidSensor4 = random.Next(55, 85);
            int movSensor4 = random.Next(0, 2);

            // Sensor 5 (Piscina)
            int tempSensor5 = random.Next(22, 35);
            int umidSensor5 = random.Next(60, 90);
            int movSensor5 = random.Next(0, 2);

            // Atualizar os TextBoxes na interface

            // Sensor 1 (Quarto 1)
            txtValorIdSensor1.Text = "1";
            txtValorComodoSensor1.Text = "Quarto 1";
            txtValorTempSensor1.Text = $"{tempSensor1}°C";
            txtValorUmidSensor1.Text = $"{umidSensor1}%";
            txtValorMovSensor1.Text = (movSensor1 == 1 ? "Sim" : "Não");

            // Sensor 2 (Quarto 2)
            txtValorIdSensor2.Text = "2";
            txtValorComodoSensor2.Text = "Quarto 2";
            txtValorTempSensor2.Text = $"{tempSensor2}°C";
            txtValorUmidSensor2.Text = $"{umidSensor2}%";
            txtValorMovSensor2.Text = (movSensor2 == 1 ? "Sim" : "Não");

            // Sensor 3 (Sala)
            txtValorIdSensor3.Text = "3";
            txtValorComodoSensor3.Text = "Sala";
            txtValorTempSensor3.Text = $"{tempSensor3}°C";
            txtValorUmidSensor3.Text = $"{umidSensor3}%";
            txtValorMovSensor3.Text = (movSensor3 == 1 ? "Sim" : "Não");

            // Sensor 4 (Cozinha) 
            txtValorIdSensor4.Text = "4";
            txtValorComodoSensor4.Text = "Cozinha";
            txtValorTempSensor4.Text = $"{tempSensor4}°C";
            txtValorUmidSensor4.Text = $"{umidSensor4}%";
            txtValorMovSensor4.Text = (movSensor4 == 1 ? "Sim" : "Não");

            // Sensor 5 (Piscina)
            txtValorIdSensor5.Text = "5";
            txtValorComodoSensor5.Text = "Piscina";
            txtValorTempSensor5.Text = $"{tempSensor5}°C";
            txtValorUmidSensor5.Text = $"{umidSensor5}%";
            txtValorMovSensor5.Text = (movSensor5 == 1 ? "Sim" : "Não");

            // Adicionar ao histórico
            if (lstHistorico != null)
            {
                lstHistorico.Items.Add($"Leitura: ID 1 (Quarto 1) - Temp: {tempSensor1}°C, Umid: {umidSensor1}%, Mov: {(movSensor1 == 1 ? "Sim" : "Não")}");
                lstHistorico.Items.Add($"Leitura: ID 2 (Quarto 2) - Temp: {tempSensor2}°C, Umid: {umidSensor2}%, Mov: {(movSensor2 == 1 ? "Sim" : "Não")}");
                lstHistorico.Items.Add($"Leitura: ID 3 (Sala) - Temp: {tempSensor3}°C, Umid: {umidSensor3}%, Mov: {(movSensor3 == 1 ? "Sim" : "Não")}");
                lstHistorico.Items.Add($"Leitura: ID 4 (Cozinha) - Temp: {tempSensor4}°C, Umid: {umidSensor4}%, Mov: {(movSensor4 == 1 ? "Sim" : "Não")}");
                lstHistorico.Items.Add($"Leitura: ID 5 (Piscina) - Temp: {tempSensor5}°C, Umid: {umidSensor5}%, Mov: {(movSensor5 == 1 ? "Sim" : "Não")}");
            }
        }
    }
}
