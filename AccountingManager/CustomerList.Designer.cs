namespace AccountingManager
{
    partial class CustomerList
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
            this.dgvDebitor = new System.Windows.Forms.DataGridView();
            this.btnOeffnen = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDebitor
            // 
            this.dgvDebitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitor.Location = new System.Drawing.Point(12, 12);
            this.dgvDebitor.Name = "dgvDebitor";
            this.dgvDebitor.Size = new System.Drawing.Size(637, 389);
            this.dgvDebitor.TabIndex = 0;
            // 
            // btnOeffnen
            // 
            this.btnOeffnen.Location = new System.Drawing.Point(12, 407);
            this.btnOeffnen.Name = "btnOeffnen";
            this.btnOeffnen.Size = new System.Drawing.Size(146, 41);
            this.btnOeffnen.TabIndex = 1;
            this.btnOeffnen.Text = "Debitor öffnen";
            this.btnOeffnen.UseVisualStyleBackColor = true;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(258, 407);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(146, 41);
            this.btnNeu.TabIndex = 2;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(503, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 457);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.btnOeffnen);
            this.Controls.Add(this.dgvDebitor);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDebitor;
        private System.Windows.Forms.Button btnOeffnen;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnBack;
    }
}