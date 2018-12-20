namespace AccountingManager
{
    partial class Landingpage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnPaymentJournal = new System.Windows.Forms.Button();
            this.btnPain = new System.Windows.Forms.Button();
            this.btnCashRecipentJournal = new System.Windows.Forms.Button();
            this.btnCamt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gridTopAccounts = new System.Windows.Forms.DataGridView();
            this.lblTopAccounts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(12, 12);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(239, 47);
            this.btnAccounts.TabIndex = 0;
            this.btnAccounts.Text = "Kontos";
            this.btnAccounts.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(286, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(239, 47);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Debitoren";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnVendor
            // 
            this.btnVendor.Location = new System.Drawing.Point(286, 75);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(239, 47);
            this.btnVendor.TabIndex = 3;
            this.btnVendor.Text = "Kreditoren";
            this.btnVendor.UseVisualStyleBackColor = true;
            // 
            // btnPaymentJournal
            // 
            this.btnPaymentJournal.Location = new System.Drawing.Point(12, 75);
            this.btnPaymentJournal.Name = "btnPaymentJournal";
            this.btnPaymentJournal.Size = new System.Drawing.Size(239, 47);
            this.btnPaymentJournal.TabIndex = 2;
            this.btnPaymentJournal.Text = "Ausgangszahlungen";
            this.btnPaymentJournal.UseVisualStyleBackColor = true;
            // 
            // btnPain
            // 
            this.btnPain.Location = new System.Drawing.Point(286, 140);
            this.btnPain.Name = "btnPain";
            this.btnPain.Size = new System.Drawing.Size(239, 47);
            this.btnPain.TabIndex = 5;
            this.btnPain.Text = "Setup PAIN";
            this.btnPain.UseVisualStyleBackColor = true;
            // 
            // btnCashRecipentJournal
            // 
            this.btnCashRecipentJournal.Location = new System.Drawing.Point(12, 140);
            this.btnCashRecipentJournal.Name = "btnCashRecipentJournal";
            this.btnCashRecipentJournal.Size = new System.Drawing.Size(239, 47);
            this.btnCashRecipentJournal.TabIndex = 4;
            this.btnCashRecipentJournal.Text = "Eingangszahlungen";
            this.btnCashRecipentJournal.UseVisualStyleBackColor = true;
            // 
            // btnCamt
            // 
            this.btnCamt.Location = new System.Drawing.Point(286, 204);
            this.btnCamt.Name = "btnCamt";
            this.btnCamt.Size = new System.Drawing.Size(239, 47);
            this.btnCamt.TabIndex = 6;
            this.btnCamt.Text = "Setup CAMT";
            this.btnCamt.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(286, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // gridTopAccounts
            // 
            this.gridTopAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTopAccounts.Location = new System.Drawing.Point(12, 314);
            this.gridTopAccounts.Name = "gridTopAccounts";
            this.gridTopAccounts.Size = new System.Drawing.Size(240, 150);
            this.gridTopAccounts.TabIndex = 8;
            // 
            // lblTopAccounts
            // 
            this.lblTopAccounts.AutoSize = true;
            this.lblTopAccounts.Location = new System.Drawing.Point(12, 298);
            this.lblTopAccounts.Name = "lblTopAccounts";
            this.lblTopAccounts.Size = new System.Drawing.Size(72, 13);
            this.lblTopAccounts.TabIndex = 9;
            this.lblTopAccounts.Text = "Top 3 Konten";
            // 
            // Landingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 476);
            this.Controls.Add(this.lblTopAccounts);
            this.Controls.Add(this.gridTopAccounts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCamt);
            this.Controls.Add(this.btnPain);
            this.Controls.Add(this.btnCashRecipentJournal);
            this.Controls.Add(this.btnVendor);
            this.Controls.Add(this.btnPaymentJournal);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnAccounts);
            this.Name = "Landingpage";
            this.Text = "Accounting Manager";
            ((System.ComponentModel.ISupportInitialize)(this.gridTopAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Button btnPaymentJournal;
        private System.Windows.Forms.Button btnPain;
        private System.Windows.Forms.Button btnCashRecipentJournal;
        private System.Windows.Forms.Button btnCamt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gridTopAccounts;
        private System.Windows.Forms.Label lblTopAccounts;
    }
}

