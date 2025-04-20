namespace Progetto_PCTO.Views
{
    partial class FrmClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienti));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodottiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbVisualizzaClienti = new System.Windows.Forms.GroupBox();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.grbAggiungiModificaEliminaClienti = new System.Windows.Forms.GroupBox();
            this.rbModificaCliente = new System.Windows.Forms.RadioButton();
            this.rbEliminaCliente = new System.Windows.Forms.RadioButton();
            this.rbAggiungiCliente = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.grbVisualizzaClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.grbAggiungiModificaEliminaClienti.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientiToolStripMenuItem.Text = "Vendite";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.categorieToolStripMenuItem.Text = "Categorie";
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
            // grbVisualizzaClienti
            // 
            this.grbVisualizzaClienti.Controls.Add(this.dgvClienti);
            this.grbVisualizzaClienti.Location = new System.Drawing.Point(13, 32);
            this.grbVisualizzaClienti.Name = "grbVisualizzaClienti";
            this.grbVisualizzaClienti.Size = new System.Drawing.Size(717, 426);
            this.grbVisualizzaClienti.TabIndex = 2;
            this.grbVisualizzaClienti.TabStop = false;
            this.grbVisualizzaClienti.Text = "Visualizza Clienti";
            // 
            // dgvClienti
            // 
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(7, 22);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.RowHeadersWidth = 51;
            this.dgvClienti.RowTemplate.Height = 24;
            this.dgvClienti.Size = new System.Drawing.Size(710, 398);
            this.dgvClienti.TabIndex = 0;
            // 
            // grbAggiungiModificaEliminaClienti
            // 
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.rbModificaCliente);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.rbEliminaCliente);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.rbAggiungiCliente);
            this.grbAggiungiModificaEliminaClienti.Location = new System.Drawing.Point(736, 34);
            this.grbAggiungiModificaEliminaClienti.Name = "grbAggiungiModificaEliminaClienti";
            this.grbAggiungiModificaEliminaClienti.Size = new System.Drawing.Size(302, 418);
            this.grbAggiungiModificaEliminaClienti.TabIndex = 3;
            this.grbAggiungiModificaEliminaClienti.TabStop = false;
            this.grbAggiungiModificaEliminaClienti.Text = "Aggiungi Cliente";
            // 
            // rbModificaCliente
            // 
            this.rbModificaCliente.AutoSize = true;
            this.rbModificaCliente.Location = new System.Drawing.Point(115, 392);
            this.rbModificaCliente.Name = "rbModificaCliente";
            this.rbModificaCliente.Size = new System.Drawing.Size(79, 20);
            this.rbModificaCliente.TabIndex = 2;
            this.rbModificaCliente.TabStop = true;
            this.rbModificaCliente.Text = "Modifica";
            this.rbModificaCliente.UseVisualStyleBackColor = true;
            // 
            // rbEliminaCliente
            // 
            this.rbEliminaCliente.AutoSize = true;
            this.rbEliminaCliente.Location = new System.Drawing.Point(224, 392);
            this.rbEliminaCliente.Name = "rbEliminaCliente";
            this.rbEliminaCliente.Size = new System.Drawing.Size(72, 20);
            this.rbEliminaCliente.TabIndex = 1;
            this.rbEliminaCliente.TabStop = true;
            this.rbEliminaCliente.Text = "Elimina";
            this.rbEliminaCliente.UseVisualStyleBackColor = true;
            // 
            // rbAggiungiCliente
            // 
            this.rbAggiungiCliente.AutoSize = true;
            this.rbAggiungiCliente.Location = new System.Drawing.Point(6, 392);
            this.rbAggiungiCliente.Name = "rbAggiungiCliente";
            this.rbAggiungiCliente.Size = new System.Drawing.Size(81, 20);
            this.rbAggiungiCliente.TabIndex = 0;
            this.rbAggiungiCliente.TabStop = true;
            this.rbAggiungiCliente.Text = "Aggiungi";
            this.rbAggiungiCliente.UseVisualStyleBackColor = true;
            // 
            // FrmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 470);
            this.Controls.Add(this.grbAggiungiModificaEliminaClienti);
            this.Controls.Add(this.grbVisualizzaClienti);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClienti";
            this.Text = "Gestione Clienti";
            this.Load += new System.EventHandler(this.FrmClienti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbVisualizzaClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.grbAggiungiModificaEliminaClienti.ResumeLayout(false);
            this.grbAggiungiModificaEliminaClienti.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbVisualizzaClienti;
        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.GroupBox grbAggiungiModificaEliminaClienti;
        private System.Windows.Forms.RadioButton rbModificaCliente;
        private System.Windows.Forms.RadioButton rbEliminaCliente;
        private System.Windows.Forms.RadioButton rbAggiungiCliente;
    }
}