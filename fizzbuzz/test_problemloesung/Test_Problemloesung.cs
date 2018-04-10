using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problemloesung;
using NUnit.Framework;

namespace test_problemloesung
{
    [TestFixture]
    public class Test_Problemloesung
    {
        [Test, Category("Gerüsttest")]
        public void anzahl_zahlen()
        {
            var ergebnis = Problemloesung.zahltest(1, 45);
            Assert.AreEqual(45, ergebnis.Count());
        }
    }
}
