using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public class Design
    {
        public static int Design_erstellen()
        {
            Kopfzeile_erstellen();
            erste_Dazumszeile_erstellen();
            zweite_Dazumszeile_erstellen();
            dritte_Dazumszeile_erstellen();
            vierte_Dazumszeile_erstellen();
            fuenfte_Dazumszeile_erstellen();
            sechste_Dazumszeile_erstellen();
            return 1;
        }
       internal static int Kopfzeile_erstellen()
        {
            Console.WriteLine("\n      April 2018");
            Console.WriteLine(" Mo Di Mi Do Fr Sa So");
            return 1;
        }
        internal static int erste_Dazumszeile_erstellen()
        {
            Console.WriteLine("                   01");
            return 2;
        }
        internal static int zweite_Dazumszeile_erstellen()
        {
            Console.WriteLine(" 02 03 04 05 06 07 08");
            return 2;
        }
        internal static int dritte_Dazumszeile_erstellen()
        {
            Console.WriteLine(" 09 10 11 12 13 14 15");
            return 2;
        }
        internal static int vierte_Dazumszeile_erstellen()
        {
            Console.WriteLine(" 16 17 18 19 20 21 22");
            return 2;
        }
        internal static int fuenfte_Dazumszeile_erstellen()
        {
            Console.WriteLine(" 23 24 25 26 27 28 29");
            return 2;
        }
        internal static int sechste_Dazumszeile_erstellen()
        {
            Console.WriteLine(" 30                  ");
            return 2;
        }
    }
}
