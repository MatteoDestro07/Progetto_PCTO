namespace Progetto_PCTO.Views
{
    partial class FrmProdotti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdotti));
            this.grbElimina = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEliminaCliente = new System.Windows.Forms.ComboBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.grbAggiungi = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudQuantita = new System.Windows.Forms.NumericUpDown();
            this.cmbIdCategoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAggiungiURLimmagine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPrezzoUnitario = new System.Windows.Forms.NumericUpDown();
            this.txtAggiungiDescrizione = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prodottiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picImmagineProdotto = new System.Windows.Forms.PictureBox();
            this.grbVisualizza = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnModifica = new System.Windows.Forms.Button();
            this.cmbModificaId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModificaDescrizione = new System.Windows.Forms.TextBox();
            this.nudModificaPrezzoUnitario = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModificaURLimmagine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModificaCategoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudModificaQuantita = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.grbModifica = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbIdImmagineDaVisualizzare = new System.Windows.Forms.ComboBox();
            this.grbElimina.SuspendLayout();
            this.grbAggiungi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoUnitario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImmagineProdotto)).BeginInit();
            this.grbVisualizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaPrezzoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaQuantita)).BeginInit();
            this.grbModifica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbElimina
            // 
            this.grbElimina.Controls.Add(this.label8);
            this.grbElimina.Controls.Add(this.cmbEliminaCliente);
            this.grbElimina.Controls.Add(this.btnElimina);
            this.grbElimina.Location = new System.Drawing.Point(634, 464);
            this.grbElimina.Name = "grbElimina";
            this.grbElimina.Size = new System.Drawing.Size(302, 115);
            this.grbElimina.TabIndex = 21;
            this.grbElimina.TabStop = false;
            this.grbElimina.Text = "Elimina Prodotto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Id";
            // 
            // cmbEliminaCliente
            // 
            this.cmbEliminaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminaCliente.FormattingEnabled = true;
            this.cmbEliminaCliente.Location = new System.Drawing.Point(107, 27);
            this.cmbEliminaCliente.Name = "cmbEliminaCliente";
            this.cmbEliminaCliente.Size = new System.Drawing.Size(140, 24);
            this.cmbEliminaCliente.TabIndex = 7;
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.Red;
            this.btnElimina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnElimina.Location = new System.Drawing.Point(84, 66);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(129, 45);
            this.btnElimina.TabIndex = 3;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // grbAggiungi
            // 
            this.grbAggiungi.Controls.Add(this.label11);
            this.grbAggiungi.Controls.Add(this.nudQuantita);
            this.grbAggiungi.Controls.Add(this.cmbIdCategoria);
            this.grbAggiungi.Controls.Add(this.label9);
            this.grbAggiungi.Controls.Add(this.label4);
            this.grbAggiungi.Controls.Add(this.txtAggiungiURLimmagine);
            this.grbAggiungi.Controls.Add(this.label3);
            this.grbAggiungi.Controls.Add(this.nudPrezzoUnitario);
            this.grbAggiungi.Controls.Add(this.txtAggiungiDescrizione);
            this.grbAggiungi.Controls.Add(this.btnAggiungi);
            this.grbAggiungi.Controls.Add(this.label1);
            this.grbAggiungi.Location = new System.Drawing.Point(18, 460);
            this.grbAggiungi.Name = "grbAggiungi";
            this.grbAggiungi.Size = new System.Drawing.Size(302, 255);
            this.grbAggiungi.TabIndex = 18;
            this.grbAggiungi.TabStop = false;
            this.grbAggiungi.Text = "Aggiungi Prodotto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Quantità";
            // 
            // nudQuantita
            // 
            this.nudQuantita.Location = new System.Drawing.Point(126, 90);
            this.nudQuantita.Name = "nudQuantita";
            this.nudQuantita.Size = new System.Drawing.Size(140, 22);
            this.nudQuantita.TabIndex = 16;
            // 
            // cmbIdCategoria
            // 
            this.cmbIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCategoria.FormattingEnabled = true;
            this.cmbIdCategoria.Location = new System.Drawing.Point(126, 30);
            this.cmbIdCategoria.Name = "cmbIdCategoria";
            this.cmbIdCategoria.Size = new System.Drawing.Size(140, 24);
            this.cmbIdCategoria.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL immagine";
            // 
            // txtAggiungiURLimmagine
            // 
            this.txtAggiungiURLimmagine.Location = new System.Drawing.Point(126, 150);
            this.txtAggiungiURLimmagine.Name = "txtAggiungiURLimmagine";
            this.txtAggiungiURLimmagine.Size = new System.Drawing.Size(140, 22);
            this.txtAggiungiURLimmagine.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezzo unitario";
            // 
            // nudPrezzoUnitario
            // 
            this.nudPrezzoUnitario.Location = new System.Drawing.Point(126, 120);
            this.nudPrezzoUnitario.Name = "nudPrezzoUnitario";
            this.nudPrezzoUnitario.Size = new System.Drawing.Size(140, 22);
            this.nudPrezzoUnitario.TabIndex = 5;
            // 
            // txtAggiungiDescrizione
            // 
            this.txtAggiungiDescrizione.Location = new System.Drawing.Point(126, 62);
            this.txtAggiungiDescrizione.Name = "txtAggiungiDescrizione";
            this.txtAggiungiDescrizione.Size = new System.Drawing.Size(140, 22);
            this.txtAggiungiDescrizione.TabIndex = 4;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Lime;
            this.btnAggiungi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungi.Location = new System.Drawing.Point(84, 189);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(129, 45);
            this.btnAggiungi.TabIndex = 3;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrizione";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prodottiToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.categorieToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prodottiToolStripMenuItem
            // 
            this.prodottiToolStripMenuItem.Name = "prodottiToolStripMenuItem";
            this.prodottiToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.prodottiToolStripMenuItem.Text = "Categorie";
            this.prodottiToolStripMenuItem.Click += new System.EventHandler(this.prodottiToolStripMenuItem_Click);
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
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.categorieToolStripMenuItem.Text = "Vendite";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
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
            // picImmagineProdotto
            // 
            this.picImmagineProdotto.BackColor = System.Drawing.Color.Gray;
            this.picImmagineProdotto.Location = new System.Drawing.Point(6, 52);
            this.picImmagineProdotto.Name = "picImmagineProdotto";
            this.picImmagineProdotto.Size = new System.Drawing.Size(296, 365);
            this.picImmagineProdotto.TabIndex = 22;
            this.picImmagineProdotto.TabStop = false;
            // 
            // grbVisualizza
            // 
            this.grbVisualizza.Controls.Add(this.dgv);
            this.grbVisualizza.Location = new System.Drawing.Point(12, 31);
            this.grbVisualizza.Name = "grbVisualizza";
            this.grbVisualizza.Size = new System.Drawing.Size(783, 423);
            this.grbVisualizza.TabIndex = 23;
            this.grbVisualizza.TabStop = false;
            this.grbVisualizza.Text = "Visualizza lista prodotti";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(771, 396);
            this.dgv.TabIndex = 0;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Lime;
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModifica.Location = new System.Drawing.Point(87, 227);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(129, 45);
            this.btnModifica.TabIndex = 3;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // cmbModificaId
            // 
            this.cmbModificaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificaId.FormattingEnabled = true;
            this.cmbModificaId.Location = new System.Drawing.Point(123, 30);
            this.cmbModificaId.Name = "cmbModificaId";
            this.cmbModificaId.Size = new System.Drawing.Size(140, 24);
            this.cmbModificaId.TabIndex = 7;
            this.cmbModificaId.SelectedIndexChanged += new System.EventHandler(this.cmbModificaId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descrizione";
            // 
            // txtModificaDescrizione
            // 
            this.txtModificaDescrizione.Location = new System.Drawing.Point(123, 120);
            this.txtModificaDescrizione.Name = "txtModificaDescrizione";
            this.txtModificaDescrizione.Size = new System.Drawing.Size(140, 22);
            this.txtModificaDescrizione.TabIndex = 10;
            // 
            // nudModificaPrezzoUnitario
            // 
            this.nudModificaPrezzoUnitario.Location = new System.Drawing.Point(123, 150);
            this.nudModificaPrezzoUnitario.Name = "nudModificaPrezzoUnitario";
            this.nudModificaPrezzoUnitario.Size = new System.Drawing.Size(140, 22);
            this.nudModificaPrezzoUnitario.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prezzo unitario";
            // 
            // txtModificaURLimmagine
            // 
            this.txtModificaURLimmagine.Location = new System.Drawing.Point(123, 180);
            this.txtModificaURLimmagine.Name = "txtModificaURLimmagine";
            this.txtModificaURLimmagine.Size = new System.Drawing.Size(140, 22);
            this.txtModificaURLimmagine.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "URL immagine";
            // 
            // cmbModificaCategoria
            // 
            this.cmbModificaCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificaCategoria.FormattingEnabled = true;
            this.cmbModificaCategoria.Location = new System.Drawing.Point(123, 60);
            this.cmbModificaCategoria.Name = "cmbModificaCategoria";
            this.cmbModificaCategoria.Size = new System.Drawing.Size(140, 24);
            this.cmbModificaCategoria.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Id Categoria";
            // 
            // nudModificaQuantita
            // 
            this.nudModificaQuantita.Location = new System.Drawing.Point(123, 90);
            this.nudModificaQuantita.Name = "nudModificaQuantita";
            this.nudModificaQuantita.Size = new System.Drawing.Size(140, 22);
            this.nudModificaQuantita.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Quantità";
            // 
            // grbModifica
            // 
            this.grbModifica.Controls.Add(this.label12);
            this.grbModifica.Controls.Add(this.nudModificaQuantita);
            this.grbModifica.Controls.Add(this.label10);
            this.grbModifica.Controls.Add(this.cmbModificaCategoria);
            this.grbModifica.Controls.Add(this.label2);
            this.grbModifica.Controls.Add(this.txtModificaURLimmagine);
            this.grbModifica.Controls.Add(this.label5);
            this.grbModifica.Controls.Add(this.nudModificaPrezzoUnitario);
            this.grbModifica.Controls.Add(this.txtModificaDescrizione);
            this.grbModifica.Controls.Add(this.label6);
            this.grbModifica.Controls.Add(this.label7);
            this.grbModifica.Controls.Add(this.cmbModificaId);
            this.grbModifica.Controls.Add(this.btnModifica);
            this.grbModifica.Location = new System.Drawing.Point(326, 460);
            this.grbModifica.Name = "grbModifica";
            this.grbModifica.Size = new System.Drawing.Size(302, 286);
            this.grbModifica.TabIndex = 20;
            this.grbModifica.TabStop = false;
            this.grbModifica.Text = "Modifica prodotto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbIdImmagineDaVisualizzare);
            this.groupBox2.Controls.Add(this.picImmagineProdotto);
            this.groupBox2.Location = new System.Drawing.Point(802, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 423);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleziona prodotto da visualizzare";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Id";
            // 
            // cmbIdImmagineDaVisualizzare
            // 
            this.cmbIdImmagineDaVisualizzare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdImmagineDaVisualizzare.FormattingEnabled = true;
            this.cmbIdImmagineDaVisualizzare.Location = new System.Drawing.Point(116, 22);
            this.cmbIdImmagineDaVisualizzare.Name = "cmbIdImmagineDaVisualizzare";
            this.cmbIdImmagineDaVisualizzare.Size = new System.Drawing.Size(147, 24);
            this.cmbIdImmagineDaVisualizzare.TabIndex = 23;
            this.cmbIdImmagineDaVisualizzare.SelectedIndexChanged += new System.EventHandler(this.cmbIdImmagineDaVisualizzare_SelectedIndexChanged);
            // 
            // FrmProdotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 763);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbVisualizza);
            this.Controls.Add(this.grbElimina);
            this.Controls.Add(this.grbModifica);
            this.Controls.Add(this.grbAggiungi);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1140, 810);
            this.MinimumSize = new System.Drawing.Size(1140, 810);
            this.Name = "FrmProdotti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione prodotti";
            this.Load += new System.EventHandler(this.FrmProdotti_Load);
            this.grbElimina.ResumeLayout(false);
            this.grbElimina.PerformLayout();
            this.grbAggiungi.ResumeLayout(false);
            this.grbAggiungi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoUnitario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImmagineProdotto)).EndInit();
            this.grbVisualizza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaPrezzoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaQuantita)).EndInit();
            this.grbModifica.ResumeLayout(false);
            this.grbModifica.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbElimina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEliminaCliente;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.GroupBox grbAggiungi;
        private System.Windows.Forms.TextBox txtAggiungiDescrizione;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prodottiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox picImmagineProdotto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrezzoUnitario;
        private System.Windows.Forms.GroupBox grbVisualizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAggiungiURLimmagine;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbIdCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudQuantita;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.ComboBox cmbModificaId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModificaDescrizione;
        private System.Windows.Forms.NumericUpDown nudModificaPrezzoUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModificaURLimmagine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModificaCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudModificaQuantita;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbModifica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbIdImmagineDaVisualizzare;
    }
}