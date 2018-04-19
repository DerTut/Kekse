using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roman_Numb3rs;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Roman_Nub3rs_Test
{
    [TestFixture]
    public class Roman_Num3rs_Test
    {
        [Test, Category("Funktion")]
        public void Test_8()
        {
            string test_8 = Roman_Numb3rs.Roman_Numb3rs.Roman(8);
            Assert.AreEqual("VIII", test_8);
        }
        [Test, Category("Funktion")]
        public void Test_35()
        {
            string test_35 = Roman_Numb3rs.Roman_Numb3rs.Roman(39);
            Assert.AreEqual("XXXIX", test_35);
        }
        [Test, Category("Funktion")]
        public void Test_824()
        {
            string test_824 = Roman_Numb3rs.Roman_Numb3rs.Roman(824);
            Assert.AreEqual("DCCCXXIV", test_824);
        }
        [Test, Category("Funktion")]
        public void Test_1961()
        {
            string test_1961 = Roman_Numb3rs.Roman_Numb3rs.Roman(1961);
            Assert.AreEqual("MCMLXI", test_1961);
        }
        [Test, Category("Funktion")]
        public void Test_2018()
        {
            string test_2018 = Roman_Numb3rs.Roman_Numb3rs.Roman(2018);
            Assert.AreEqual("MMXVIII", test_2018);
        }
        [Test, Category("Funktion")]
        public void Test_400()
        {
            string test_400 = Roman_Numb3rs.Roman_Numb3rs.Roman(400);
            Assert.AreEqual("CD", test_400);
        }
    }
}
