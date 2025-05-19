namespace Tela_de_Login___Dashboard1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox1.Text;
            string senha = this.textBox2.Text;

            if (usuario == "1234" && senha == "1234")
            {
                DialogResult DialogResult = MessageBox.Show("Acesso Aceito!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Acesso Negado, Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entre em contato com o administrador para redefinir sua senha.\nOu tente lembrar da dica: 'Seu time do coração'.",
                    "Recuperação de senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entre em contato com a empresa responsável ao seu novo cadastro. \nAssim eles liberarão seu acesso!");
           
        }
    }
}
