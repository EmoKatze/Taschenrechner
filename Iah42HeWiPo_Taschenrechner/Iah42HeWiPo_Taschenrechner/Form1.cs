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
                    rechnung.Quadrieren(rechnung.EingabeZahl1, rechnung.EingabeZahl2);
                    break;
                case "sqrt":
                    rechnung.Wurzel(rechnung.EingabeZahl1);
                    break;
            }

            AusgabeTextBox.Text = "";
            AusgabeTextBox.Text = Convert.ToString(rechnung.Ergebnis);
            rechnung.EingabeZahl1 = null;
            rechnung.EingabeZahl2 = null;
            rechnung.AuswahlZahl2 = false;
        }

        private void Zahl1ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("1");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);
            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("1");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl2ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("2");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("2");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl3ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("3");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("3");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl4ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("4");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("4");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl5ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("5");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("5");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl6ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("6");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("6");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl7ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("7");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("7");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl8ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("8");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("8");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl9ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("9");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("9");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void Zahl0ButtonClick_Click(object sender, EventArgs e)
        {
            if (rechnung.AuswahlZahl2 == false)
            {
                rechnung.EingabeZahl1 += Convert.ToDouble("0");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl1);

            }
            else
            {
                rechnung.EingabeZahl2 += Convert.ToDouble("0");
                AusgabeTextBox.Text = Convert.ToString(rechnung.EingabeZahl2);

            }
        }

        private void AddierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "+";
        }

        private void SubtrahierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "-";
        }

        private void MultiplizierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "*";
        }

        private void DividierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "/";
        }

        private void QuadrierenButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "²";
        }

        private void WurzelButtonClick_Click(object sender, EventArgs e)
        {
            rechnung.Rechenschritt = "sqrt";
        }
    }
}
