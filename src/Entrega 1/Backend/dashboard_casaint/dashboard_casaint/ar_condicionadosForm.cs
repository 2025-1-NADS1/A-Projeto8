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
    public partial class ar_condicionadosForm : Form
    {
        bool salaLigado = false;
        int temperaturaSala = 24;

        bool quarto1Ligado = false;
        int temperaturaQuarto1 = 24;

        bool quarto2Ligado = false;
        int temperaturaQuarto2 = 24;

        public ar_condicionadosForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLigarSala_Click(object sender, EventArgs e)
        {
            salaLigado = !salaLigado;
            AtualizarStatusSala();
        }
        private void AtualizarStatusSala()
        {
            if (salaLigado)
            {
                lblStatusSala.Text = $"Ligado - {temperaturaSala} ºC";
                lblStatusSala.ForeColor = Color.Green;
            }
            else
            {
                lblStatusSala.Text = "Desligado";
                lblStatusSala.ForeColor = Color.Gray;
            }
        }

        private void btnAumentarSala_Click(object sender, EventArgs e)
        {
            if (salaLigado && temperaturaSala < 30)
            {
                temperaturaSala++;
                AtualizarStatusSala();
            }
        }

        private void btnDiminuirSala_Click(object sender, EventArgs e)
        {
            if (salaLigado && temperaturaSala > 16)
            {
                temperaturaSala--;
                AtualizarStatusSala();
            }
        }
        private void AtualizarStatusQuarto1()
        {
            if (quarto1Ligado)
            {
                lblStatusSala2.Text = $"Ligado - {temperaturaQuarto1} ºC";
                lblStatusSala2.ForeColor = Color.Green;
            }
            else
            {
                lblStatusSala2.Text = "Desligado";
                lblStatusSala2.ForeColor = Color.Gray;
            }
        }

        private void btnLigarSala2_Click(object sender, EventArgs e)
        {
            quarto1Ligado = !quarto1Ligado;
            AtualizarStatusQuarto1();
        }

        private void btnAumentarSala2_Click(object sender, EventArgs e)
        {
            if (quarto1Ligado && temperaturaQuarto1 < 30)
            {
                temperaturaQuarto1++;
                AtualizarStatusQuarto1();
            }
        }

        private void btnDiminuirSala2_Click(object sender, EventArgs e)
        {
            if (quarto1Ligado && temperaturaQuarto1 > 16)
            {
                temperaturaQuarto1--;
                AtualizarStatusQuarto1();
            }
        }
        private void AtualizarStatusQuarto2()
        {
            if (quarto2Ligado)
            {
                lblStatusSala3.Text = $"Ligado - {temperaturaQuarto2} ºC";
                lblStatusSala3.ForeColor = Color.Green;
            }
            else
            {
                lblStatusSala3.Text = "Desligado";
                lblStatusSala3.ForeColor = Color.Gray;
            }
        }

        private void btnLigarSala3_Click(object sender, EventArgs e)
        {
            quarto2Ligado = !quarto2Ligado;
            AtualizarStatusQuarto2();
        }

        private void btnAumentarSala3_Click(object sender, EventArgs e)
        {
            if (quarto2Ligado && temperaturaQuarto2 < 30)
            {
                temperaturaQuarto2++;
                AtualizarStatusQuarto2();
            }
        }

        private void btnDiminuirSala3_Click(object sender, EventArgs e)
        {
            if (quarto2Ligado && temperaturaQuarto2 > 16)
            {
                temperaturaQuarto2--;
                AtualizarStatusQuarto2();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos os componentes foram desligados");
        }
    }
    }
    
    
    
    
    

