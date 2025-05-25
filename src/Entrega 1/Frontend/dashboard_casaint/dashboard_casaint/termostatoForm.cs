using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_casaint
{
    public partial class termostatoForm : Form
    {
        int temperaturaAtual = 22;
        int temperaturaConfig = 24;

        public termostatoForm()
        {
            InitializeComponent();

            cmbModo.Items.AddRange(new string[] { "Auto", "Aquecimento", "Resfriamento", "Desligado" });
            cmbModo.SelectedIndex = 0;
        }
        private void AtualizarUI()
        {
            lblTempAtual.Text = $"Temperatura Atual: {temperaturaAtual}°C";
            lblTempConfig.Text = $"Temperatura Configurada: {temperaturaConfig}°C";
            lblModo.Text = $"Modo: {cmbModo.SelectedItem}";
            lblUmidade.Text = "Umidade: 45%";
            lblStatus.Text = "Status: Ativo";

            if (temperaturaConfig >= 30)
            {
                lblStatus.Text = "Status: Muito quente! Verificando ar-condicionado...";
                lblStatus.ForeColor = Color.Red;
            }
            else if (temperaturaConfig <= 16)
            {
                lblStatus.Text = "Status: Muito frio! Ativando aquecimento...";
                lblStatus.ForeColor = Color.Blue;
            }
            else
            {
                lblStatus.Text = "Status: Temperatura confortável.";
                lblStatus.ForeColor = Color.Green;
            }
        }
        
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            temperaturaConfig++;
            AtualizarUI();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            temperaturaConfig--;
            AtualizarUI();
        }
        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarUI();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
