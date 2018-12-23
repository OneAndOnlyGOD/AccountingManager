namespace AccountingManager
{
    partial class CashRecipentList
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
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnCamt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.dgvDebitor = new System.Windows.Forms.DataGridView();
            this.cmbJournal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(471, 12);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(146, 41);
            this.btnTotal.TabIndex = 15;
            this.btnTotal.Text = "Total generieren";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // btnCamt
            // 
            this.btnCamt.Location = new System.Drawing.Point(319, 12);
            this.btnCamt.Name = "btnCamt";
            this.btnCamt.Size = new System.Drawing.Size(146, 41);
            this.btnCamt.TabIndex = 14;
            this.btnCamt.Text = "Camtfile generieren";
            this.btnCamt.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(743, 510);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 41);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(12, 12);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(146, 41);
            this.btnDelRow.TabIndex = 12;
            this.btnDelRow.Text = "Zeile löschen";
            this.btnDelRow.UseVisualStyleBackColor = true;
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(167, 12);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(146, 41);
            this.btnDelAll.TabIndex = 11;
            this.btnDelAll.Text = "Alles löschen";
            this.btnDelAll.UseVisualStyleBackColor = true;
            // 
            // dgvDebitor
            // 
            this.dgvDebitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitor.Location = new System.Drawing.Point(12, 112);
            this.dgvDebitor.Name = "dgvDebitor";
            this.dgvDebitor.Size = new System.Drawing.Size(877, 389);
            this.dgvDebitor.TabIndex = 10;
            // 
            // cmbJournal
            // 
            this.cmbJournal.FormattingEnabled = true;
            this.cmbJournal.Location = new System.Drawing.Point(12, 72);
            this.cmbJournal.Name = "cmbJournal";
            this.cmbJournal.Size = new System.Drawing.Size(146, 21);
            this.cmbJournal.TabIndex = 16;
            this.cmbJournal.Text = "Journal-Name";
            // 
            // CashRecipentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 560);
            this.Controls.Add(this.cmbJournal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnCamt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelRow);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.dgvDebitor);
            this.Name = "CashRecipentList";
            this.Text = "CashRecipentList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnCamt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.DataGridView dgvDebitor;
        private System.Windows.Forms.ComboBox cmbJournal;
    }
}