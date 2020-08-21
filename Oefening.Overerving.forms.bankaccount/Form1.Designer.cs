namespace Oefening.Overerving.forms.bankaccount
{
    partial class StartForm
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
            this.lbRekeningen = new System.Windows.Forms.ListBox();
            this.btnRekeningOpenen = new System.Windows.Forms.Button();
            this.btnOverschrijven = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRekeningen
            // 
            this.lbRekeningen.FormattingEnabled = true;
            this.lbRekeningen.ItemHeight = 16;
            this.lbRekeningen.Location = new System.Drawing.Point(52, 60);
            this.lbRekeningen.Name = "lbRekeningen";
            this.lbRekeningen.Size = new System.Drawing.Size(120, 84);
            this.lbRekeningen.TabIndex = 0;
            // 
            // btnRekeningOpenen
            // 
            this.btnRekeningOpenen.Location = new System.Drawing.Point(247, 39);
            this.btnRekeningOpenen.Name = "btnRekeningOpenen";
            this.btnRekeningOpenen.Size = new System.Drawing.Size(210, 45);
            this.btnRekeningOpenen.TabIndex = 1;
            this.btnRekeningOpenen.Text = "Nieuwe rekening openen";
            this.btnRekeningOpenen.UseVisualStyleBackColor = true;
            // 
            // btnOverschrijven
            // 
            this.btnOverschrijven.Location = new System.Drawing.Point(247, 112);
            this.btnOverschrijven.Name = "btnOverschrijven";
            this.btnOverschrijven.Size = new System.Drawing.Size(210, 49);
            this.btnOverschrijven.TabIndex = 2;
            this.btnOverschrijven.Text = "Overschrijving";
            this.btnOverschrijven.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(247, 201);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(210, 46);
            this.btnVerwijderen.TabIndex = 3;
            this.btnVerwijderen.Text = "Rekening Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(52, 173);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(46, 17);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "label1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnOverschrijven);
            this.Controls.Add(this.btnRekeningOpenen);
            this.Controls.Add(this.lbRekeningen);
            this.Name = "StartForm";
            this.Text = "Start Form";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRekeningen;
        private System.Windows.Forms.Button btnRekeningOpenen;
        private System.Windows.Forms.Button btnOverschrijven;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label lblSaldo;
    }
}

