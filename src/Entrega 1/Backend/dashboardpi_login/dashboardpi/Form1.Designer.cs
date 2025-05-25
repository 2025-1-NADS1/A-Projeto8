namespace dashboardpi
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_registrobtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_senha = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_versenha = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.login_registrobtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 454);
            this.panel1.TabIndex = 0;
            // 
            // login_registrobtn
            // 
            this.login_registrobtn.BackColor = System.Drawing.Color.DimGray;
            this.login_registrobtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registrobtn.ForeColor = System.Drawing.Color.White;
            this.login_registrobtn.Location = new System.Drawing.Point(12, 416);
            this.login_registrobtn.Name = "login_registrobtn";
            this.login_registrobtn.Size = new System.Drawing.Size(294, 26);
            this.login_registrobtn.TabIndex = 11;
            this.login_registrobtn.Text = "Registrar";
            this.login_registrobtn.UseVisualStyleBackColor = false;
            this.login_registrobtn.Click += new System.EventHandler(this.login_registrobtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastre-se";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dashboard Casa Inteligente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // fechar
            // 
            this.fechar.AutoSize = true;
            this.fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechar.Location = new System.Drawing.Point(641, 9);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(15, 15);
            this.fechar.TabIndex = 1;
            this.fechar.Text = "X";
            this.fechar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bem vindo de volta, Morador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário";
            // 
            // login_user
            // 
            this.login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_user.Location = new System.Drawing.Point(341, 159);
            this.login_user.Name = "login_user";
            this.login_user.Size = new System.Drawing.Size(307, 26);
            this.login_user.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            // 
            // login_senha
            // 
            this.login_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_senha.Location = new System.Drawing.Point(341, 226);
            this.login_senha.Name = "login_senha";
            this.login_senha.PasswordChar = '*';
            this.login_senha.Size = new System.Drawing.Size(307, 26);
            this.login_senha.TabIndex = 6;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DimGray;
            this.login_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(432, 306);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(132, 26);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Entrar";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // login_versenha
            // 
            this.login_versenha.AutoSize = true;
            this.login_versenha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_versenha.Location = new System.Drawing.Point(341, 258);
            this.login_versenha.Name = "login_versenha";
            this.login_versenha.Size = new System.Drawing.Size(85, 18);
            this.login_versenha.TabIndex = 8;
            this.login_versenha.Text = "Ver a senha";
            this.login_versenha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 454);
            this.Controls.Add(this.login_versenha);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login_senha;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_registrobtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox login_versenha;
    }
}

