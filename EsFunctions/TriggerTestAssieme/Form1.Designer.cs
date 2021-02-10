
namespace TriggerTestAssieme
{
    partial class Form1
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
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dgvStoricoCancellazioni = new System.Windows.Forms.DataGridView();
            this.dgvStoricoAggiornamenti = new System.Windows.Forms.DataGridView();
            this.btnAggDB = new System.Windows.Forms.Button();
            this.dgvStoricoAggiornamentiCampi = new System.Windows.Forms.DataGridView();
            this.btnCERCA = new System.Windows.Forms.Button();
            this.btnNazione = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPodio = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvF1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamentiCampi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvF1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(13, 13);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(323, 196);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsDeletedDriver);
            // 
            // dgvStoricoCancellazioni
            // 
            this.dgvStoricoCancellazioni.AllowUserToAddRows = false;
            this.dgvStoricoCancellazioni.AllowUserToDeleteRows = false;
            this.dgvStoricoCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoCancellazioni.Location = new System.Drawing.Point(352, 13);
            this.dgvStoricoCancellazioni.Name = "dgvStoricoCancellazioni";
            this.dgvStoricoCancellazioni.RowHeadersVisible = false;
            this.dgvStoricoCancellazioni.Size = new System.Drawing.Size(323, 196);
            this.dgvStoricoCancellazioni.TabIndex = 1;
            // 
            // dgvStoricoAggiornamenti
            // 
            this.dgvStoricoAggiornamenti.AllowUserToAddRows = false;
            this.dgvStoricoAggiornamenti.AllowUserToDeleteRows = false;
            this.dgvStoricoAggiornamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoAggiornamenti.Location = new System.Drawing.Point(13, 245);
            this.dgvStoricoAggiornamenti.Name = "dgvStoricoAggiornamenti";
            this.dgvStoricoAggiornamenti.RowHeadersVisible = false;
            this.dgvStoricoAggiornamenti.Size = new System.Drawing.Size(323, 196);
            this.dgvStoricoAggiornamenti.TabIndex = 2;
            // 
            // btnAggDB
            // 
            this.btnAggDB.Location = new System.Drawing.Point(12, 215);
            this.btnAggDB.Name = "btnAggDB";
            this.btnAggDB.Size = new System.Drawing.Size(159, 23);
            this.btnAggDB.TabIndex = 3;
            this.btnAggDB.Text = "Aggiorna Data Base";
            this.btnAggDB.UseVisualStyleBackColor = true;
            this.btnAggDB.Click += new System.EventHandler(this.btnAggDB_Click);
            // 
            // dgvStoricoAggiornamentiCampi
            // 
            this.dgvStoricoAggiornamentiCampi.AllowUserToAddRows = false;
            this.dgvStoricoAggiornamentiCampi.AllowUserToDeleteRows = false;
            this.dgvStoricoAggiornamentiCampi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoAggiornamentiCampi.Location = new System.Drawing.Point(355, 242);
            this.dgvStoricoAggiornamentiCampi.Name = "dgvStoricoAggiornamentiCampi";
            this.dgvStoricoAggiornamentiCampi.RowHeadersVisible = false;
            this.dgvStoricoAggiornamentiCampi.Size = new System.Drawing.Size(323, 196);
            this.dgvStoricoAggiornamentiCampi.TabIndex = 4;
            // 
            // btnCERCA
            // 
            this.btnCERCA.Location = new System.Drawing.Point(35, 604);
            this.btnCERCA.Name = "btnCERCA";
            this.btnCERCA.Size = new System.Drawing.Size(75, 23);
            this.btnCERCA.TabIndex = 15;
            this.btnCERCA.Text = "INVIA";
            this.btnCERCA.UseVisualStyleBackColor = true;
            this.btnCERCA.Click += new System.EventHandler(this.btnCERCA_Click);
            // 
            // btnNazione
            // 
            this.btnNazione.Location = new System.Drawing.Point(35, 504);
            this.btnNazione.Name = "btnNazione";
            this.btnNazione.Size = new System.Drawing.Size(75, 23);
            this.btnNazione.TabIndex = 14;
            this.btnNazione.Text = "CERCA";
            this.btnNazione.UseVisualStyleBackColor = true;
            this.btnNazione.Click += new System.EventHandler(this.btnNazione_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero podi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inserisci nazione:";
            // 
            // txtPodio
            // 
            this.txtPodio.Location = new System.Drawing.Point(35, 578);
            this.txtPodio.Name = "txtPodio";
            this.txtPodio.Size = new System.Drawing.Size(100, 20);
            this.txtPodio.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 478);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 10;
            // 
            // dgvF1
            // 
            this.dgvF1.AllowUserToAddRows = false;
            this.dgvF1.AllowUserToDeleteRows = false;
            this.dgvF1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvF1.Location = new System.Drawing.Point(193, 447);
            this.dgvF1.Name = "dgvF1";
            this.dgvF1.RowHeadersVisible = false;
            this.dgvF1.Size = new System.Drawing.Size(323, 196);
            this.dgvF1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 659);
            this.Controls.Add(this.dgvF1);
            this.Controls.Add(this.btnCERCA);
            this.Controls.Add(this.btnNazione);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPodio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvStoricoAggiornamentiCampi);
            this.Controls.Add(this.btnAggDB);
            this.Controls.Add(this.dgvStoricoAggiornamenti);
            this.Controls.Add(this.dgvStoricoCancellazioni);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamentiCampi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvStoricoCancellazioni;
        private System.Windows.Forms.DataGridView dgvStoricoAggiornamenti;
        private System.Windows.Forms.Button btnAggDB;
        private System.Windows.Forms.DataGridView dgvStoricoAggiornamentiCampi;
        private System.Windows.Forms.Button btnCERCA;
        private System.Windows.Forms.Button btnNazione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPodio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvF1;
    }
}

