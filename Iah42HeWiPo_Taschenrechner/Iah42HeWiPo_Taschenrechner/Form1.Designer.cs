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
            this.Zahl1ButtonClick = new System.Windows.Forms.Button();
            this.EingabeGroupBox = new System.Windows.Forms.GroupBox();
            this.WurzelButtonClick = new System.Windows.Forms.Button();
            this.QuadrierenButtonClick = new System.Windows.Forms.Button();
            this.DividierenButtonClick = new System.Windows.Forms.Button();
            this.MultiplizierenButtonClick = new System.Windows.Forms.Button();
            this.SubtrahierenButtonClick = new System.Windows.Forms.Button();
            this.AddierenButtonClick = new System.Windows.Forms.Button();
            this.Zahl0ButtonClick = new System.Windows.Forms.Button();
            this.Zahl9ButtonClick = new System.Windows.Forms.Button();
            this.Zahl5ButtonClick = new System.Windows.Forms.Button();
            this.Zahl8ButtonClick = new System.Windows.Forms.Button();
            this.Zahl4ButtonClick = new System.Windows.Forms.Button();
            this.Zahl7ButtonClick = new System.Windows.Forms.Button();
            this.Zahl3ButtonClick = new System.Windows.Forms.Button();
            this.Zahl6ButtonClick = new System.Windows.Forms.Button();
            this.Zahl2ButtonClick = new System.Windows.Forms.Button();
            this.RechenschrittTextbox = new System.Windows.Forms.TextBox();
            this.KommaButtonClick = new System.Windows.Forms.Button();
            this.ClearButtonClick = new System.Windows.Forms.Button();
            this.EingabeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AusgabeTextBox
            // 
            this.AusgabeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AusgabeTextBox.Location = new System.Drawing.Point(12, 12);
            this.AusgabeTextBox.Name = "AusgabeTextBox";
            this.AusgabeTextBox.ReadOnly = true;
            this.AusgabeTextBox.Size = new System.Drawing.Size(224, 44);
            this.AusgabeTextBox.TabIndex = 0;
            this.AusgabeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ErgebnisButtonClick
            // 
            this.ErgebnisButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErgebnisButtonClick.Location = new System.Drawing.Point(197, 388);
            this.ErgebnisButtonClick.Name = "ErgebnisButtonClick";
            this.ErgebnisButtonClick.Size = new System.Drawing.Size(101, 39);
            this.ErgebnisButtonClick.TabIndex = 1;
            this.ErgebnisButtonClick.Text = "Ergebnis";
            this.ErgebnisButtonClick.UseVisualStyleBackColor = true;
            this.ErgebnisButtonClick.Click += new System.EventHandler(this.ErgebnisButtonClick_Click);
            // 
            // Zahl1ButtonClick
            // 
            this.Zahl1ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl1ButtonClick.Location = new System.Drawing.Point(6, 37);
            this.Zahl1ButtonClick.Name = "Zahl1ButtonClick";
            this.Zahl1ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl1ButtonClick.TabIndex = 2;
            this.Zahl1ButtonClick.Text = "1";
            this.Zahl1ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl1ButtonClick.Click += new System.EventHandler(this.Zahl1ButtonClick_Click);
            // 
            // EingabeGroupBox
            // 
            this.EingabeGroupBox.Controls.Add(this.WurzelButtonClick);
            this.EingabeGroupBox.Controls.Add(this.QuadrierenButtonClick);
            this.EingabeGroupBox.Controls.Add(this.DividierenButtonClick);
            this.EingabeGroupBox.Controls.Add(this.MultiplizierenButtonClick);
            this.EingabeGroupBox.Controls.Add(this.SubtrahierenButtonClick);
            this.EingabeGroupBox.Controls.Add(this.AddierenButtonClick);
            this.EingabeGroupBox.Controls.Add(this.KommaButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl0ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl9ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl5ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl8ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl4ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl7ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl3ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl6ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl2ButtonClick);
            this.EingabeGroupBox.Controls.Add(this.Zahl1ButtonClick);
            this.EingabeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EingabeGroupBox.Location = new System.Drawing.Point(12, 76);
            this.EingabeGroupBox.Name = "EingabeGroupBox";
            this.EingabeGroupBox.Size = new System.Drawing.Size(286, 306);
            this.EingabeGroupBox.TabIndex = 3;
            this.EingabeGroupBox.TabStop = false;
            this.EingabeGroupBox.Text = "Eingabe";
            // 
            // WurzelButtonClick
            // 
            this.WurzelButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WurzelButtonClick.Location = new System.Drawing.Point(62, 232);
            this.WurzelButtonClick.Name = "WurzelButtonClick";
            this.WurzelButtonClick.Size = new System.Drawing.Size(50, 50);
            this.WurzelButtonClick.TabIndex = 3;
            this.WurzelButtonClick.Text = "Sqrt";
            this.WurzelButtonClick.UseVisualStyleBackColor = true;
            this.WurzelButtonClick.Click += new System.EventHandler(this.WurzelButtonClick_Click);
            // 
            // QuadrierenButtonClick
            // 
            this.QuadrierenButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuadrierenButtonClick.Location = new System.Drawing.Point(6, 232);
            this.QuadrierenButtonClick.Name = "QuadrierenButtonClick";
            this.QuadrierenButtonClick.Size = new System.Drawing.Size(50, 50);
            this.QuadrierenButtonClick.TabIndex = 3;
            this.QuadrierenButtonClick.Text = "x²";
            this.QuadrierenButtonClick.UseVisualStyleBackColor = true;
            this.QuadrierenButtonClick.Click += new System.EventHandler(this.QuadrierenButtonClick_Click);
            // 
            // DividierenButtonClick
            // 
            this.DividierenButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DividierenButtonClick.Location = new System.Drawing.Point(118, 232);
            this.DividierenButtonClick.Name = "DividierenButtonClick";
            this.DividierenButtonClick.Size = new System.Drawing.Size(50, 50);
            this.DividierenButtonClick.TabIndex = 3;
            this.DividierenButtonClick.Text = "/";
            this.DividierenButtonClick.UseVisualStyleBackColor = true;
            this.DividierenButtonClick.Click += new System.EventHandler(this.DividierenButtonClick_Click);
            // 
            // MultiplizierenButtonClick
            // 
            this.MultiplizierenButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplizierenButtonClick.Location = new System.Drawing.Point(118, 176);
            this.MultiplizierenButtonClick.Name = "MultiplizierenButtonClick";
            this.MultiplizierenButtonClick.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.MultiplizierenButtonClick.Size = new System.Drawing.Size(50, 50);
            this.MultiplizierenButtonClick.TabIndex = 3;
            this.MultiplizierenButtonClick.Text = "*";
            this.MultiplizierenButtonClick.UseVisualStyleBackColor = true;
            this.MultiplizierenButtonClick.Click += new System.EventHandler(this.MultiplizierenButtonClick_Click);
            // 
            // SubtrahierenButtonClick
            // 
            this.SubtrahierenButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtrahierenButtonClick.Location = new System.Drawing.Point(62, 176);
            this.SubtrahierenButtonClick.Name = "SubtrahierenButtonClick";
            this.SubtrahierenButtonClick.Size = new System.Drawing.Size(50, 50);
            this.SubtrahierenButtonClick.TabIndex = 3;
            this.SubtrahierenButtonClick.Text = "-";
            this.SubtrahierenButtonClick.UseVisualStyleBackColor = true;
            this.SubtrahierenButtonClick.Click += new System.EventHandler(this.SubtrahierenButtonClick_Click);
            // 
            // AddierenButtonClick
            // 
            this.AddierenButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddierenButtonClick.Location = new System.Drawing.Point(6, 176);
            this.AddierenButtonClick.Name = "AddierenButtonClick";
            this.AddierenButtonClick.Size = new System.Drawing.Size(50, 50);
            this.AddierenButtonClick.TabIndex = 3;
            this.AddierenButtonClick.Text = "+";
            this.AddierenButtonClick.UseVisualStyleBackColor = true;
            this.AddierenButtonClick.Click += new System.EventHandler(this.AddierenButtonClick_Click);
            // 
            // Zahl0ButtonClick
            // 
            this.Zahl0ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl0ButtonClick.Location = new System.Drawing.Point(230, 93);
            this.Zahl0ButtonClick.Name = "Zahl0ButtonClick";
            this.Zahl0ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl0ButtonClick.TabIndex = 2;
            this.Zahl0ButtonClick.Text = "0";
            this.Zahl0ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl0ButtonClick.Click += new System.EventHandler(this.Zahl0ButtonClick_Click);
            // 
            // Zahl9ButtonClick
            // 
            this.Zahl9ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl9ButtonClick.Location = new System.Drawing.Point(174, 93);
            this.Zahl9ButtonClick.Name = "Zahl9ButtonClick";
            this.Zahl9ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl9ButtonClick.TabIndex = 2;
            this.Zahl9ButtonClick.Text = "9";
            this.Zahl9ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl9ButtonClick.Click += new System.EventHandler(this.Zahl9ButtonClick_Click);
            // 
            // Zahl5ButtonClick
            // 
            this.Zahl5ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl5ButtonClick.Location = new System.Drawing.Point(230, 37);
            this.Zahl5ButtonClick.Name = "Zahl5ButtonClick";
            this.Zahl5ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl5ButtonClick.TabIndex = 2;
            this.Zahl5ButtonClick.Text = "5";
            this.Zahl5ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl5ButtonClick.Click += new System.EventHandler(this.Zahl5ButtonClick_Click);
            // 
            // Zahl8ButtonClick
            // 
            this.Zahl8ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl8ButtonClick.Location = new System.Drawing.Point(118, 93);
            this.Zahl8ButtonClick.Name = "Zahl8ButtonClick";
            this.Zahl8ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl8ButtonClick.TabIndex = 2;
            this.Zahl8ButtonClick.Text = "8";
            this.Zahl8ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl8ButtonClick.Click += new System.EventHandler(this.Zahl8ButtonClick_Click);
            // 
            // Zahl4ButtonClick
            // 
            this.Zahl4ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl4ButtonClick.Location = new System.Drawing.Point(174, 37);
            this.Zahl4ButtonClick.Name = "Zahl4ButtonClick";
            this.Zahl4ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl4ButtonClick.TabIndex = 2;
            this.Zahl4ButtonClick.Text = "4";
            this.Zahl4ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl4ButtonClick.Click += new System.EventHandler(this.Zahl4ButtonClick_Click);
            // 
            // Zahl7ButtonClick
            // 
            this.Zahl7ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl7ButtonClick.Location = new System.Drawing.Point(62, 93);
            this.Zahl7ButtonClick.Name = "Zahl7ButtonClick";
            this.Zahl7ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl7ButtonClick.TabIndex = 2;
            this.Zahl7ButtonClick.Text = "7";
            this.Zahl7ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl7ButtonClick.Click += new System.EventHandler(this.Zahl7ButtonClick_Click);
            // 
            // Zahl3ButtonClick
            // 
            this.Zahl3ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl3ButtonClick.Location = new System.Drawing.Point(118, 37);
            this.Zahl3ButtonClick.Name = "Zahl3ButtonClick";
            this.Zahl3ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl3ButtonClick.TabIndex = 2;
            this.Zahl3ButtonClick.Text = "3";
            this.Zahl3ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl3ButtonClick.Click += new System.EventHandler(this.Zahl3ButtonClick_Click);
            // 
            // Zahl6ButtonClick
            // 
            this.Zahl6ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl6ButtonClick.Location = new System.Drawing.Point(6, 93);
            this.Zahl6ButtonClick.Name = "Zahl6ButtonClick";
            this.Zahl6ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl6ButtonClick.TabIndex = 2;
            this.Zahl6ButtonClick.Text = "6";
            this.Zahl6ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl6ButtonClick.Click += new System.EventHandler(this.Zahl6ButtonClick_Click);
            // 
            // Zahl2ButtonClick
            // 
            this.Zahl2ButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahl2ButtonClick.Location = new System.Drawing.Point(62, 37);
            this.Zahl2ButtonClick.Name = "Zahl2ButtonClick";
            this.Zahl2ButtonClick.Size = new System.Drawing.Size(50, 50);
            this.Zahl2ButtonClick.TabIndex = 2;
            this.Zahl2ButtonClick.Text = "2";
            this.Zahl2ButtonClick.UseVisualStyleBackColor = true;
            this.Zahl2ButtonClick.Click += new System.EventHandler(this.Zahl2ButtonClick_Click);
            // 
            // RechenschrittTextbox
            // 
            this.RechenschrittTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechenschrittTextbox.Location = new System.Drawing.Point(242, 12);
            this.RechenschrittTextbox.Name = "RechenschrittTextbox";
            this.RechenschrittTextbox.ReadOnly = true;
            this.RechenschrittTextbox.Size = new System.Drawing.Size(50, 44);
            this.RechenschrittTextbox.TabIndex = 0;
            this.RechenschrittTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KommaButtonClick
            // 
            this.KommaButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KommaButtonClick.Location = new System.Drawing.Point(230, 176);
            this.KommaButtonClick.Name = "KommaButtonClick";
            this.KommaButtonClick.Size = new System.Drawing.Size(50, 50);
            this.KommaButtonClick.TabIndex = 2;
            this.KommaButtonClick.Text = ",";
            this.KommaButtonClick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KommaButtonClick.UseVisualStyleBackColor = true;
            this.KommaButtonClick.Click += new System.EventHandler(this.KommaButtonClick_Click);
            // 
            // ClearButtonClick
            // 
            this.ClearButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButtonClick.Location = new System.Drawing.Point(12, 388);
            this.ClearButtonClick.Name = "ClearButtonClick";
            this.ClearButtonClick.Size = new System.Drawing.Size(101, 39);
            this.ClearButtonClick.TabIndex = 1;
            this.ClearButtonClick.Text = "Clear";
            this.ClearButtonClick.UseVisualStyleBackColor = true;
            this.ClearButtonClick.Click += new System.EventHandler(this.ClearButtonClick_Click);
            // 
            // RechnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 439);
            this.Controls.Add(this.EingabeGroupBox);
            this.Controls.Add(this.ClearButtonClick);
            this.Controls.Add(this.ErgebnisButtonClick);
            this.Controls.Add(this.RechenschrittTextbox);
            this.Controls.Add(this.AusgabeTextBox);
            this.Name = "RechnerForm";
            this.Text = "Rechner";
            this.EingabeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AusgabeTextBox;
        private System.Windows.Forms.Button ErgebnisButtonClick;
        private System.Windows.Forms.Button Zahl1ButtonClick;
        private System.Windows.Forms.GroupBox EingabeGroupBox;
        private System.Windows.Forms.Button Zahl5ButtonClick;
        private System.Windows.Forms.Button Zahl4ButtonClick;
        private System.Windows.Forms.Button Zahl3ButtonClick;
        private System.Windows.Forms.Button Zahl2ButtonClick;
        private System.Windows.Forms.Button Zahl0ButtonClick;
        private System.Windows.Forms.Button Zahl9ButtonClick;
        private System.Windows.Forms.Button Zahl8ButtonClick;
        private System.Windows.Forms.Button Zahl7ButtonClick;
        private System.Windows.Forms.Button Zahl6ButtonClick;
        private System.Windows.Forms.Button DividierenButtonClick;
        private System.Windows.Forms.Button MultiplizierenButtonClick;
        private System.Windows.Forms.Button SubtrahierenButtonClick;
        private System.Windows.Forms.Button AddierenButtonClick;
        private System.Windows.Forms.Button QuadrierenButtonClick;
        private System.Windows.Forms.Button WurzelButtonClick;
        private System.Windows.Forms.TextBox RechenschrittTextbox;
        private System.Windows.Forms.Button KommaButtonClick;
        private System.Windows.Forms.Button ClearButtonClick;
    }
}

