namespace Iah42HeWiPo_Taschenrechner
{
    partial class RechnerForm
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
            this.AusgabeTextBox = new System.Windows.Forms.TextBox();
            this.ErgebnisButtonClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AusgabeTextBox
            // 
            this.AusgabeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AusgabeTextBox.Location = new System.Drawing.Point(12, 12);
            this.AusgabeTextBox.Name = "AusgabeTextBox";
            this.AusgabeTextBox.Size = new System.Drawing.Size(386, 44);
            this.AusgabeTextBox.TabIndex = 0;
            this.AusgabeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ErgebnisButtonClick
            // 
            this.ErgebnisButtonClick.Location = new System.Drawing.Point(187, 191);
            this.ErgebnisButtonClick.Name = "ErgebnisButtonClick";
            this.ErgebnisButtonClick.Size = new System.Drawing.Size(75, 23);
            this.ErgebnisButtonClick.TabIndex = 1;
            this.ErgebnisButtonClick.Text = "Ergebnis";
            this.ErgebnisButtonClick.UseVisualStyleBackColor = true;
            this.ErgebnisButtonClick.Click += new System.EventHandler(this.ErgebnisButtonClick_Click);
            // 
            // RechnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 292);
            this.Controls.Add(this.ErgebnisButtonClick);
            this.Controls.Add(this.AusgabeTextBox);
            this.Name = "RechnerForm";
            this.Text = "Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AusgabeTextBox;
        private System.Windows.Forms.Button ErgebnisButtonClick;
    }
}

