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
    public partial class consumo : Form
    {
        public consumo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbldataselector.Text = "Data selecionada: " + e.Start.ToString("dd/MM/yyyy");
        }

        private void trancar_casa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todas as portas e janelas foram trancadas com sucesso.",
                   "Casa Trancada",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void all_luzes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todas as luzes foram desligadas",
                   "Luzes desligadas",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }
        private void modo_fora_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modo Fora de Casa ativado.\nSensores e sistema de segurança estão operando.",
                   "Modo Ativado",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
             
        
    }

        private void chartconsumo_Click(object sender, EventArgs e)
        {
            {
            
        }

    }


        private void chartConsumo_Click_1(object sender, EventArgs e)
        {

    }

        private void button4_Click(object sender, EventArgs e)
        {
            ar_condicionadosForm ac_btn = new ar_condicionadosForm();
            ac_btn.Show();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            termostatoForm termbtn = new termostatoForm();
            termbtn.Show();

            
        }

        private void luzesbtn_Click(object sender, EventArgs e)
        {
            luzesForm luzesbtn = new luzesForm();
            luzesbtn.Show();

            
        }

        private void camerasbtn_Click(object sender, EventArgs e)
        {
            camerasForm camerasbtn = new camerasForm();
            camerasbtn.Show();

            
        }

        private void consumobtn_Click(object sender, EventArgs e)
        {
            consumoForm consumobtn = new consumoForm();
            consumobtn.Show();

            
        }
    }

}

