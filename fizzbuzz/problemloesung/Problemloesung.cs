using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemloesung
{
    public class Problemloesung
    {
        public static Dictionary<int, string> Woerterbuch_start(int untergrenze, int obergrenze)
        {
            var woerterbuch = Erstelle_Woerterbuch(untergrenze, obergrenze);
            return woerterbuch;
        }

        internal void Erstelle_Woerterbuch(int untergrenze, int obergrenze)
        {

            for (int i = untergrenze; i < obergrenze; i++)
            {

            }

            Dictionary<int, string> woerterbuch_liste = new Dictionary<int, string>();
            woerterbuch_liste.Add(3);
            woerterbuch_liste.Add(5);

            //Kommentar
            //woerterbuch_liste.Add(3, "Fuss");
            //woerterbuch_liste.Add(5, "Buss");
            //woerterbuch_liste.Add(3, "Fuss");
        }
    }
}
