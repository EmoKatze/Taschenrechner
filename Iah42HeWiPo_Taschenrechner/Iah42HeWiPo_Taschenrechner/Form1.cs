using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iah42HeWiPo_Taschenrechner
{
    public partial class RechnerForm : Form
    {

        Rechnung rechnung = new Rechnung();

        public RechnerForm()
        {
            InitializeComponent();
        }

        private void ErgebnisButtonClick_Click(object sender, EventArgs e)
        {
            //Prüfe, ob eine Rechnung eingegeben wurde
            if (rechnung.EingabeZahl1 != null && rechnung.EingabeZahl2 != null)
            {
                switch (rechnung.Rechenschritt)
                {
                    case "+":
                        rechnung.Addieren(rechnung.EingabeZahl1, rechnung.EingabeZahl2);
                        break;
                    case "-":
                        rechnung.Subtrahieren(rechnung.EingabeZahl1, rechnung.EingabeZahl2);
                        break;
                    case "*":
                        rechnung.Multiplizieren(rechnung.EingabeZahl1, rechnung.EingabeZahl2);
                        break;
                    case "/":
                        rechnung.Dividieren(rechnung.EingabeZahl1, rechnung.EingabeZahl2);
                        break;
                    case "²":
                        rechnung.Quadrieren(rechnung.EingabeZahl1);
                        break;
                    case "sqrt":
                        rechnung.Wurzel(rechnung.EingabeZahl1);
                        break;
                }

                AusgabeTextBox.Text = "";
                RechenschrittTextbox.Text = "";
                AusgabeTextBox.Text = Convert.ToString(Math.Round(Convert.ToDouble(rechnung.Ergebnis), 5));
                //Setze Variablen zurück
                rechnung.EingabeZahl1 = null;
                rechnung.EingabeZahl2 = null;
                rechnung.AuswahlZahl2 = false;
            }
            else
            {
                AusgabeTextBox.Text = "";
                MessageBox.Show("Bitte geben Sie zuerst eine Rechnung ein!");
            }
        }


        #region EingabeButtons
        private void Zahl1ButtonClick_Click(object sender, EventArgs e)
        {
            //Prüfe, ob erste Zahl schon eingegeben wurde (Abfrage befindet sich bei jedem Button)
            if (rechnung.AuswahlZahl2 == false)
            {
                
                rechnung.EingabeZahl1 += "1";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;
            }
            else
            {
                rechnung.EingabeZahl2 += "1";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl2ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "2";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "2";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl3ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "3";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "3";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl4ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "4";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "4";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl5ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "5";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "5";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl6ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "6";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "6";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl7ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "7";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "7";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl8ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "8";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "8";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl9ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "9";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "9";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void Zahl0ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += "0";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += "0";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        private void KommaButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += ",";
                AusgabeTextBox.Text = rechnung.EingabeZahl1;

            }
            else
            {
                rechnung.EingabeZahl2 += ",";
                AusgabeTextBox.Text = rechnung.EingabeZahl2;

            }
        }

        #endregion


        private void AddierenButtonClick_Click(object sender, EventArgs e)
        {
            //Setzte auf True für Bestätigung der zweiten Variable
            rechnung.AuswahlZahl2 = true;
            rechnung.Rechenschritt = "+";
            RechenschrittTextbox.Text = "+";
        }

        private void SubtrahierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.AuswahlZahl2 = true;
            rechnung.Rechenschritt = "-";
            RechenschrittTextbox.Text = "-";
        }

        private void MultiplizierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.AuswahlZahl2 = true;
            rechnung.Rechenschritt = "*";
            RechenschrittTextbox.Text = "*";
        }

        private void DividierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.AuswahlZahl2 = true;
            rechnung.Rechenschritt = "/";
            RechenschrittTextbox.Text = "/";
        }

        private void QuadrierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "²";
            RechenschrittTextbox.Text = "²";
        }

        private void WurzelButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "sqrt";
            RechenschrittTextbox.Text = "W";
        }

        private void ClearButtonClick_Click(object sender, EventArgs e)
        {
            AusgabeTextBox.Text = "";
            RechenschrittTextbox.Text = "";
            rechnung.EingabeZahl1 = null;
            rechnung.EingabeZahl2 = null;
            rechnung.Ergebnis = null;
        }

    }
}
