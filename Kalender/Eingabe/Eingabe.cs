using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design;
using Exit;
using System.Threading.Tasks;

namespace Eingabe
{
    public class Eingabe
    {
        internal static int Design_aufrufen()
        {
            Design.Design.Design_erstellen();
            return 1;
        }
        public static int Eingabe_ueberpruefen()
        {
            string eingabe = Eingabe_eingeben();
            if (eingabe == "cal")
            {
                Design_aufrufen();
                Eingabe_ueberpruefen();
            }
            else if (eingabe == "exit" || eingabe == "ende" || eingabe == "beenden")
            {
                Exit.Exit.Beenden();
            }
            else
            {
                Eingabe_ueberpruefen();
            }
            return 1;
        }
        internal static string Eingabe_eingeben()
        {
            Console.Write("Calendar:>");
            string eingabe = Console.ReadLine();
            return eingabe.ToLower();
        }
    }
}
