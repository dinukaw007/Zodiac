using NUnit.Framework;
using System;
using Zodiac.Lib;
using Zodiac.Lib.Planets;
using System.Globalization;

namespace Zodiac.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetGetZodiacSignTest()
        {
            ZodiacSign newZodiac = new ZodiacSign(1973, 4, 24, 14, 25, 5.0f, 0.4, 0.3);
            newZodiac.CalcualteZodiacSign();
            var ZodiacSign = newZodiac.GetZodiacSign();
            Assert.AreEqual(ZodiacSign.Degrees, 14.24f);
        }

        [Test]
        public void PlanetGetJulDayTest()
        {
            double julDay = Planet.GetJulDay(2020, 1,1);
            //double time = 0 + (0 / 60.0);
            //time -= 0;
            //julDay += time / 24.0;
            var testVlue = 2458849.5;
            Assert.AreEqual(testVlue, julDay);
        }
    }
}