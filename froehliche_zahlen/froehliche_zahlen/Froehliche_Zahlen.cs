using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace froehliche_zahlen
{
    public class Froehliche_Zahlen
    {
        public static void Eingabe_der_Zahl()
        {
            var zahl = Eingabe();
            var getrennteZahl = Zahl_trennen(zahl);
            var quadrate = Quadrate_berechnen();
            var summe = Summe_berechen();
        }

        static int Eingabe()
        {
            Console.Write("Geben Sie eine Zahl ein: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static List<int> Zahl_trennen(int zahl)
        {
            var zifferanzahl = Zifferanzahl_ermitteln(zahl);
            var liste = Liste_erstellen();
            var gefüllte_liste = liste_füllen(liste, zahl, zifferanzahl);
            return gefüllte_liste;
        }
        public static int Zifferanzahl_ermitteln(int zahl)
        {
            string zahlstring = Convert.ToString(zahl);
            int ziffernanzahl = zahlstring.Length;
            return ziffernanzahl;
        }
        public static List<int> Liste_erstellen()
        {
            List<int> Liste = new List<int>();
            return Liste;
        }
        public static List<int> liste_füllen(List<int> liste, int zahl, int ziffernanzahl)
        {
            string zahlstring = Convert.ToString(zahl);
            for (int i = 1; i <= ziffernanzahl; i++)
            {
                liste.Add(Convert.ToInt32(zahlstring.Substring(i, 1)));
            }
            return liste;
        }
    }
}
