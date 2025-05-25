namespace dashboard_casaint
{
    partial class consumoForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.close = new System.Windows.Forms.Label();
            this.returnbtn = new System.Windows.Forms.Label();
            this.chartConsumo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.DimGray;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(969, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(19, 18);
            this.close.TabIndex = 19;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // returnbtn
            // 
            this.returnbtn.AutoSize = true;
            this.returnbtn.BackColor = System.Drawing.Color.DimGray;
            this.returnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.Location = new System.Drawing.Point(931, 9);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(18, 18);
            this.returnbtn.TabIndex = 20;
            this.returnbtn.Text = "<";
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // chartConsumo
            // 
            this.chartConsumo.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chartConsumo.ChartAreas.Add(chartArea1);
            this.chartConsumo.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartConsumo.Legends.Add(legend1);
            this.chartConsumo.Location = new System.Drawing.Point(12, 133);
            this.chartConsumo.Name = "chartConsumo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartConsumo.Series.Add(series1);
            this.chartConsumo.Size = new System.Drawing.Size(976, 445);
            this.chartConsumo.TabIndex = 21;
            this.chartConsumo.Text = "chart1";
            this.chartConsumo.Click += new System.EventHandler(this.chartConsumo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(398, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Consumo de eletricidade";
            // 
            // consumoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartConsumo);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consumoForm";
            this.Text = "consumoForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label returnbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConsumo;
        private System.Windows.Forms.Label label3;
    }
}