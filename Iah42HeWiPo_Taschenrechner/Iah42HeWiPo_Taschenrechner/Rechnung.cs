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
        //Bool für Unterscheidung zwischen Zahl1 und Zahl2
        private bool auswahlZahl2 = false;
        private string rechenschritt;


        /// <summary>
        /// Abrufen und Deklarierung der Variabel
        /// </summary>
        public string EingabeZahl1
        {
            set { eingabeZahl1 = value; }
            get { return eingabeZahl1; }
        }

        /// <summary>
        /// Abrufen und Deklarierung der Variabel
        /// </summary>
        public string EingabeZahl2
        {
            set { eingabeZahl2 = value; }
            get { return eingabeZahl2; }
        }

        /// <summary>
        /// Abrufen und Deklarierung der Variabel
        /// </summary>
        public string Ergebnis
        {
            set { ergebnis = value; }
            get { return ergebnis; }
        }

        /// <summary>
        /// Abrufen und Deklarierung der Variabel
        /// </summary>
        public bool AuswahlZahl2
        {
            set { auswahlZahl2 = value; }
            get { return auswahlZahl2; }
        }

        /// <summary>
        /// Abrufen und Deklarierung der Variabel
        /// </summary>
        public string Rechenschritt
        {
            set { rechenschritt = value; }
            get { return rechenschritt; }
        }

        /// <summary>
        /// Fügt der Variable "ergebnis" das Ergebnis der Addition der ersten beiden Zahlen hinzu
        /// </summary>
        /// <param name="eingabeZahl1"></param>
        /// <param name="eingabeZahl2"></param>
        public void Addieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) + Convert.ToDouble(eingabeZahl2));
        }

        /// <summary>
        /// Fügt der Variable "ergebnis" das Ergebnis der Subtraktion der ersten beiden Zahlen hinzu
        /// </summary>
        /// <param name="eingabeZahl1"></param>
        /// <param name="eingabeZahl2"></param>
        public void Subtrahieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) - Convert.ToDouble(eingabeZahl2));
        }

        /// <summary>
        /// Fügt der Variable "ergebnis" das Ergebnis der Multiplikation der ersten beiden Zahlen hinzu
        /// </summary>
        /// <param name="eingabeZahl1"></param>
        /// <param name="eingabeZahl2"></param>
        public void Multiplizieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) * Convert.ToDouble(eingabeZahl2));
        }

        /// <summary>
        /// Fügt der Variable "ergebnis" das Ergebnis der Divition der ersten beiden Zahlen hinzu
        /// </summary>
        /// <param name="eingabeZahl1"></param>
        /// <param name="eingabeZahl2"></param>
        public void Dividieren(string eingabeZahl1, string eingabeZahl2)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) / Convert.ToDouble(eingabeZahl2));
        }

        /// <summary>
        /// Fügt der Variable "ergebnis" das Ergebnis der Quadrierung der ersten Zahl
        /// </summary>
        /// <param name="eingabeZahl1"></param>
        public void Quadrieren(string eingabeZahl1)
        {
            Ergebnis = Convert.ToString(Convert.ToDouble(eingabeZahl1) * Convert.ToDouble(eingabeZahl1));
        }

        /// <summary>
        /// Fügt der Variable "ergebnis" das Ergebnis der Wurzel der ersten Zahl
        /// </summary>
        /// <param name="eingabeZahl1"></param>
        public void Wurzel(string eingabeZahl1)
        {
            Ergebnis = Convert.ToString(Math.Sqrt(Convert.ToDouble(eingabeZahl1)));
        }
    }
}
