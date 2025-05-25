namespace dashboard_casaint
{
    partial class camerasForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeCamera = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUltimaAtiv = new System.Windows.Forms.Label();
            this.chkAlerta = new System.Windows.Forms.CheckBox();
            this.btnVerAoVivo = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerAoVivo2 = new System.Windows.Forms.Button();
            this.chkAlerta2 = new System.Windows.Forms.CheckBox();
            this.lblUltimaAtiv2 = new System.Windows.Forms.Label();
            this.lblNomeCamera2 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.btnVerAoVivo3 = new System.Windows.Forms.Button();
            this.chkAlerta3 = new System.Windows.Forms.CheckBox();
            this.lblUltimaAtiv3 = new System.Windows.Forms.Label();
            this.lblNomeCamera3 = new System.Windows.Forms.Label();
            this.lblStatus3 = new System.Windows.Forms.Label();
            this.desligarluzesbtn = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.desligarluzesbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 581);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 69);
            this.label3.TabIndex = 9;
            this.label3.Text = "  Cameras \r\n       de \r\nSegurança";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNomeCamera
            // 
            this.lblNomeCamera.AutoSize = true;
            this.lblNomeCamera.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCamera.Location = new System.Drawing.Point(330, 116);
            this.lblNomeCamera.Name = "lblNomeCamera";
            this.lblNomeCamera.Size = new System.Drawing.Size(117, 16);
            this.lblNomeCamera.TabIndex = 14;
            this.lblNomeCamera.Text = "Entrada Principal";
            this.lblNomeCamera.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(330, 154);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 16);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Conectada";
            // 
            // lblUltimaAtiv
            // 
            this.lblUltimaAtiv.AutoSize = true;
            this.lblUltimaAtiv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaAtiv.Location = new System.Drawing.Point(330, 187);
            this.lblUltimaAtiv.Name = "lblUltimaAtiv";
            this.lblUltimaAtiv.Size = new System.Drawing.Size(114, 16);
            this.lblUltimaAtiv.TabIndex = 16;
            this.lblUltimaAtiv.Text = "Última atividade: --";
            // 
            // chkAlerta
            // 
            this.chkAlerta.AutoSize = true;
            this.chkAlerta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlerta.Location = new System.Drawing.Point(333, 226);
            this.chkAlerta.Name = "chkAlerta";
            this.chkAlerta.Size = new System.Drawing.Size(144, 20);
            this.chkAlerta.TabIndex = 14;
            this.chkAlerta.Text = "Alerta de Movimento";
            this.chkAlerta.UseVisualStyleBackColor = true;
            this.chkAlerta.CheckedChanged += new System.EventHandler(this.chkAlerta_CheckedChanged);
            // 
            // btnVerAoVivo
            // 
            this.btnVerAoVivo.Location = new System.Drawing.Point(369, 276);
            this.btnVerAoVivo.Name = "btnVerAoVivo";
            this.btnVerAoVivo.Size = new System.Drawing.Size(75, 23);
            this.btnVerAoVivo.TabIndex = 14;
            this.btnVerAoVivo.Text = "Ver ao Vivo";
            this.btnVerAoVivo.UseVisualStyleBackColor = true;
            this.btnVerAoVivo.Click += new System.EventHandler(this.btnVerAoVivo_Click);
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
            this.close.TabIndex = 21;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(519, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Histórico Cameras";
            // 
            // btnVerAoVivo2
            // 
            this.btnVerAoVivo2.Location = new System.Drawing.Point(771, 276);
            this.btnVerAoVivo2.Name = "btnVerAoVivo2";
            this.btnVerAoVivo2.Size = new System.Drawing.Size(75, 23);
            this.btnVerAoVivo2.TabIndex = 22;
            this.btnVerAoVivo2.Text = "Ver ao Vivo";
            this.btnVerAoVivo2.UseVisualStyleBackColor = true;
            this.btnVerAoVivo2.Click += new System.EventHandler(this.btnVerAoVivo2_Click);
            // 
            // chkAlerta2
            // 
            this.chkAlerta2.AutoSize = true;
            this.chkAlerta2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlerta2.Location = new System.Drawing.Point(735, 226);
            this.chkAlerta2.Name = "chkAlerta2";
            this.chkAlerta2.Size = new System.Drawing.Size(144, 20);
            this.chkAlerta2.TabIndex = 23;
            this.chkAlerta2.Text = "Alerta de Movimento";
            this.chkAlerta2.UseVisualStyleBackColor = true;
            this.chkAlerta2.CheckedChanged += new System.EventHandler(this.chkAlerta2_CheckedChanged);
            // 
            // lblUltimaAtiv2
            // 
            this.lblUltimaAtiv2.AutoSize = true;
            this.lblUltimaAtiv2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaAtiv2.Location = new System.Drawing.Point(732, 187);
            this.lblUltimaAtiv2.Name = "lblUltimaAtiv2";
            this.lblUltimaAtiv2.Size = new System.Drawing.Size(114, 16);
            this.lblUltimaAtiv2.TabIndex = 26;
            this.lblUltimaAtiv2.Text = "Última atividade: --";
            // 
            // lblNomeCamera2
            // 
            this.lblNomeCamera2.AutoSize = true;
            this.lblNomeCamera2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCamera2.Location = new System.Drawing.Point(732, 116);
            this.lblNomeCamera2.Name = "lblNomeCamera2";
            this.lblNomeCamera2.Size = new System.Drawing.Size(63, 16);
            this.lblNomeCamera2.TabIndex = 24;
            this.lblNomeCamera2.Text = "Corredor";
            this.lblNomeCamera2.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus2.Location = new System.Drawing.Point(732, 154);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(69, 16);
            this.lblStatus2.TabIndex = 25;
            this.lblStatus2.Text = "Conectada";
            this.lblStatus2.Click += new System.EventHandler(this.lblStatus2_Click);
            // 
            // btnVerAoVivo3
            // 
            this.btnVerAoVivo3.Location = new System.Drawing.Point(593, 508);
            this.btnVerAoVivo3.Name = "btnVerAoVivo3";
            this.btnVerAoVivo3.Size = new System.Drawing.Size(75, 23);
            this.btnVerAoVivo3.TabIndex = 27;
            this.btnVerAoVivo3.Text = "Ver ao Vivo";
            this.btnVerAoVivo3.UseVisualStyleBackColor = true;
            this.btnVerAoVivo3.Click += new System.EventHandler(this.btnVerAoVivo3_Click);
            // 
            // chkAlerta3
            // 
            this.chkAlerta3.AutoSize = true;
            this.chkAlerta3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlerta3.Location = new System.Drawing.Point(557, 458);
            this.chkAlerta3.Name = "chkAlerta3";
            this.chkAlerta3.Size = new System.Drawing.Size(144, 20);
            this.chkAlerta3.TabIndex = 28;
            this.chkAlerta3.Text = "Alerta de Movimento";
            this.chkAlerta3.UseVisualStyleBackColor = true;
            this.chkAlerta3.CheckedChanged += new System.EventHandler(this.chkAlerta3_CheckedChanged);
            // 
            // lblUltimaAtiv3
            // 
            this.lblUltimaAtiv3.AutoSize = true;
            this.lblUltimaAtiv3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaAtiv3.Location = new System.Drawing.Point(554, 419);
            this.lblUltimaAtiv3.Name = "lblUltimaAtiv3";
            this.lblUltimaAtiv3.Size = new System.Drawing.Size(114, 16);
            this.lblUltimaAtiv3.TabIndex = 31;
            this.lblUltimaAtiv3.Text = "Última atividade: --";
            // 
            // lblNomeCamera3
            // 
            this.lblNomeCamera3.AutoSize = true;
            this.lblNomeCamera3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCamera3.Location = new System.Drawing.Point(554, 348);
            this.lblNomeCamera3.Name = "lblNomeCamera3";
            this.lblNomeCamera3.Size = new System.Drawing.Size(66, 16);
            this.lblNomeCamera3.TabIndex = 29;
            this.lblNomeCamera3.Text = "Garagem";
            // 
            // lblStatus3
            // 
            this.lblStatus3.AutoSize = true;
            this.lblStatus3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus3.Location = new System.Drawing.Point(554, 386);
            this.lblStatus3.Name = "lblStatus3";
            this.lblStatus3.Size = new System.Drawing.Size(69, 16);
            this.lblStatus3.TabIndex = 30;
            this.lblStatus3.Text = "Conectada";
            // 
            // desligarluzesbtn
            // 
            this.desligarluzesbtn.BackColor = System.Drawing.Color.DarkRed;
            this.desligarluzesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desligarluzesbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.desligarluzesbtn.Location = new System.Drawing.Point(32, 472);
            this.desligarluzesbtn.Name = "desligarluzesbtn";
            this.desligarluzesbtn.Size = new System.Drawing.Size(168, 59);
            this.desligarluzesbtn.TabIndex = 43;
            this.desligarluzesbtn.Text = "Desligar todas as cameras";
            this.desligarluzesbtn.UseVisualStyleBackColor = false;
            this.desligarluzesbtn.Click += new System.EventHandler(this.desligarluzesbtn_Click);
            // 
            // returnbtn
            // 
            this.returnbtn.AutoSize = true;
            this.returnbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.Location = new System.Drawing.Point(932, 9);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(18, 18);
            this.returnbtn.TabIndex = 32;
            this.returnbtn.Text = "<";
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // camerasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.btnVerAoVivo3);
            this.Controls.Add(this.chkAlerta3);
            this.Controls.Add(this.lblUltimaAtiv3);
            this.Controls.Add(this.lblNomeCamera3);
            this.Controls.Add(this.lblStatus3);
            this.Controls.Add(this.btnVerAoVivo2);
            this.Controls.Add(this.chkAlerta2);
            this.Controls.Add(this.lblUltimaAtiv2);
            this.Controls.Add(this.lblNomeCamera2);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerAoVivo);
            this.Controls.Add(this.close);
            this.Controls.Add(this.chkAlerta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUltimaAtiv);
            this.Controls.Add(this.lblNomeCamera);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "camerasForm";
            this.Text = "camerasForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerAoVivo;
        private System.Windows.Forms.CheckBox chkAlerta;
        private System.Windows.Forms.Label lblUltimaAtiv;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNomeCamera;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerAoVivo2;
        private System.Windows.Forms.CheckBox chkAlerta2;
        private System.Windows.Forms.Label lblUltimaAtiv2;
        private System.Windows.Forms.Label lblNomeCamera2;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Button btnVerAoVivo3;
        private System.Windows.Forms.CheckBox chkAlerta3;
        private System.Windows.Forms.Label lblUltimaAtiv3;
        private System.Windows.Forms.Label lblNomeCamera3;
        private System.Windows.Forms.Label lblStatus3;
        private System.Windows.Forms.Button desligarluzesbtn;
        private System.Windows.Forms.Label returnbtn;
    }
}