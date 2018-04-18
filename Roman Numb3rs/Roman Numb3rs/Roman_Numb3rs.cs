using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numb3rs
{
    public class Roman_Numb3rs
    {
        public static void Main()
        {
            Console.WriteLine(Roman(3007));
            Console.ReadLine();
        }

        public static string Roman(int arab_num)
        {
            var woerterbuch = Woerterbuch();
            var roemische_zahl = Berechnung(arab_num, woerterbuch);
            return roemische_zahl;
        }

        internal static Dictionary<int,string> Woerterbuch()
        {
            var woerterbuch_leer = Woerterbuch_erstellen();
            var gefuelltes_woerterbuch = Woerterbuch_fuellen(woerterbuch_leer);
            return gefuelltes_woerterbuch;
        }
        internal static Dictionary<int,string> Woerterbuch_erstellen()
        {
            Dictionary<int, string> woerterbuch_leer = new Dictionary<int, string>();
            return woerterbuch_leer;
        }
        internal static Dictionary<int, string> Woerterbuch_fuellen(Dictionary<int,string> woerterbuch_leer)
        {
            woerterbuch_leer.Add(1,"I");
            woerterbuch_leer.Add(4, "IV");
            woerterbuch_leer.Add(5, "V");
            woerterbuch_leer.Add(9, "IX");
            woerterbuch_leer.Add(10, "X");
            woerterbuch_leer.Add(40, "XL");
            woerterbuch_leer.Add(50, "L");
            woerterbuch_leer.Add(90, "XC");
            woerterbuch_leer.Add(100, "C");
            woerterbuch_leer.Add(400, "CD");
            woerterbuch_leer.Add(500, "D");
            woerterbuch_leer.Add(900, "CM");
            woerterbuch_leer.Add(1000, "M");
            return woerterbuch_leer;
        }
        internal static string Berechnung(int arab_zahl, Dictionary<int,string> woerterbuch)
        {
            string roem_zahl = "";

            roem_zahl = Tausend(arab_zahl, roem_zahl, woerterbuch);
            roem_zahl = Neunhundert(arab_zahl, roem_zahl, woerterbuch);
            roem_zahl = Fuenfhundert(arab_zahl, roem_zahl, woerterbuch);
            roem_zahl = Vierhundert(arab_zahl, roem_zahl, woerterbuch);

           
            if (arab_zahl > 500)
            {
                arab_zahl = arab_zahl - 500;
                roem_zahl = roem_zahl + woerterbuch[500];
            }
            if (arab_zahl > 400)
            {
                arab_zahl = arab_zahl - 400;
                roem_zahl = roem_zahl + woerterbuch[400];
            }
            while (arab_zahl > 99)
            {
                arab_zahl = arab_zahl - 100;
                roem_zahl = roem_zahl + woerterbuch[100];
            }
            if (arab_zahl > 90)
            {
                arab_zahl = arab_zahl - 90;
                roem_zahl = roem_zahl + woerterbuch[90];
            }
            if (arab_zahl > 50)
            {
                arab_zahl = arab_zahl - 50;
                roem_zahl = roem_zahl + woerterbuch[50];
            }
            if (arab_zahl > 40)
            {
                arab_zahl = arab_zahl - 40;
                roem_zahl = roem_zahl + woerterbuch[40];
            }
            while (arab_zahl > 9)
            {
                arab_zahl = arab_zahl - 10;
                roem_zahl = roem_zahl + woerterbuch[10];
            }
            if (arab_zahl == 9)
            {
                arab_zahl = arab_zahl - 9;
                roem_zahl = roem_zahl + woerterbuch[9];
            }
            if (arab_zahl > 5)
            {
                arab_zahl = arab_zahl - 5;
                roem_zahl = roem_zahl + woerterbuch[5];
            }
            if (arab_zahl > 4)
            {
                arab_zahl = arab_zahl - 4;
                roem_zahl = roem_zahl + woerterbuch[4];
            }
            while (arab_zahl >= 1)
            {
                arab_zahl = arab_zahl - 1;
                roem_zahl = roem_zahl + woerterbuch[1];
            }
            return roem_zahl;
        }
        internal static string Tausend(int arab_zahl, string roem_zahl, Dictionary<int, string> woerterbuch)
        {
            while (arab_zahl > 999)
            {
                arab_zahl = arab_zahl - 1000;
                roem_zahl = roem_zahl + woerterbuch[1000];
            }
            return roem_zahl;
        }
        internal static string Neunhundert(int arab_zahl, string roem_zahl, Dictionary<int, string> woerterbuch)
        {
            if (arab_zahl > 900)
            {
                arab_zahl = arab_zahl - 900;
                roem_zahl = roem_zahl + woerterbuch[900];
            }
            return roem_zahl;
        }
    }
}
