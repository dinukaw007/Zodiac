using System;
using System.Collections.Generic;
using System.Text;

namespace Zodiac.Lib.Planets
{
   public class Planet
    {
          public double GetJulDay(int month, int day ,int year)
        {
            var im = 0;
            var july_day = 0;
            im = 12 * (year + 4800) + month - 3;
            july_day = (2 * (im % 12) + 7 + 365 * im) / 12;
            july_day += day + im / 48 - 32083;
            july_day += (im / 4800 - im / 1200 + 38);
            if (july_day > 2299171)
            {
                return july_day;
            }
            else
            {
                return 0;
            }
           
        }


        public float GetTerms(int pp, int num, int t)
        {
           float v = 0.0f;
           

            return v;
        }
    }
}
