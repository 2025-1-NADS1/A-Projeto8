using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboardpi
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registro_entrarbtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void registro_versenha_CheckedChanged(object sender, EventArgs e)
        {
            registro_senha.PasswordChar = registro_versenha.Checked ? '\0' : '*';
            registro_senha2.PasswordChar = registro_versenha.Checked ? '\0' : '*';
        }
    }
}
