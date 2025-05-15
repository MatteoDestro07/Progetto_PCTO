namespace Progetto_PCTO.Views
{
    partial class FrmStatistiche
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistiche));
            this.crtBestSell = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnni = new System.Windows.Forms.ComboBox();
            this.crtFatturato = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.crtBestSell)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtFatturato)).BeginInit();
            this.SuspendLayout();
            // 
            // crtBestSell
            // 
            chartArea1.Name = "ChartArea1";
            this.crtBestSell.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtBestSell.Legends.Add(legend1);
            this.crtBestSell.Location = new System.Drawing.Point(9, 21);
            this.crtBestSell.Name = "crtBestSell";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtBestSell.Series.Add(series1);
            this.crtBestSell.Size = new System.Drawing.Size(595, 475);
            this.crtBestSell.TabIndex = 0;
            this.crtBestSell.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crtBestSell);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 505);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "5 prodotti più venduti";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbAnni);
            this.groupBox3.Controls.Add(this.crtFatturato);
            this.groupBox3.Location = new System.Drawing.Point(620, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 505);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtra prodotti per mese";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleziona anno da visualizzare";
            // 
            // cmbAnni
            // 
            this.cmbAnni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnni.FormattingEnabled = true;
            this.cmbAnni.Location = new System.Drawing.Point(295, 21);
            this.cmbAnni.Name = "cmbAnni";
            this.cmbAnni.Size = new System.Drawing.Size(280, 24);
            this.cmbAnni.TabIndex = 2;
            this.cmbAnni.SelectedIndexChanged += new System.EventHandler(this.cmbMesi_SelectedIndexChanged);
            // 
            // crtFatturato
            // 
            chartArea2.Name = "ChartArea1";
            this.crtFatturato.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtFatturato.Legends.Add(legend2);
            this.crtFatturato.Location = new System.Drawing.Point(6, 58);
            this.crtFatturato.Name = "crtFatturato";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.crtFatturato.Series.Add(series2);
            this.crtFatturato.Size = new System.Drawing.Size(595, 438);
            this.crtFatturato.TabIndex = 1;
            this.crtFatturato.Text = "chart1";
            // 
            // FrmStatistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1250, 575);
            this.MinimumSize = new System.Drawing.Size(1250, 575);
            this.Name = "FrmStatistiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiche di acquisto";
            this.Load += new System.EventHandler(this.FrmStatistiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtBestSell)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtFatturato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtBestSell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnni;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtFatturato;
    }
}