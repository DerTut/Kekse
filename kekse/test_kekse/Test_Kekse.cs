using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kekse;
using NUnit.Framework;

namespace test_kekse
{
    [TestFixture]
    public class Test_Kekse
    {
        [Test, Category("Akzeptanztest")]
        public void Zahlen_zwischen_Untergrenze_Obergrenze()
        {
            var ergebnis = Kekse.Start_Zahlen_testen(3, 5);
            Assert.AreEqual( new []{ 3,4,5}, ergebnis.ToArray());
        }

        [Test, Category("Gerüsttest")]
        public void anzahl_zahlen()
        {
            var ergebnis = Kekse.Zahlen_testen(-1, 45);
            Assert.AreEqual(47, ergebnis.Count());
        }
    }
}
