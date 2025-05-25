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
    public partial class camerasForm : Form
    {
        public camerasForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerAoVivo_Click(object sender, EventArgs e)
        {
           MessageBox.Show($"Exibindo imagem simulada da câmera: {lblNomeCamera.Text}");
        }

        private void chkAlerta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlerta.Checked)
            {
                lblStatus.Text = "Status: Alerta ativado!";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "Status: Conectada";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerAoVivo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Exibindo imagem simulada da câmera: {lblNomeCamera2.Text}");
        }

        private void chkAlerta2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlerta2.Checked)
            {
                lblStatus2.Text = "Status: Alerta ativado!";
                lblStatus2.ForeColor = Color.Red;
            }
            else
            {
                lblStatus2.Text = "Status: Conectada";
                lblStatus2.ForeColor = Color.Green;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerAoVivo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Exibindo imagem simulada da câmera: {lblNomeCamera3.Text}");
        }

        private void chkAlerta3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlerta3.Checked)
            {
                lblStatus3.Text = "Status: Alerta ativado!";
                lblStatus3.ForeColor = Color.Red;
            }
            else
            {
                lblStatus3.Text = "Status: Conectada";
                lblStatus3.ForeColor = Color.Green;
            }
        }

        private void desligarluzesbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todas as cameras foram desligadas.");
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

