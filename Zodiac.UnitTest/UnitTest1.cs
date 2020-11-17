using NUnit.Framework;
using System;
using Zodiac.Lib;
using Zodiac.Lib.Planets;

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
           
            var julDay = Planet.GetJulDay(3, 1, 1990);
            Assert.AreEqual(2447952.0d, julDay);
        }
    }
}