namespace Progetto_PCTO.Views
{
    partial class FrmConfermaAcquisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfermaAcquisto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCarrello = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.txtIndirizzoDiConsegna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCognomeCliente = new System.Windows.Forms.Label();
            this.txtIndirizzoPartenza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbModalitàDiPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrezzoTotale = new System.Windows.Forms.Label();
            this.txtNumeroDiTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrello)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCarrello);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 723);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrello";
            // 
            // dgvCarrello
            // 
            this.dgvCarrello.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrello.Location = new System.Drawing.Point(6, 21);
            this.dgvCarrello.Name = "dgvCarrello";
            this.dgvCarrello.RowHeadersWidth = 51;
            this.dgvCarrello.RowTemplate.Height = 24;
            this.dgvCarrello.Size = new System.Drawing.Size(573, 696);
            this.dgvCarrello.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeroDiTelefono);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblPrezzoTotale);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnConferma);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rtbNote);
            this.groupBox2.Controls.Add(this.txtIndirizzoDiConsegna);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCognomeCliente);
            this.groupBox2.Controls.Add(this.txtIndirizzoPartenza);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbModalitàDiPagamento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(607, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 723);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Riepilogo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Eventuali note aggiuntive";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(9, 240);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(344, 255);
            this.rtbNote.TabIndex = 12;
            this.rtbNote.Text = "";
            // 
            // txtIndirizzoDiConsegna
            // 
            this.txtIndirizzoDiConsegna.Location = new System.Drawing.Point(187, 150);
            this.txtIndirizzoDiConsegna.Name = "txtIndirizzoDiConsegna";
            this.txtIndirizzoDiConsegna.Size = new System.Drawing.Size(166, 22);
            this.txtIndirizzoDiConsegna.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Indirizzo di consegna";
            // 
            // lblCognomeCliente
            // 
            this.lblCognomeCliente.AutoSize = true;
            this.lblCognomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognomeCliente.Location = new System.Drawing.Point(184, 65);
            this.lblCognomeCliente.Name = "lblCognomeCliente";
            this.lblCognomeCliente.Size = new System.Drawing.Size(43, 16);
            this.lblCognomeCliente.TabIndex = 8;
            this.lblCognomeCliente.Text = "XXXX";
            // 
            // txtIndirizzoPartenza
            // 
            this.txtIndirizzoPartenza.Location = new System.Drawing.Point(187, 122);
            this.txtIndirizzoPartenza.Name = "txtIndirizzoPartenza";
            this.txtIndirizzoPartenza.Size = new System.Drawing.Size(166, 22);
            this.txtIndirizzoPartenza.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Indirizzo del cliente";
            // 
            // cmbModalitàDiPagamento
            // 
            this.cmbModalitàDiPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalitàDiPagamento.FormattingEnabled = true;
            this.cmbModalitàDiPagamento.Location = new System.Drawing.Point(187, 92);
            this.cmbModalitàDiPagamento.Name = "cmbModalitàDiPagamento";
            this.cmbModalitàDiPagamento.Size = new System.Drawing.Size(166, 24);
            this.cmbModalitàDiPagamento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modalità di pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome del cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(187, 32);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(166, 24);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome del cliente";
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.Lime;
            this.btnConferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferma.Location = new System.Drawing.Point(55, 576);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(240, 74);
            this.btnConferma.TabIndex = 14;
            this.btnConferma.Text = "CONFERMA";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Prezzo totale";
            // 
            // lblPrezzoTotale
            // 
            this.lblPrezzoTotale.AutoSize = true;
            this.lblPrezzoTotale.Location = new System.Drawing.Point(165, 511);
            this.lblPrezzoTotale.Name = "lblPrezzoTotale";
            this.lblPrezzoTotale.Size = new System.Drawing.Size(42, 16);
            this.lblPrezzoTotale.TabIndex = 16;
            this.lblPrezzoTotale.Text = "XXXX ";
            // 
            // txtNumeroDiTelefono
            // 
            this.txtNumeroDiTelefono.Location = new System.Drawing.Point(187, 182);
            this.txtNumeroDiTelefono.Name = "txtNumeroDiTelefono";
            this.txtNumeroDiTelefono.Size = new System.Drawing.Size(166, 22);
            this.txtNumeroDiTelefono.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numero di telefono";
            // 
            // FrmConfermaAcquisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(990, 795);
            this.MinimumSize = new System.Drawing.Size(990, 795);
            this.Name = "FrmConfermaAcquisto";
            this.Text = "Conferma acquisto";
            this.Load += new System.EventHandler(this.FrmConfermaAcquisto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrello)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCarrello;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtIndirizzoDiConsegna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCognomeCliente;
        private System.Windows.Forms.TextBox txtIndirizzoPartenza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbModalitàDiPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Label lblPrezzoTotale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroDiTelefono;
        private System.Windows.Forms.Label label8;
    }
}