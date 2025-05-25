namespace dashboard_casaint
{
    partial class termostatoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(termostatoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.lblTempAtual = new System.Windows.Forms.Label();
            this.lblTempConfig = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblUmidade = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returnbtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmbModo);
            this.panel1.Controls.Add(this.btnMais);
            this.panel1.Controls.Add(this.btnMenos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 581);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(138, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Termostato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cmbModo
            // 
            this.cmbModo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Location = new System.Drawing.Point(21, 70);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(192, 21);
            this.cmbModo.TabIndex = 16;
            this.cmbModo.Text = "Selecione";
            // 
            // btnMais
            // 
            this.btnMais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMais.Location = new System.Drawing.Point(57, 191);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(75, 64);
            this.btnMais.TabIndex = 14;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenos.Location = new System.Drawing.Point(57, 338);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 68);
            this.btnMenos.TabIndex = 15;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // lblTempAtual
            // 
            this.lblTempAtual.AutoSize = true;
            this.lblTempAtual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempAtual.Location = new System.Drawing.Point(326, 185);
            this.lblTempAtual.Name = "lblTempAtual";
            this.lblTempAtual.Size = new System.Drawing.Size(236, 22);
            this.lblTempAtual.TabIndex = 12;
            this.lblTempAtual.Text = "Temperatura Atual: 22°C";
            // 
            // lblTempConfig
            // 
            this.lblTempConfig.AutoSize = true;
            this.lblTempConfig.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempConfig.Location = new System.Drawing.Point(326, 257);
            this.lblTempConfig.Name = "lblTempConfig";
            this.lblTempConfig.Size = new System.Drawing.Size(305, 22);
            this.lblTempConfig.TabIndex = 13;
            this.lblTempConfig.Text = "Temperatura Configurada: 24°C";
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
            this.close.TabIndex = 19;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(326, 408);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(117, 22);
            this.lblModo.TabIndex = 20;
            this.lblModo.Text = "Modo: Auto";
            // 
            // lblUmidade
            // 
            this.lblUmidade.AutoSize = true;
            this.lblUmidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmidade.Location = new System.Drawing.Point(326, 435);
            this.lblUmidade.Name = "lblUmidade";
            this.lblUmidade.Size = new System.Drawing.Size(142, 22);
            this.lblUmidade.TabIndex = 21;
            this.lblUmidade.Text = "Umidade: 45%";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(326, 463);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(127, 22);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status: Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(518, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Temp. Atual/Histórico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(926, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "ConectaLar";
            // 
            // returnbtn
            // 
            this.returnbtn.AutoSize = true;
            this.returnbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.Location = new System.Drawing.Point(935, 9);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(18, 18);
            this.returnbtn.TabIndex = 26;
            this.returnbtn.Text = "<";
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // termostatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUmidade);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lblTempConfig);
            this.Controls.Add(this.lblTempAtual);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "termostatoForm";
            this.Text = "termostatoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTempAtual;
        private System.Windows.Forms.Label lblTempConfig;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblUmidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label returnbtn;
    }
}