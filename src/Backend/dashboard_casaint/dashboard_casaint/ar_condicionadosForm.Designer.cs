using System.Windows.Forms;

namespace dashboard_casaint
{
    partial class ar_condicionadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ar_condicionadosForm));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatusSala = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.returnbtn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLigarSala = new System.Windows.Forms.Button();
            this.btnAumentarSala = new System.Windows.Forms.Button();
            this.btnDiminuirSala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLigarSala2 = new System.Windows.Forms.Button();
            this.btnAumentarSala2 = new System.Windows.Forms.Button();
            this.btnDiminuirSala2 = new System.Windows.Forms.Button();
            this.lblStatusSala2 = new System.Windows.Forms.Label();
            this.lblStatusSala3 = new System.Windows.Forms.Label();
            this.btnDiminuirSala3 = new System.Windows.Forms.Button();
            this.btnAumentarSala3 = new System.Windows.Forms.Button();
            this.btnLigarSala3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ar-Condicionados";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 581);
            this.panel1.TabIndex = 10;
            // 
            // lblStatusSala
            // 
            this.lblStatusSala.AutoSize = true;
            this.lblStatusSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusSala.Location = new System.Drawing.Point(345, 306);
            this.lblStatusSala.Name = "lblStatusSala";
            this.lblStatusSala.Size = new System.Drawing.Size(72, 15);
            this.lblStatusSala.TabIndex = 14;
            this.lblStatusSala.Text = "Desligado";
            this.lblStatusSala.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(566, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Histórico";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.RoyalBlue;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(969, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(19, 18);
            this.close.TabIndex = 18;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // returnbtn
            // 
            this.returnbtn.AutoSize = true;
            this.returnbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.Location = new System.Drawing.Point(931, 9);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(18, 18);
            this.returnbtn.TabIndex = 19;
            this.returnbtn.Text = "<";
            this.returnbtn.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(926, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ConectaLar";
            // 
            // btnLigarSala
            // 
            this.btnLigarSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLigarSala.Location = new System.Drawing.Point(348, 168);
            this.btnLigarSala.Name = "btnLigarSala";
            this.btnLigarSala.Size = new System.Drawing.Size(83, 23);
            this.btnLigarSala.TabIndex = 21;
            this.btnLigarSala.Text = "Ligar/Desligar";
            this.btnLigarSala.UseVisualStyleBackColor = true;
            this.btnLigarSala.Click += new System.EventHandler(this.btnLigarSala_Click);
            // 
            // btnAumentarSala
            // 
            this.btnAumentarSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarSala.Location = new System.Drawing.Point(348, 211);
            this.btnAumentarSala.Name = "btnAumentarSala";
            this.btnAumentarSala.Size = new System.Drawing.Size(83, 23);
            this.btnAumentarSala.TabIndex = 22;
            this.btnAumentarSala.Text = "+";
            this.btnAumentarSala.UseVisualStyleBackColor = true;
            this.btnAumentarSala.Click += new System.EventHandler(this.btnAumentarSala_Click);
            // 
            // btnDiminuirSala
            // 
            this.btnDiminuirSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuirSala.Location = new System.Drawing.Point(348, 259);
            this.btnDiminuirSala.Name = "btnDiminuirSala";
            this.btnDiminuirSala.Size = new System.Drawing.Size(83, 23);
            this.btnDiminuirSala.TabIndex = 23;
            this.btnDiminuirSala.Text = "-";
            this.btnDiminuirSala.UseVisualStyleBackColor = true;
            this.btnDiminuirSala.Click += new System.EventHandler(this.btnDiminuirSala_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sala";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quarto 1";
            // 
            // btnLigarSala2
            // 
            this.btnLigarSala2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLigarSala2.Location = new System.Drawing.Point(570, 259);
            this.btnLigarSala2.Name = "btnLigarSala2";
            this.btnLigarSala2.Size = new System.Drawing.Size(83, 23);
            this.btnLigarSala2.TabIndex = 27;
            this.btnLigarSala2.Text = "Ligar/Desligar";
            this.btnLigarSala2.UseVisualStyleBackColor = true;
            this.btnLigarSala2.Click += new System.EventHandler(this.btnLigarSala2_Click);
            // 
            // btnAumentarSala2
            // 
            this.btnAumentarSala2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarSala2.Location = new System.Drawing.Point(570, 303);
            this.btnAumentarSala2.Name = "btnAumentarSala2";
            this.btnAumentarSala2.Size = new System.Drawing.Size(83, 23);
            this.btnAumentarSala2.TabIndex = 28;
            this.btnAumentarSala2.Text = "+";
            this.btnAumentarSala2.UseVisualStyleBackColor = true;
            this.btnAumentarSala2.Click += new System.EventHandler(this.btnAumentarSala2_Click);
            // 
            // btnDiminuirSala2
            // 
            this.btnDiminuirSala2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuirSala2.Location = new System.Drawing.Point(570, 348);
            this.btnDiminuirSala2.Name = "btnDiminuirSala2";
            this.btnDiminuirSala2.Size = new System.Drawing.Size(83, 23);
            this.btnDiminuirSala2.TabIndex = 29;
            this.btnDiminuirSala2.Text = "-";
            this.btnDiminuirSala2.UseVisualStyleBackColor = true;
            this.btnDiminuirSala2.Click += new System.EventHandler(this.btnDiminuirSala2_Click);
            // 
            // lblStatusSala2
            // 
            this.lblStatusSala2.AutoSize = true;
            this.lblStatusSala2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusSala2.Location = new System.Drawing.Point(567, 396);
            this.lblStatusSala2.Name = "lblStatusSala2";
            this.lblStatusSala2.Size = new System.Drawing.Size(72, 15);
            this.lblStatusSala2.TabIndex = 30;
            this.lblStatusSala2.Text = "Desligado";
            // 
            // lblStatusSala3
            // 
            this.lblStatusSala3.AutoSize = true;
            this.lblStatusSala3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusSala3.Location = new System.Drawing.Point(811, 492);
            this.lblStatusSala3.Name = "lblStatusSala3";
            this.lblStatusSala3.Size = new System.Drawing.Size(72, 15);
            this.lblStatusSala3.TabIndex = 35;
            this.lblStatusSala3.Text = "Desligado";
            // 
            // btnDiminuirSala3
            // 
            this.btnDiminuirSala3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuirSala3.Location = new System.Drawing.Point(814, 444);
            this.btnDiminuirSala3.Name = "btnDiminuirSala3";
            this.btnDiminuirSala3.Size = new System.Drawing.Size(83, 23);
            this.btnDiminuirSala3.TabIndex = 34;
            this.btnDiminuirSala3.Text = "-";
            this.btnDiminuirSala3.UseVisualStyleBackColor = true;
            this.btnDiminuirSala3.Click += new System.EventHandler(this.btnDiminuirSala3_Click);
            // 
            // btnAumentarSala3
            // 
            this.btnAumentarSala3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarSala3.Location = new System.Drawing.Point(814, 399);
            this.btnAumentarSala3.Name = "btnAumentarSala3";
            this.btnAumentarSala3.Size = new System.Drawing.Size(83, 23);
            this.btnAumentarSala3.TabIndex = 33;
            this.btnAumentarSala3.Text = "+";
            this.btnAumentarSala3.UseVisualStyleBackColor = true;
            this.btnAumentarSala3.Click += new System.EventHandler(this.btnAumentarSala3_Click);
            // 
            // btnLigarSala3
            // 
            this.btnLigarSala3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLigarSala3.Location = new System.Drawing.Point(814, 355);
            this.btnLigarSala3.Name = "btnLigarSala3";
            this.btnLigarSala3.Size = new System.Drawing.Size(83, 23);
            this.btnLigarSala3.TabIndex = 32;
            this.btnLigarSala3.Text = "Ligar/Desligar";
            this.btnLigarSala3.UseVisualStyleBackColor = true;
            this.btnLigarSala3.Click += new System.EventHandler(this.btnLigarSala3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(811, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Quarto 2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(28, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 59);
            this.button1.TabIndex = 43;
            this.button1.Text = "Desligar todos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ar_condicionadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.lblStatusSala3);
            this.Controls.Add(this.btnDiminuirSala3);
            this.Controls.Add(this.btnAumentarSala3);
            this.Controls.Add(this.btnLigarSala3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatusSala2);
            this.Controls.Add(this.btnDiminuirSala2);
            this.Controls.Add(this.btnAumentarSala2);
            this.Controls.Add(this.btnLigarSala2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiminuirSala);
            this.Controls.Add(this.btnAumentarSala);
            this.Controls.Add(this.btnLigarSala);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatusSala);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ar_condicionadosForm";
            this.Text = "ar_condicionadosForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatusSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label returnbtn;

        public ar_condicionadosForm(Label returnbtn)
        {
            this.returnbtn = returnbtn;
        }

        private Label label7;
        private Button btnLigarSala;
        private Button btnAumentarSala;
        private Button btnDiminuirSala;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnLigarSala2;
        private Button btnAumentarSala2;
        private Button btnDiminuirSala2;
        private Label lblStatusSala2;
        private Label lblStatusSala3;
        private Button btnDiminuirSala3;
        private Button btnAumentarSala3;
        private Button btnLigarSala3;
        private Label label6;
        private Button button1;
    }
}