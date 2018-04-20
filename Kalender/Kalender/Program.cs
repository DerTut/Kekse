using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eingabe;
using System.Threading.Tasks;

namespace Kalender
{
    class Program
    {
        static void Main(string[] args)
        {
            Eingabe.Eingabe.Eingabe_ueberpruefen();
            Console.ReadKey();
        }
    }
}
