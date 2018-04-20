using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    class Berechnungen
    {
        public static string Datum()
        {
            DateTime datum = DateTime.Now;
            string format = "MMM yyyy";
            return datum.ToString(format);
        }
    }
}
