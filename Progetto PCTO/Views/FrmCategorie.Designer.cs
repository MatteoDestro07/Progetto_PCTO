namespace Progetto_PCTO.Views
{
    partial class FrmCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorie));
            this.grbElimina = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEliminaCliente = new System.Windows.Forms.ComboBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.grbModificaCategoria = new System.Windows.Forms.GroupBox();
            this.txtModifica = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModificaId = new System.Windows.Forms.ComboBox();
            this.btnModificaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbModifica = new System.Windows.Forms.RadioButton();
            this.rbAggiungi = new System.Windows.Forms.RadioButton();
            this.rbElimina = new System.Windows.Forms.RadioButton();
            this.grbAggiungiCategoria = new System.Windows.Forms.GroupBox();
            this.txtDescrizioneCategoria = new System.Windows.Forms.TextBox();
            this.btnAggiungiCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbVisualizza = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodottiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbElimina.SuspendLayout();
            this.grbModificaCategoria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbAggiungiCategoria.SuspendLayout();
            this.grbVisualizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbElimina
            // 
            this.grbElimina.Controls.Add(this.label8);
            this.grbElimina.Controls.Add(this.cmbEliminaCliente);
            this.grbElimina.Controls.Add(this.btnElimina);
            this.grbElimina.Location = new System.Drawing.Point(738, 199);
            this.grbElimina.Name = "grbElimina";
            this.grbElimina.Size = new System.Drawing.Size(302, 115);
            this.grbElimina.TabIndex = 15;
            this.grbElimina.TabStop = false;
            this.grbElimina.Text = "Elimina Categoria";
            this.grbElimina.Visible = false;
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
            // grbModificaCategoria
            // 
            this.grbModificaCategoria.Controls.Add(this.txtModifica);
            this.grbModificaCategoria.Controls.Add(this.label7);
            this.grbModificaCategoria.Controls.Add(this.label2);
            this.grbModificaCategoria.Controls.Add(this.cmbModificaId);
            this.grbModificaCategoria.Controls.Add(this.btnModificaCliente);
            this.grbModificaCategoria.Location = new System.Drawing.Point(738, 158);
            this.grbModificaCategoria.Name = "grbModificaCategoria";
            this.grbModificaCategoria.Size = new System.Drawing.Size(302, 162);
            this.grbModificaCategoria.TabIndex = 14;
            this.grbModificaCategoria.TabStop = false;
            this.grbModificaCategoria.Text = "Modifica Cliente";
            this.grbModificaCategoria.Visible = false;
            // 
            // txtModifica
            // 
            this.txtModifica.Location = new System.Drawing.Point(108, 65);
            this.txtModifica.Name = "txtModifica";
            this.txtModifica.Size = new System.Drawing.Size(140, 22);
            this.txtModifica.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrizione";
            // 
            // cmbModificaId
            // 
            this.cmbModificaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificaId.FormattingEnabled = true;
            this.cmbModificaId.Location = new System.Drawing.Point(107, 27);
            this.cmbModificaId.Name = "cmbModificaId";
            this.cmbModificaId.Size = new System.Drawing.Size(140, 24);
            this.cmbModificaId.TabIndex = 7;
            this.cmbModificaId.SelectedIndexChanged += new System.EventHandler(this.cmbModificaId_SelectedIndexChanged);
            // 
            // btnModificaCliente
            // 
            this.btnModificaCliente.BackColor = System.Drawing.Color.Lime;
            this.btnModificaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificaCliente.Location = new System.Drawing.Point(85, 106);
            this.btnModificaCliente.Name = "btnModificaCliente";
            this.btnModificaCliente.Size = new System.Drawing.Size(129, 45);
            this.btnModificaCliente.TabIndex = 3;
            this.btnModificaCliente.Text = "Modifica";
            this.btnModificaCliente.UseVisualStyleBackColor = false;
            this.btnModificaCliente.Click += new System.EventHandler(this.btnModificaCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbModifica);
            this.groupBox1.Controls.Add(this.rbAggiungi);
            this.groupBox1.Controls.Add(this.rbElimina);
            this.groupBox1.Location = new System.Drawing.Point(738, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 51);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalità";
            // 
            // rbModifica
            // 
            this.rbModifica.AutoSize = true;
            this.rbModifica.Location = new System.Drawing.Point(112, 21);
            this.rbModifica.Name = "rbModifica";
            this.rbModifica.Size = new System.Drawing.Size(79, 20);
            this.rbModifica.TabIndex = 2;
            this.rbModifica.TabStop = true;
            this.rbModifica.Text = "Modifica";
            this.rbModifica.UseVisualStyleBackColor = true;
            this.rbModifica.CheckedChanged += new System.EventHandler(this.rbModifica_CheckedChanged);
            // 
            // rbAggiungi
            // 
            this.rbAggiungi.AutoSize = true;
            this.rbAggiungi.Location = new System.Drawing.Point(3, 21);
            this.rbAggiungi.Name = "rbAggiungi";
            this.rbAggiungi.Size = new System.Drawing.Size(81, 20);
            this.rbAggiungi.TabIndex = 0;
            this.rbAggiungi.TabStop = true;
            this.rbAggiungi.Text = "Aggiungi";
            this.rbAggiungi.UseVisualStyleBackColor = true;
            this.rbAggiungi.CheckedChanged += new System.EventHandler(this.rbAggiungi_CheckedChanged);
            // 
            // rbElimina
            // 
            this.rbElimina.AutoSize = true;
            this.rbElimina.Location = new System.Drawing.Point(221, 21);
            this.rbElimina.Name = "rbElimina";
            this.rbElimina.Size = new System.Drawing.Size(72, 20);
            this.rbElimina.TabIndex = 1;
            this.rbElimina.TabStop = true;
            this.rbElimina.Text = "Elimina";
            this.rbElimina.UseVisualStyleBackColor = true;
            this.rbElimina.CheckedChanged += new System.EventHandler(this.rbElimina_CheckedChanged);
            // 
            // grbAggiungiCategoria
            // 
            this.grbAggiungiCategoria.Controls.Add(this.txtDescrizioneCategoria);
            this.grbAggiungiCategoria.Controls.Add(this.btnAggiungiCategoria);
            this.grbAggiungiCategoria.Controls.Add(this.label1);
            this.grbAggiungiCategoria.Location = new System.Drawing.Point(738, 189);
            this.grbAggiungiCategoria.Name = "grbAggiungiCategoria";
            this.grbAggiungiCategoria.Size = new System.Drawing.Size(302, 131);
            this.grbAggiungiCategoria.TabIndex = 12;
            this.grbAggiungiCategoria.TabStop = false;
            this.grbAggiungiCategoria.Text = "Aggiungi Categoria";
            // 
            // txtDescrizioneCategoria
            // 
            this.txtDescrizioneCategoria.Location = new System.Drawing.Point(102, 30);
            this.txtDescrizioneCategoria.Name = "txtDescrizioneCategoria";
            this.txtDescrizioneCategoria.Size = new System.Drawing.Size(140, 22);
            this.txtDescrizioneCategoria.TabIndex = 4;
            // 
            // btnAggiungiCategoria
            // 
            this.btnAggiungiCategoria.BackColor = System.Drawing.Color.Lime;
            this.btnAggiungiCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungiCategoria.Location = new System.Drawing.Point(78, 70);
            this.btnAggiungiCategoria.Name = "btnAggiungiCategoria";
            this.btnAggiungiCategoria.Size = new System.Drawing.Size(129, 45);
            this.btnAggiungiCategoria.TabIndex = 3;
            this.btnAggiungiCategoria.Text = "Aggiungi";
            this.btnAggiungiCategoria.UseVisualStyleBackColor = false;
            this.btnAggiungiCategoria.Click += new System.EventHandler(this.btnAggiungiCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrizione";
            // 
            // grbVisualizza
            // 
            this.grbVisualizza.Controls.Add(this.dgv);
            this.grbVisualizza.Location = new System.Drawing.Point(12, 32);
            this.grbVisualizza.Name = "grbVisualizza";
            this.grbVisualizza.Size = new System.Drawing.Size(717, 426);
            this.grbVisualizza.TabIndex = 11;
            this.grbVisualizza.TabStop = false;
            this.grbVisualizza.Text = "Visualizza Categorie";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 22);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(704, 398);
            this.dgv.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 10;
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
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.categorieToolStripMenuItem.Text = "Vendite";
            // 
            // prodottiToolStripMenuItem
            // 
            this.prodottiToolStripMenuItem.Name = "prodottiToolStripMenuItem";
            this.prodottiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.prodottiToolStripMenuItem.Text = "Prodotti";
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
            // FrmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 470);
            this.Controls.Add(this.grbElimina);
            this.Controls.Add(this.grbAggiungiCategoria);
            this.Controls.Add(this.grbModificaCategoria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbVisualizza);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1068, 517);
            this.Name = "FrmCategorie";
            this.Text = "Gestione categorie videogiochi";
            this.Load += new System.EventHandler(this.FrmCategorie_Load);
            this.grbElimina.ResumeLayout(false);
            this.grbElimina.PerformLayout();
            this.grbModificaCategoria.ResumeLayout(false);
            this.grbModificaCategoria.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbAggiungiCategoria.ResumeLayout(false);
            this.grbAggiungiCategoria.PerformLayout();
            this.grbVisualizza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbElimina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEliminaCliente;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.GroupBox grbModificaCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModificaId;
        private System.Windows.Forms.Button btnModificaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbModifica;
        private System.Windows.Forms.RadioButton rbAggiungi;
        private System.Windows.Forms.RadioButton rbElimina;
        private System.Windows.Forms.GroupBox grbAggiungiCategoria;
        private System.Windows.Forms.TextBox txtDescrizioneCategoria;
        private System.Windows.Forms.Button btnAggiungiCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbVisualizza;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodottiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txtModifica;
        private System.Windows.Forms.Label label2;
    }
}