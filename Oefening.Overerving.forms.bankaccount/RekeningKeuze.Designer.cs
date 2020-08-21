namespace Oefening.Overerving.forms.bankaccount
{
    partial class RekeningKeuze
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
            this.btnDebitRekening = new System.Windows.Forms.Button();
            this.btnSpaarRekening = new System.Windows.Forms.Button();
            this.btnCreditRekening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDebitRekening
            // 
            this.btnDebitRekening.Location = new System.Drawing.Point(47, 27);
            this.btnDebitRekening.Name = "btnDebitRekening";
            this.btnDebitRekening.Size = new System.Drawing.Size(191, 38);
            this.btnDebitRekening.TabIndex = 0;
            this.btnDebitRekening.Text = "debit rekening";
            this.btnDebitRekening.UseVisualStyleBackColor = true;
            // 
            // btnSpaarRekening
            // 
            this.btnSpaarRekening.Location = new System.Drawing.Point(47, 173);
            this.btnSpaarRekening.Name = "btnSpaarRekening";
            this.btnSpaarRekening.Size = new System.Drawing.Size(191, 38);
            this.btnSpaarRekening.TabIndex = 1;
            this.btnSpaarRekening.Text = "spaar rekening";
            this.btnSpaarRekening.UseVisualStyleBackColor = true;
            // 
            // btnCreditRekening
            // 
            this.btnCreditRekening.Location = new System.Drawing.Point(47, 100);
            this.btnCreditRekening.Name = "btnCreditRekening";
            this.btnCreditRekening.Size = new System.Drawing.Size(191, 38);
            this.btnCreditRekening.TabIndex = 2;
            this.btnCreditRekening.Text = "credit rekening";
            this.btnCreditRekening.UseVisualStyleBackColor = true;
            // 
            // RekeningKeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreditRekening);
            this.Controls.Add(this.btnSpaarRekening);
            this.Controls.Add(this.btnDebitRekening);
            this.Name = "RekeningKeuze";
            this.Text = "RekeningKeuze";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDebitRekening;
        private System.Windows.Forms.Button btnSpaarRekening;
        private System.Windows.Forms.Button btnCreditRekening;
    }
}