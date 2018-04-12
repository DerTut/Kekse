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
            int zahl;
            do
            {
            zahl = Zahl();
            var getrennteZahl = Zahl_trennen(zahl);
            var quadrate = Quadrate_berechnen(getrennteZahl);
            var summe = Summe_berechen(quadrate);
            //var ichbindasersteergebnis = überprüfe_Zahl(summe);
            zahl = summe;
            } while (zahl != 1 && zahl != 4);
        }

        static int Zahl()
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
            for (int i = 1; i <= ziffernanzahl; i++)
            {
                liste.Add(Convert.ToInt32(Convert.ToString(zahl).Substring(i, 1)));
            }
            return liste;
        }
        public static List<int> Quadrate_berechnen(List<int> getrennteZahl)
        {
            for (int i = 0; i < getrennteZahl.Count; i++)
            {
                getrennteZahl[i] = getrennteZahl[i] * getrennteZahl[i];
            }
            return getrennteZahl;
        }
        public static int Summe_berechen(List<int> quadrate)
        {
            int summe = quadrate.Sum();
            return summe;
        }
        //internal static int überprüfe_Zahl(int summe)
        //{
        //    switch (summe)
        //    {
        //        case 1:
        //            return 1;
        //        case 4:
        //            return 4;
        //        default:
        //            return summe;

        //    }
        //}
    }
}
