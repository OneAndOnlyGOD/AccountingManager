namespace AccountingManager
{
    partial class VendorList
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnOeffnen = new System.Windows.Forms.Button();
            this.dgvDebitor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(503, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 41);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(258, 407);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(146, 41);
            this.btnNeu.TabIndex = 6;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            // 
            // btnOeffnen
            // 
            this.btnOeffnen.Location = new System.Drawing.Point(12, 407);
            this.btnOeffnen.Name = "btnOeffnen";
            this.btnOeffnen.Size = new System.Drawing.Size(146, 41);
            this.btnOeffnen.TabIndex = 5;
            this.btnOeffnen.Text = "Kreditor öffnen";
            this.btnOeffnen.UseVisualStyleBackColor = true;
            // 
            // dgvDebitor
            // 
            this.dgvDebitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitor.Location = new System.Drawing.Point(12, 12);
            this.dgvDebitor.Name = "dgvDebitor";
            this.dgvDebitor.Size = new System.Drawing.Size(637, 389);
            this.dgvDebitor.TabIndex = 4;
            // 
            // VendorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 453);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.btnOeffnen);
            this.Controls.Add(this.dgvDebitor);
            this.Name = "VendorList";
            this.Text = "VendorList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnOeffnen;
        private System.Windows.Forms.DataGridView dgvDebitor;
    }
}