using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using froehliche_zahlen;
using NUnit.Framework;
using System.Threading.Tasks;

namespace froehlliche_zahlen_testing
{
    [TestFixture]
    public class Froehliche_Zahlen_Testing
    {
        /*Change here the number you want to test*/
        int number = YOUR_NUMBER;
        /****************************************/

        [Test, Category("Gerüst")]
        public void Froehliche_Zahl()
        {
            var ergebnis = Froehliche_Zahlen.Berechnung(number);
            Assert.AreEqual(1, ergebnis);
        }
        [Test, Category("Gerüst")]
        public void Traurige_Zahl()
        {
            var ergebnis = Froehliche_Zahlen.Berechnung(number);
            Assert.AreEqual(4, ergebnis);
        }
    }
}
