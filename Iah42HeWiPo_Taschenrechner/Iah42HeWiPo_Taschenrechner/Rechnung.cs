using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iah42HeWiPo_Taschenrechner
{
    class Rechnung
    {
         
        private Nullable<double> eingabeZahl1 = null;
        private Nullable<double> eingabeZahl2 = null;
        private Nullable<double> ergebnis = null;
        private bool auswahlZahl2 = false;
        private string rechenschritt;

        public Nullable<double> EingabeZahl1
        {
            set { eingabeZahl1 = value; }
            get { return eingabeZahl1; }
        }

        public Nullable<double> EingabeZahl2
        {
            set { eingabeZahl2 = value; }
            get { return eingabeZahl2; }
        }

        public Nullable<double> Ergebnis
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


        public void Addieren(Nullable<double> eingabeZahl1, Nullable<double> eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 + eingabeZahl2;
        }

        public void Subtrahieren(Nullable<double> eingabeZahl1, Nullable<double> eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 - eingabeZahl2;
        }

        public void Multiplizieren(Nullable<double> eingabeZahl1, Nullable<double> eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 * eingabeZahl2;
        }

        public void Dividieren(Nullable<double> eingabeZahl1, Nullable<double> eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 / eingabeZahl2;
        }

        public void Quadrieren(Nullable<double> eingabeZahl1, Nullable<double> eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 * eingabeZahl1;
        }

        public void Wurzel(Nullable<double> eingabeZahl1)
        {
            Ergebnis = Math.Sqrt(Convert.ToDouble(eingabeZahl1));
        }

    }
}
