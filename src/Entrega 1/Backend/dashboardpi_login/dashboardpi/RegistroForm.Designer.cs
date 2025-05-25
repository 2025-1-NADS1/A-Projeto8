namespace dashboardpi
{
    partial class RegistroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.registro_versenha = new System.Windows.Forms.CheckBox();
            this.registrobtn = new System.Windows.Forms.Button();
            this.registro_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registro_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registro_entrarbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registro_senha2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registro_versenha
            // 
            this.registro_versenha.AutoSize = true;
            this.registro_versenha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_versenha.Location = new System.Drawing.Point(340, 325);
            this.registro_versenha.Name = "registro_versenha";
            this.registro_versenha.Size = new System.Drawing.Size(85, 18);
            this.registro_versenha.TabIndex = 17;
            this.registro_versenha.Text = "Ver a senha";
            this.registro_versenha.UseVisualStyleBackColor = true;
            this.registro_versenha.CheckedChanged += new System.EventHandler(this.registro_versenha_CheckedChanged);
            // 
            // registrobtn
            // 
            this.registrobtn.BackColor = System.Drawing.Color.DimGray;
            this.registrobtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrobtn.ForeColor = System.Drawing.Color.White;
            this.registrobtn.Location = new System.Drawing.Point(436, 383);
            this.registrobtn.Name = "registrobtn";
            this.registrobtn.Size = new System.Drawing.Size(132, 30);
            this.registrobtn.TabIndex = 16;
            this.registrobtn.Text = "Registar";
            this.registrobtn.UseVisualStyleBackColor = false;
            // 
            // registro_senha
            // 
            this.registro_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_senha.Location = new System.Drawing.Point(340, 226);
            this.registro_senha.Name = "registro_senha";
            this.registro_senha.PasswordChar = '*';
            this.registro_senha.Size = new System.Drawing.Size(307, 26);
            this.registro_senha.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha";
            // 
            // registro_user
            // 
            this.registro_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_user.Location = new System.Drawing.Point(340, 159);
            this.registro_user.Name = "registro_user";
            this.registro_user.Size = new System.Drawing.Size(307, 26);
            this.registro_user.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registrar-se";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fechar
            // 
            this.fechar.AutoSize = true;
            this.fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechar.Location = new System.Drawing.Point(641, 9);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(15, 15);
            this.fechar.TabIndex = 10;
            this.fechar.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.registro_entrarbtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 454);
            this.panel1.TabIndex = 9;
            // 
            // registro_entrarbtn
            // 
            this.registro_entrarbtn.BackColor = System.Drawing.Color.DimGray;
            this.registro_entrarbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_entrarbtn.ForeColor = System.Drawing.Color.White;
            this.registro_entrarbtn.Location = new System.Drawing.Point(12, 416);
            this.registro_entrarbtn.Name = "registro_entrarbtn";
            this.registro_entrarbtn.Size = new System.Drawing.Size(294, 26);
            this.registro_entrarbtn.TabIndex = 11;
            this.registro_entrarbtn.Text = "Entrar";
            this.registro_entrarbtn.UseVisualStyleBackColor = false;
            this.registro_entrarbtn.Click += new System.EventHandler(this.registro_entrarbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Já sou cadastrado";
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
            this.pictureBox1.Location = new System.Drawing.Point(110, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // registro_senha2
            // 
            this.registro_senha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_senha2.Location = new System.Drawing.Point(340, 293);
            this.registro_senha2.Name = "registro_senha2";
            this.registro_senha2.PasswordChar = '*';
            this.registro_senha2.Size = new System.Drawing.Size(307, 26);
            this.registro_senha2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Confirmar Senha";
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 454);
            this.Controls.Add(this.registro_senha2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registro_versenha);
            this.Controls.Add(this.registrobtn);
            this.Controls.Add(this.registro_senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registro_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox registro_versenha;
        private System.Windows.Forms.Button registrobtn;
        private System.Windows.Forms.TextBox registro_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registro_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registro_entrarbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox registro_senha2;
        private System.Windows.Forms.Label label7;
    }
}