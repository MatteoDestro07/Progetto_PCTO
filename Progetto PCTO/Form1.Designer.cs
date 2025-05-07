namespace Progetto_PCTO
{
    partial class FrmVendite
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendite));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodottiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVendite = new System.Windows.Forms.DataGridView();
            this.grbVendite = new System.Windows.Forms.GroupBox();
            this.chkModalitàEliminaProdotto = new System.Windows.Forms.CheckBox();
            this.btnSvuotaCarrello = new System.Windows.Forms.Button();
            this.btnAggiungiProdotto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantitàVendita = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProdottoVendita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriaVendita = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVisualizzazioneDgv = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendite)).BeginInit();
            this.grbVendite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantitàVendita)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiToolStripMenuItem,
            this.categorieToolStripMenuItem,
            this.prodottiToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.categorieToolStripMenuItem.Text = "Categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // prodottiToolStripMenuItem
            // 
            this.prodottiToolStripMenuItem.Name = "prodottiToolStripMenuItem";
            this.prodottiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.prodottiToolStripMenuItem.Text = "Prodotti";
            this.prodottiToolStripMenuItem.Click += new System.EventHandler(this.prodottiToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // dgvVendite
            // 
            this.dgvVendite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendite.Location = new System.Drawing.Point(6, 60);
            this.dgvVendite.Name = "dgvVendite";
            this.dgvVendite.RowHeadersWidth = 51;
            this.dgvVendite.RowTemplate.Height = 24;
            this.dgvVendite.Size = new System.Drawing.Size(567, 259);
            this.dgvVendite.TabIndex = 1;
            // 
            // grbVendite
            // 
            this.grbVendite.Controls.Add(this.chkModalitàEliminaProdotto);
            this.grbVendite.Controls.Add(this.btnSvuotaCarrello);
            this.grbVendite.Controls.Add(this.btnAggiungiProdotto);
            this.grbVendite.Controls.Add(this.label3);
            this.grbVendite.Controls.Add(this.nudQuantitàVendita);
            this.grbVendite.Controls.Add(this.label2);
            this.grbVendite.Controls.Add(this.cmbProdottoVendita);
            this.grbVendite.Controls.Add(this.label1);
            this.grbVendite.Controls.Add(this.cmbCategoriaVendita);
            this.grbVendite.Location = new System.Drawing.Point(597, 32);
            this.grbVendite.Name = "grbVendite";
            this.grbVendite.Size = new System.Drawing.Size(271, 325);
            this.grbVendite.TabIndex = 2;
            this.grbVendite.TabStop = false;
            this.grbVendite.Text = "Acquista Prodotto";
            // 
            // chkModalitàEliminaProdotto
            // 
            this.chkModalitàEliminaProdotto.AutoSize = true;
            this.chkModalitàEliminaProdotto.Location = new System.Drawing.Point(19, 131);
            this.chkModalitàEliminaProdotto.Name = "chkModalitàEliminaProdotto";
            this.chkModalitàEliminaProdotto.Size = new System.Drawing.Size(128, 20);
            this.chkModalitàEliminaProdotto.TabIndex = 8;
            this.chkModalitàEliminaProdotto.Text = "Modalità Elimina";
            this.chkModalitàEliminaProdotto.UseVisualStyleBackColor = true;
            // 
            // btnSvuotaCarrello
            // 
            this.btnSvuotaCarrello.BackColor = System.Drawing.Color.Red;
            this.btnSvuotaCarrello.Location = new System.Drawing.Point(68, 237);
            this.btnSvuotaCarrello.Name = "btnSvuotaCarrello";
            this.btnSvuotaCarrello.Size = new System.Drawing.Size(134, 44);
            this.btnSvuotaCarrello.TabIndex = 7;
            this.btnSvuotaCarrello.Text = "ELIMINA CARRELLO";
            this.btnSvuotaCarrello.UseVisualStyleBackColor = false;
            this.btnSvuotaCarrello.Visible = false;
            // 
            // btnAggiungiProdotto
            // 
            this.btnAggiungiProdotto.BackColor = System.Drawing.Color.Lime;
            this.btnAggiungiProdotto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungiProdotto.Location = new System.Drawing.Point(68, 168);
            this.btnAggiungiProdotto.Name = "btnAggiungiProdotto";
            this.btnAggiungiProdotto.Size = new System.Drawing.Size(134, 44);
            this.btnAggiungiProdotto.TabIndex = 6;
            this.btnAggiungiProdotto.Text = "AGGIUNGI";
            this.btnAggiungiProdotto.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantità";
            // 
            // nudQuantitàVendita
            // 
            this.nudQuantitàVendita.Location = new System.Drawing.Point(113, 98);
            this.nudQuantitàVendita.Name = "nudQuantitàVendita";
            this.nudQuantitàVendita.Size = new System.Drawing.Size(141, 22);
            this.nudQuantitàVendita.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prodotto";
            // 
            // cmbProdottoVendita
            // 
            this.cmbProdottoVendita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdottoVendita.FormattingEnabled = true;
            this.cmbProdottoVendita.Location = new System.Drawing.Point(113, 63);
            this.cmbProdottoVendita.Name = "cmbProdottoVendita";
            this.cmbProdottoVendita.Size = new System.Drawing.Size(141, 24);
            this.cmbProdottoVendita.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // cmbCategoriaVendita
            // 
            this.cmbCategoriaVendita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaVendita.FormattingEnabled = true;
            this.cmbCategoriaVendita.Location = new System.Drawing.Point(113, 31);
            this.cmbCategoriaVendita.Name = "cmbCategoriaVendita";
            this.cmbCategoriaVendita.Size = new System.Drawing.Size(141, 24);
            this.cmbCategoriaVendita.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVisualizzazioneDgv);
            this.groupBox1.Controls.Add(this.dgvVendite);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 325);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizzazione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleziona cosa visualizzare";
            // 
            // cmbVisualizzazioneDgv
            // 
            this.cmbVisualizzazioneDgv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisualizzazioneDgv.FormattingEnabled = true;
            this.cmbVisualizzazioneDgv.Location = new System.Drawing.Point(199, 25);
            this.cmbVisualizzazioneDgv.Name = "cmbVisualizzazioneDgv";
            this.cmbVisualizzazioneDgv.Size = new System.Drawing.Size(183, 24);
            this.cmbVisualizzazioneDgv.TabIndex = 2;
            this.cmbVisualizzazioneDgv.SelectedIndexChanged += new System.EventHandler(this.cmbVisualizzazioneDgv_SelectedIndexChanged);
            // 
            // FrmVendite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbVendite);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(897, 412);
            this.MinimumSize = new System.Drawing.Size(897, 412);
            this.Name = "FrmVendite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione vendite videogiochi";
            this.Load += new System.EventHandler(this.FrmVendite_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendite)).EndInit();
            this.grbVendite.ResumeLayout(false);
            this.grbVendite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantitàVendita)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodottiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvVendite;
        private System.Windows.Forms.GroupBox grbVendite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaVendita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProdottoVendita;
        private System.Windows.Forms.Button btnAggiungiProdotto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantitàVendita;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVisualizzazioneDgv;
        private System.Windows.Forms.Button btnSvuotaCarrello;
        private System.Windows.Forms.CheckBox chkModalitàEliminaProdotto;
    }
}

