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
            Dictionary<int, string> woerterbuch_zahl = new Dictionary<int, string>();
            for (int i = untergrenze; i < obergrenze; i++)
            {
                woerterbuch_zahl.Add(i, Convert.ToString(i));
            }
            //return woerterbuch_zahl;
        }
    }
}
