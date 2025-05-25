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
    public partial class luzesForm : Form
    {
        public luzesForm()
        {
            InitializeComponent();
            trackBar1.Enabled = false;
            trackIntensidade2.Enabled = false;
            trackIntensidade3.Enabled = false;
            trackIntensidade4.Enabled = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkLuz_CheckedChanged(object sender, EventArgs e)
        {
            bool luzLigada = chkLuz.Checked;

            trackBar1.Enabled = luzLigada;

            if (!luzLigada)
            {
                trackBar1.Value = 0;
                lblIntensidade.Text = "Intensidade: 0%";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblIntensidade.Text = $"Intensidade: {trackBar1.Value}%";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblIntensidade2.Text = $"Intensidade: {trackIntensidade2.Value}%";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool luzLigada = chkLuz2.Checked;

            trackIntensidade2.Enabled = luzLigada;

            if (!luzLigada)
            {
                trackIntensidade2.Value = 0;
                lblIntensidade.Text = "Intensidade: 0%";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackIntensidade3_Scroll(object sender, EventArgs e)
        {
            lblIntensidade3.Text = $"Intensidade: {trackIntensidade3.Value}%";
        }

        private void trackIntensidade4_Scroll(object sender, EventArgs e)
        {
            lblIntensidade4.Text = $"Intensidade: {trackIntensidade4.Value}%";
        }

        private void chkLuz3_CheckedChanged(object sender, EventArgs e)
        {
            bool luzLigada = chkLuz3.Checked;

            trackIntensidade3.Enabled = luzLigada;

            if (!luzLigada)
            {
                trackIntensidade3.Value = 0;
                lblIntensidade3.Text = "Intensidade: 0%";
            }
        }

        private void chkLuz4_CheckedChanged(object sender, EventArgs e)
        {
            bool luzLigada = chkLuz4.Checked;

            trackIntensidade4.Enabled = luzLigada;

            if (!luzLigada)
            {
                trackIntensidade4.Value = 0;
                lblIntensidade4.Text = "Intensidade: 0%";
            }
        }

        private void lblIntensidade_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todas as luzes foram desligadas",
                   "Luzes desligadas",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool luzLigada = chkLuz5.Checked;

            trackIntensidade5.Enabled = luzLigada;

            if (!luzLigada)
            {
                trackIntensidade5.Value = 0;
                lblIntensidade5.Text = "Intensidade: 0%";
            }
        }

        private void trackIntensidade5_Scroll(object sender, EventArgs e)
        {
            lblIntensidade5.Text = $"Intensidade: {trackIntensidade5.Value}%";
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    
    
    

