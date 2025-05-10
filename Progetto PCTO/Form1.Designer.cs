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
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnSvuotaCarrello = new System.Windows.Forms.Button();
            this.grbCarrello = new System.Windows.Forms.GroupBox();
            this.dgvCarrello = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCategoriaProdotto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQuantitaProdotto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNomeProdottoModifica = new System.Windows.Forms.ComboBox();
            this.grbEliminaProdotto = new System.Windows.Forms.GroupBox();
            this.btnEliminaProdotto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEliminaProdotto = new System.Windows.Forms.ComboBox();
            this.btnConfermaAcquisto = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendite)).BeginInit();
            this.grbVendite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantitàVendita)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbCarrello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrello)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantitaProdotto)).BeginInit();
            this.grbEliminaProdotto.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(972, 28);
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
            this.dgvVendite.Size = new System.Drawing.Size(601, 338);
            this.dgvVendite.TabIndex = 1;
            // 
            // grbVendite
            // 
            this.grbVendite.Controls.Add(this.lblPrezzo);
            this.grbVendite.Controls.Add(this.label8);
            this.grbVendite.Controls.Add(this.btnAggiungiProdotto);
            this.grbVendite.Controls.Add(this.label3);
            this.grbVendite.Controls.Add(this.nudQuantitàVendita);
            this.grbVendite.Controls.Add(this.label2);
            this.grbVendite.Controls.Add(this.cmbProdottoVendita);
            this.grbVendite.Controls.Add(this.label1);
            this.grbVendite.Controls.Add(this.cmbCategoriaVendita);
            this.grbVendite.Location = new System.Drawing.Point(634, 32);
            this.grbVendite.Name = "grbVendite";
            this.grbVendite.Size = new System.Drawing.Size(327, 233);
            this.grbVendite.TabIndex = 2;
            this.grbVendite.TabStop = false;
            this.grbVendite.Text = "Acquista Prodotto";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezzo.ForeColor = System.Drawing.Color.Blue;
            this.lblPrezzo.Location = new System.Drawing.Point(110, 135);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(55, 16);
            this.lblPrezzo.TabIndex = 8;
            this.lblPrezzo.Text = "XXXX €";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Prezzo";
            // 
            // btnAggiungiProdotto
            // 
            this.btnAggiungiProdotto.BackColor = System.Drawing.Color.Lime;
            this.btnAggiungiProdotto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungiProdotto.Location = new System.Drawing.Point(73, 171);
            this.btnAggiungiProdotto.Name = "btnAggiungiProdotto";
            this.btnAggiungiProdotto.Size = new System.Drawing.Size(194, 44);
            this.btnAggiungiProdotto.TabIndex = 6;
            this.btnAggiungiProdotto.Text = "AGGIUNGI AL CARRELLO";
            this.btnAggiungiProdotto.UseVisualStyleBackColor = false;
            this.btnAggiungiProdotto.Click += new System.EventHandler(this.btnAggiungiProdotto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantità";
            // 
            // nudQuantitàVendita
            // 
            this.nudQuantitàVendita.Location = new System.Drawing.Point(113, 98);
            this.nudQuantitàVendita.Name = "nudQuantitàVendita";
            this.nudQuantitàVendita.Size = new System.Drawing.Size(195, 22);
            this.nudQuantitàVendita.TabIndex = 4;
            this.nudQuantitàVendita.ValueChanged += new System.EventHandler(this.nudQuantitàVendita_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
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
            this.cmbProdottoVendita.Size = new System.Drawing.Size(195, 24);
            this.cmbProdottoVendita.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
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
            this.cmbCategoriaVendita.Size = new System.Drawing.Size(195, 24);
            this.cmbCategoriaVendita.TabIndex = 0;
            this.cmbCategoriaVendita.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaVendita_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVisualizzazioneDgv);
            this.groupBox1.Controls.Add(this.dgvVendite);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 405);
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
            // btnSvuotaCarrello
            // 
            this.btnSvuotaCarrello.BackColor = System.Drawing.Color.Red;
            this.btnSvuotaCarrello.Location = new System.Drawing.Point(798, 612);
            this.btnSvuotaCarrello.Name = "btnSvuotaCarrello";
            this.btnSvuotaCarrello.Size = new System.Drawing.Size(163, 44);
            this.btnSvuotaCarrello.TabIndex = 4;
            this.btnSvuotaCarrello.Text = "SVUOTA CARRELLO";
            this.btnSvuotaCarrello.UseVisualStyleBackColor = false;
            this.btnSvuotaCarrello.Click += new System.EventHandler(this.btnSvuotaCarrello_Click);
            // 
            // grbCarrello
            // 
            this.grbCarrello.Controls.Add(this.dgvCarrello);
            this.grbCarrello.Location = new System.Drawing.Point(9, 443);
            this.grbCarrello.Name = "grbCarrello";
            this.grbCarrello.Size = new System.Drawing.Size(619, 372);
            this.grbCarrello.TabIndex = 5;
            this.grbCarrello.TabStop = false;
            this.grbCarrello.Text = "Carrello";
            // 
            // dgvCarrello
            // 
            this.dgvCarrello.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrello.Location = new System.Drawing.Point(6, 24);
            this.dgvCarrello.Name = "dgvCarrello";
            this.dgvCarrello.RowHeadersWidth = 51;
            this.dgvCarrello.RowTemplate.Height = 24;
            this.dgvCarrello.Size = new System.Drawing.Size(604, 338);
            this.dgvCarrello.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCategoriaProdotto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnModifica);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudQuantitaProdotto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbNomeProdottoModifica);
            this.groupBox2.Location = new System.Drawing.Point(634, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 194);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifica prodotto nel carrello";
            // 
            // lblCategoriaProdotto
            // 
            this.lblCategoriaProdotto.AutoSize = true;
            this.lblCategoriaProdotto.Location = new System.Drawing.Point(116, 65);
            this.lblCategoriaProdotto.Name = "lblCategoriaProdotto";
            this.lblCategoriaProdotto.Size = new System.Drawing.Size(39, 16);
            this.lblCategoriaProdotto.TabIndex = 9;
            this.lblCategoriaProdotto.Text = "XXXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nome prodotto";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModifica.Location = new System.Drawing.Point(73, 132);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(194, 44);
            this.btnModifica.TabIndex = 6;
            this.btnModifica.Text = "MODIFICA PRODOTTO";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantità";
            // 
            // nudQuantitaProdotto
            // 
            this.nudQuantitaProdotto.Location = new System.Drawing.Point(119, 94);
            this.nudQuantitaProdotto.Name = "nudQuantitaProdotto";
            this.nudQuantitaProdotto.Size = new System.Drawing.Size(195, 22);
            this.nudQuantitaProdotto.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoria";
            // 
            // cmbNomeProdottoModifica
            // 
            this.cmbNomeProdottoModifica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeProdottoModifica.FormattingEnabled = true;
            this.cmbNomeProdottoModifica.Location = new System.Drawing.Point(119, 27);
            this.cmbNomeProdottoModifica.Name = "cmbNomeProdottoModifica";
            this.cmbNomeProdottoModifica.Size = new System.Drawing.Size(195, 24);
            this.cmbNomeProdottoModifica.TabIndex = 0;
            this.cmbNomeProdottoModifica.SelectedIndexChanged += new System.EventHandler(this.cmbNomeProdottoModifica_SelectedIndexChanged);
            // 
            // grbEliminaProdotto
            // 
            this.grbEliminaProdotto.Controls.Add(this.btnEliminaProdotto);
            this.grbEliminaProdotto.Controls.Add(this.label11);
            this.grbEliminaProdotto.Controls.Add(this.cmbEliminaProdotto);
            this.grbEliminaProdotto.Location = new System.Drawing.Point(635, 471);
            this.grbEliminaProdotto.Name = "grbEliminaProdotto";
            this.grbEliminaProdotto.Size = new System.Drawing.Size(326, 135);
            this.grbEliminaProdotto.TabIndex = 8;
            this.grbEliminaProdotto.TabStop = false;
            this.grbEliminaProdotto.Text = "Elimina prodotto";
            // 
            // btnEliminaProdotto
            // 
            this.btnEliminaProdotto.BackColor = System.Drawing.Color.Red;
            this.btnEliminaProdotto.Location = new System.Drawing.Point(90, 69);
            this.btnEliminaProdotto.Name = "btnEliminaProdotto";
            this.btnEliminaProdotto.Size = new System.Drawing.Size(139, 44);
            this.btnEliminaProdotto.TabIndex = 9;
            this.btnEliminaProdotto.Text = "ELIMINA DAL CARRELLO";
            this.btnEliminaProdotto.UseVisualStyleBackColor = false;
            this.btnEliminaProdotto.Click += new System.EventHandler(this.btnEliminaProdotto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nome prodotto";
            // 
            // cmbEliminaProdotto
            // 
            this.cmbEliminaProdotto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminaProdotto.FormattingEnabled = true;
            this.cmbEliminaProdotto.Location = new System.Drawing.Point(125, 24);
            this.cmbEliminaProdotto.Name = "cmbEliminaProdotto";
            this.cmbEliminaProdotto.Size = new System.Drawing.Size(195, 24);
            this.cmbEliminaProdotto.TabIndex = 11;
            // 
            // btnConfermaAcquisto
            // 
            this.btnConfermaAcquisto.BackColor = System.Drawing.Color.Lime;
            this.btnConfermaAcquisto.Location = new System.Drawing.Point(634, 612);
            this.btnConfermaAcquisto.Name = "btnConfermaAcquisto";
            this.btnConfermaAcquisto.Size = new System.Drawing.Size(163, 44);
            this.btnConfermaAcquisto.TabIndex = 9;
            this.btnConfermaAcquisto.Text = "CONFERMA ACQUISTO";
            this.btnConfermaAcquisto.UseVisualStyleBackColor = false;
            // 
            // FrmVendite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 823);
            this.Controls.Add(this.btnConfermaAcquisto);
            this.Controls.Add(this.grbEliminaProdotto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbCarrello);
            this.Controls.Add(this.btnSvuotaCarrello);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbVendite);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(990, 870);
            this.MinimumSize = new System.Drawing.Size(990, 870);
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
            this.grbCarrello.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrello)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantitaProdotto)).EndInit();
            this.grbEliminaProdotto.ResumeLayout(false);
            this.grbEliminaProdotto.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbCarrello;
        private System.Windows.Forms.DataGridView dgvCarrello;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQuantitaProdotto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNomeProdottoModifica;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCategoriaProdotto;
        private System.Windows.Forms.GroupBox grbEliminaProdotto;
        private System.Windows.Forms.Button btnEliminaProdotto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEliminaProdotto;
        private System.Windows.Forms.Button btnConfermaAcquisto;
    }
}

