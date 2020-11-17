using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Zodiac.Lib.Planets
{
    public static class Planet
    {
        /// <summary>
        /// Get Julian day count by passing gregorian year month and day. 
        /// The Julian Day Count is a uniform count of days from a remote epoch in the past 
        /// </summary>
        /// <param name="year">Gregorian Year</param>
        /// <param name="month">Gregorian Month</param>
        /// <param name="day">Gregorian Day</param>
        /// <returns></returns>
        public static double GetJulDay(int year, int month, int day)
        {
            /*
             * Validate inputs
             */
            bool _isJulianDate = isJulianDate(year, month, day);

            /*
             *  If the month is January or February, subtract 1 from the year to get a new Y,
             *  and add 12 to the month to get a new M. (Thus, we are thinking of January and 
             *  February as being the 13th and 14th month of the previous year).
             */
            if (month == 1 || month == 2)
            {
                year = year - 1;
                month = month + 12;
            }
            
            /*
             * 
             */
            var A = year / 100;
            var B = A / 4;
            var C = 2 - A + B;
            int E = (int)(365.25 * (year + 4716));
            int F = (int)(30.6001 * (month + 1));
            var JD = C + day + E + F - 1524.5;
            return JD;
        }

        public static bool isJulianDate(int year, int month, int day)
        {
            // All dates prior to 1582 are in the Julian calendar
            if (year < 1582)
                return true;
            // All dates after 1582 are in the Gregorian calendar
            else if (year > 1582)
                return false;
            else
            {
                // If 1582, check before October 4 (Julian) or after October 15 (Gregorian)
                if (month < 10)
                    return true;
                else if (month > 10)
                    return false;
                else
                {
                    if (day < 5)
                        return true;
                    else if (day > 14)
                        return false;
                    else
                        // Any date in the range 10/5/1582 to 10/14/1582 is invalid 
                        throw new ArgumentOutOfRangeException(
                            "This date is not valid as it does not exist in either the Julian or the Gregorian calendars.");
                }
            }
        }

    }
}
