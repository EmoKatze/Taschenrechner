using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iah42HeWiPo_Taschenrechner
{
    class Rechnung
    {
        private double eingabeZahl1;
        private double eingabeZahl2;
        private double ergebnis;

        public double EingabeZahl1
        {
            set { eingabeZahl1 = value; }
            get { return eingabeZahl1; }
        }

        public double EingabeZahl2
        {
            set { eingabeZahl2 = value; }
            get { return eingabeZahl2; }
        }

        public double Ergebnis
        {
            set { ergebnis = value; }
            get { return ergebnis; }
        }


        public void Addieren(double eingabeZahl1, double eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 + eingabeZahl2;
        }

        public void Subtrahieren(double eingabeZahl1, double eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 - eingabeZahl2;
        }

        public void Multiplizieren(double eingabeZahl1, double eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 * eingabeZahl2;
        }

        public void Dividieren(double eingabeZahl1, double eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 / eingabeZahl2;
        }

        public void Quadrieren(double eingabeZahl1, double eingabeZahl2)
        {
            Ergebnis = eingabeZahl1 * eingabeZahl1;
        }

        public void Wurzel(double eingabeZahl1, double eingabeZahl2)
        {
            Ergebnis = Math.Sqrt(eingabeZahl1);
        }

    }
}
