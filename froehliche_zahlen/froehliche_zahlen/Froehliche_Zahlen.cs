using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace froehliche_zahlen
{
    public class Froehliche_Zahlen
    {
        public static void Main()
        {
            Console.WriteLine(Berechnung(87));
            Console.ReadLine();
        }
        public static int Berechnung(int zahl)
        {
            do
            {
            var getrennteZahl = Zahl_trennen(zahl);
            var quadrate = Quadrate_berechnen(getrennteZahl);
            var summe = Summe_berechen(quadrate);
            zahl = Convert.ToInt32(summe);
            } while (zahl != 1 && zahl != 4);
            return zahl;
        }
        internal static List<int> Zahl_trennen(int zahl)
        {
            var zifferanzahl = Zifferanzahl_ermitteln(zahl);
            var liste = Liste_erstellen();
            var gefüllte_liste = liste_füllen(liste, zahl, zifferanzahl);
            return gefüllte_liste;
        }
        internal static int Zifferanzahl_ermitteln(int zahl)
        {
            string zahlstring = Convert.ToString(zahl);
            int ziffernanzahl = zahlstring.Length;
            return ziffernanzahl;
        }
        internal static List<int> Liste_erstellen()
        {
            List<int> Liste = new List<int>();
            return Liste;
        }
        internal static List<int> liste_füllen(List<int> liste, int zahl, int ziffernanzahl)
        {
            for (int i = 1; i <= ziffernanzahl; i++)
            {
                liste.Add(Convert.ToInt32(Convert.ToString(zahl).Substring(i-1, 1)));
            }
            return liste;
        }
        internal static List<int> Quadrate_berechnen(List<int> getrennteZahl)
        {
            for (int i = 0; i < getrennteZahl.Count; i++)
            {
                Console.WriteLine("test");
                getrennteZahl[i] = getrennteZahl[i] * getrennteZahl[i];
            }
            return getrennteZahl;
        }
        internal static int Summe_berechen(List<int> quadrate)
        {
            int summe = quadrate.Sum();
            return summe;
        }
    }
}
