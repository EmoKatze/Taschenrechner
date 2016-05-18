using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iah42HeWiPo_Taschenrechner
{
    class Rechnung
    {
         
        private string eingabeZahl1 = null;
        private string eingabeZahl2 = null;
        private string ergebnis = null;
        private bool auswahlZahl2 = false;
        private string rechenschritt;

        public string EingabeZahl1
        {
            set { eingabeZahl1 = value; }
            get { return eingabeZahl1; }
        }

        public string EingabeZahl2
        {
            set { eingabeZahl2 = value; }
            get { return eingabeZahl2; }
        }

        public string Ergebnis
        {
            set { ergebnis = value; }
            get { return ergebnis; }
        }

        public bool AuswahlZahl2
        {
            set { auswahlZahl2 = value; }
            get { return auswahlZahl2; }
        }

        public string Rechenschritt
        {
            set { rechenschritt = value; }
            get { return rechenschritt; }
        }


        public void Addieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) + Convert.ToDouble(eingabeZahl2));
        }

        public void Subtrahieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) - Convert.ToDouble(eingabeZahl2));
        }

        public void Multiplizieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) * Convert.ToDouble(eingabeZahl2));
        }

        public void Dividieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) / Convert.ToDouble(eingabeZahl2));
        }

        public void Quadrieren(string eingabeZahl1)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) * Convert.ToDouble(eingabeZahl1));
        }

        public void Wurzel(string eingabeZahl1)
        {
            Ergebnis = Convert.ToString(Math.Sqrt(Convert.ToDouble(eingabeZahl1)));
        }
    }
}
