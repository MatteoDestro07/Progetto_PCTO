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
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAggiungiModificaElimina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbModificaCliente = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModificaId = new System.Windows.Forms.ComboBox();
            this.txtCognomeModifica = new System.Windows.Forms.TextBox();
            this.txtEmailModifica = new System.Windows.Forms.TextBox();
            this.txtNomeModifica = new System.Windows.Forms.TextBox();
            this.btnModificaCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbModificaCliente = new System.Windows.Forms.RadioButton();
            this.rbEliminaCliente = new System.Windows.Forms.RadioButton();
            this.rbAggiungiCliente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbEliminaCliente = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEliminaCliente = new System.Windows.Forms.ComboBox();
            this.btnEliminaCliente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbVisualizzaClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.grbAggiungiModificaEliminaClienti.SuspendLayout();
            this.grbModificaCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbEliminaCliente.SuspendLayout();
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
            this.dgvClienti.Size = new System.Drawing.Size(704, 398);
            this.dgvClienti.TabIndex = 0;
            // 
            // grbAggiungiModificaEliminaClienti
            // 
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.txtCognome);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.txtEmail);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.txtNome);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.btnAggiungiModificaElimina);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.label3);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.label2);
            this.grbAggiungiModificaEliminaClienti.Controls.Add(this.label1);
            this.grbAggiungiModificaEliminaClienti.Location = new System.Drawing.Point(736, 116);
            this.grbAggiungiModificaEliminaClienti.Name = "grbAggiungiModificaEliminaClienti";
            this.grbAggiungiModificaEliminaClienti.Size = new System.Drawing.Size(302, 205);
            this.grbAggiungiModificaEliminaClienti.TabIndex = 3;
            this.grbAggiungiModificaEliminaClienti.TabStop = false;
            this.grbAggiungiModificaEliminaClienti.Text = "Aggiungi Cliente";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(102, 60);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(140, 22);
            this.txtCognome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 22);
            this.txtNome.TabIndex = 4;
            // 
            // btnAggiungiModificaElimina
            // 
            this.btnAggiungiModificaElimina.BackColor = System.Drawing.Color.Lime;
            this.btnAggiungiModificaElimina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungiModificaElimina.Location = new System.Drawing.Point(78, 136);
            this.btnAggiungiModificaElimina.Name = "btnAggiungiModificaElimina";
            this.btnAggiungiModificaElimina.Size = new System.Drawing.Size(129, 45);
            this.btnAggiungiModificaElimina.TabIndex = 3;
            this.btnAggiungiModificaElimina.Text = "Aggiungi";
            this.btnAggiungiModificaElimina.UseVisualStyleBackColor = false;
            this.btnAggiungiModificaElimina.Click += new System.EventHandler(this.btnAggiungiModificaElimina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // grbModificaCliente
            // 
            this.grbModificaCliente.Controls.Add(this.label7);
            this.grbModificaCliente.Controls.Add(this.cmbModificaId);
            this.grbModificaCliente.Controls.Add(this.txtCognomeModifica);
            this.grbModificaCliente.Controls.Add(this.txtEmailModifica);
            this.grbModificaCliente.Controls.Add(this.txtNomeModifica);
            this.grbModificaCliente.Controls.Add(this.btnModificaCliente);
            this.grbModificaCliente.Controls.Add(this.label4);
            this.grbModificaCliente.Controls.Add(this.label5);
            this.grbModificaCliente.Controls.Add(this.label6);
            this.grbModificaCliente.Location = new System.Drawing.Point(736, 116);
            this.grbModificaCliente.Name = "grbModificaCliente";
            this.grbModificaCliente.Size = new System.Drawing.Size(302, 205);
            this.grbModificaCliente.TabIndex = 7;
            this.grbModificaCliente.TabStop = false;
            this.grbModificaCliente.Text = "Modifica Cliente";
            this.grbModificaCliente.Visible = false;
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
            // txtCognomeModifica
            // 
            this.txtCognomeModifica.Location = new System.Drawing.Point(107, 87);
            this.txtCognomeModifica.Name = "txtCognomeModifica";
            this.txtCognomeModifica.Size = new System.Drawing.Size(140, 22);
            this.txtCognomeModifica.TabIndex = 6;
            // 
            // txtEmailModifica
            // 
            this.txtEmailModifica.Location = new System.Drawing.Point(107, 117);
            this.txtEmailModifica.Name = "txtEmailModifica";
            this.txtEmailModifica.Size = new System.Drawing.Size(140, 22);
            this.txtEmailModifica.TabIndex = 5;
            // 
            // txtNomeModifica
            // 
            this.txtNomeModifica.Location = new System.Drawing.Point(107, 57);
            this.txtNomeModifica.Name = "txtNomeModifica";
            this.txtNomeModifica.Size = new System.Drawing.Size(140, 22);
            this.txtNomeModifica.TabIndex = 4;
            // 
            // btnModificaCliente
            // 
            this.btnModificaCliente.BackColor = System.Drawing.Color.Lime;
            this.btnModificaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificaCliente.Location = new System.Drawing.Point(84, 147);
            this.btnModificaCliente.Name = "btnModificaCliente";
            this.btnModificaCliente.Size = new System.Drawing.Size(129, 45);
            this.btnModificaCliente.TabIndex = 3;
            this.btnModificaCliente.Text = "Modifica";
            this.btnModificaCliente.UseVisualStyleBackColor = false;
            this.btnModificaCliente.Click += new System.EventHandler(this.btnModificaCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cognome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome";
            // 
            // rbModificaCliente
            // 
            this.rbModificaCliente.AutoSize = true;
            this.rbModificaCliente.Location = new System.Drawing.Point(112, 21);
            this.rbModificaCliente.Name = "rbModificaCliente";
            this.rbModificaCliente.Size = new System.Drawing.Size(79, 20);
            this.rbModificaCliente.TabIndex = 2;
            this.rbModificaCliente.TabStop = true;
            this.rbModificaCliente.Text = "Modifica";
            this.rbModificaCliente.UseVisualStyleBackColor = true;
            this.rbModificaCliente.CheckedChanged += new System.EventHandler(this.rbModificaCliente_CheckedChanged);
            // 
            // rbEliminaCliente
            // 
            this.rbEliminaCliente.AutoSize = true;
            this.rbEliminaCliente.Location = new System.Drawing.Point(221, 21);
            this.rbEliminaCliente.Name = "rbEliminaCliente";
            this.rbEliminaCliente.Size = new System.Drawing.Size(72, 20);
            this.rbEliminaCliente.TabIndex = 1;
            this.rbEliminaCliente.TabStop = true;
            this.rbEliminaCliente.Text = "Elimina";
            this.rbEliminaCliente.UseVisualStyleBackColor = true;
            this.rbEliminaCliente.CheckedChanged += new System.EventHandler(this.rbEliminaCliente_CheckedChanged);
            // 
            // rbAggiungiCliente
            // 
            this.rbAggiungiCliente.AutoSize = true;
            this.rbAggiungiCliente.Location = new System.Drawing.Point(3, 21);
            this.rbAggiungiCliente.Name = "rbAggiungiCliente";
            this.rbAggiungiCliente.Size = new System.Drawing.Size(81, 20);
            this.rbAggiungiCliente.TabIndex = 0;
            this.rbAggiungiCliente.TabStop = true;
            this.rbAggiungiCliente.Text = "Aggiungi";
            this.rbAggiungiCliente.UseVisualStyleBackColor = true;
            this.rbAggiungiCliente.CheckedChanged += new System.EventHandler(this.rbAggiungiCliente_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbModificaCliente);
            this.groupBox1.Controls.Add(this.rbAggiungiCliente);
            this.groupBox1.Controls.Add(this.rbEliminaCliente);
            this.groupBox1.Location = new System.Drawing.Point(736, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalità";
            // 
            // grbEliminaCliente
            // 
            this.grbEliminaCliente.Controls.Add(this.label8);
            this.grbEliminaCliente.Controls.Add(this.cmbEliminaCliente);
            this.grbEliminaCliente.Controls.Add(this.btnEliminaCliente);
            this.grbEliminaCliente.Location = new System.Drawing.Point(736, 206);
            this.grbEliminaCliente.Name = "grbEliminaCliente";
            this.grbEliminaCliente.Size = new System.Drawing.Size(302, 115);
            this.grbEliminaCliente.TabIndex = 9;
            this.grbEliminaCliente.TabStop = false;
            this.grbEliminaCliente.Text = "Elimina Cliente";
            this.grbEliminaCliente.Visible = false;
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
            // btnEliminaCliente
            // 
            this.btnEliminaCliente.BackColor = System.Drawing.Color.Red;
            this.btnEliminaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminaCliente.Location = new System.Drawing.Point(84, 66);
            this.btnEliminaCliente.Name = "btnEliminaCliente";
            this.btnEliminaCliente.Size = new System.Drawing.Size(129, 45);
            this.btnEliminaCliente.TabIndex = 3;
            this.btnEliminaCliente.Text = "Elimina";
            this.btnEliminaCliente.UseVisualStyleBackColor = false;
            this.btnEliminaCliente.Click += new System.EventHandler(this.btnEliminaCliente_Click);
            // 
            // FrmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 470);
            this.Controls.Add(this.grbEliminaCliente);
            this.Controls.Add(this.grbModificaCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAggiungiModificaEliminaClienti);
            this.Controls.Add(this.grbVisualizzaClienti);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1068, 517);
            this.MinimumSize = new System.Drawing.Size(1068, 517);
            this.Name = "FrmClienti";
            this.Text = "Gestione clienti";
            this.Load += new System.EventHandler(this.FrmClienti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbVisualizzaClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.grbAggiungiModificaEliminaClienti.ResumeLayout(false);
            this.grbAggiungiModificaEliminaClienti.PerformLayout();
            this.grbModificaCliente.ResumeLayout(false);
            this.grbModificaCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbEliminaCliente.ResumeLayout(false);
            this.grbEliminaCliente.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAggiungiModificaElimina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbModificaCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModificaId;
        private System.Windows.Forms.TextBox txtCognomeModifica;
        private System.Windows.Forms.TextBox txtEmailModifica;
        private System.Windows.Forms.TextBox txtNomeModifica;
        private System.Windows.Forms.Button btnModificaCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbEliminaCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEliminaCliente;
        private System.Windows.Forms.Button btnEliminaCliente;
    }
}