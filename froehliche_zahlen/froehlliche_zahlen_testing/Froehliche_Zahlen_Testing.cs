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
        [Test, Category("Gerüst")]
        public void Froehliche_Zahl()
        {
            var ergebnis = Froehliche_Zahlen.Berechnung(100);
            Assert.AreEqual(1, ergebnis);
        }
    }
}
