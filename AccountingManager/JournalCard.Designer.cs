namespace AccountingManager
{
    partial class JournalCard
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
            this.cmbJournalArt = new System.Windows.Forms.ComboBox();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJournalNr = new System.Windows.Forms.TextBox();
            this.lblJournalArt = new System.Windows.Forms.Label();
            this.lblBetrag = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblJournalNr = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbJournalArt
            // 
            this.cmbJournalArt.FormattingEnabled = true;
            this.cmbJournalArt.Location = new System.Drawing.Point(127, 32);
            this.cmbJournalArt.Name = "cmbJournalArt";
            this.cmbJournalArt.Size = new System.Drawing.Size(121, 21);
            this.cmbJournalArt.TabIndex = 79;
            // 
            // txtBetrag
            // 
            this.txtBetrag.Location = new System.Drawing.Point(127, 85);
            this.txtBetrag.Name = "txtBetrag";
            this.txtBetrag.Size = new System.Drawing.Size(121, 20);
            this.txtBetrag.TabIndex = 76;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 75;
            // 
            // txtJournalNr
            // 
            this.txtJournalNr.Location = new System.Drawing.Point(127, 6);
            this.txtJournalNr.Name = "txtJournalNr";
            this.txtJournalNr.Size = new System.Drawing.Size(121, 20);
            this.txtJournalNr.TabIndex = 74;
            // 
            // lblJournalArt
            // 
            this.lblJournalArt.AutoSize = true;
            this.lblJournalArt.Location = new System.Drawing.Point(12, 35);
            this.lblJournalArt.Name = "lblJournalArt";
            this.lblJournalArt.Size = new System.Drawing.Size(63, 13);
            this.lblJournalArt.TabIndex = 73;
            this.lblJournalArt.Text = "Journal-Art.:";
            // 
            // lblBetrag
            // 
            this.lblBetrag.AutoSize = true;
            this.lblBetrag.Location = new System.Drawing.Point(12, 88);
            this.lblBetrag.Name = "lblBetrag";
            this.lblBetrag.Size = new System.Drawing.Size(41, 13);
            this.lblBetrag.TabIndex = 69;
            this.lblBetrag.Text = "Betrag:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "Name:";
            // 
            // lblJournalNr
            // 
            this.lblJournalNr.AutoSize = true;
            this.lblJournalNr.Location = new System.Drawing.Point(12, 9);
            this.lblJournalNr.Name = "lblJournalNr";
            this.lblJournalNr.Size = new System.Drawing.Size(61, 13);
            this.lblJournalNr.TabIndex = 67;
            this.lblJournalNr.Text = "Journal-Nr.:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(149, 122);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 33);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // JournalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 166);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbJournalArt);
            this.Controls.Add(this.txtBetrag);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtJournalNr);
            this.Controls.Add(this.lblJournalArt);
            this.Controls.Add(this.lblBetrag);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblJournalNr);
            this.Name = "JournalCard";
            this.Text = "JournalCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbJournalArt;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJournalNr;
        private System.Windows.Forms.Label lblJournalArt;
        private System.Windows.Forms.Label lblBetrag;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblJournalNr;
        private System.Windows.Forms.Button btnBack;
    }
}