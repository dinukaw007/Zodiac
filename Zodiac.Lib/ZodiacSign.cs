using System;
using Zodiac.Lib.Planets;

namespace Zodiac.Lib
{
    public class ZodiacSign : ZodiacBase
    {
        private int BirthYear;
        private int BirthMonth;
        private int BirthDay;
        private int BirthHour;
        private int BirthMinutes;
        private float TimeZone;
        private double Lat;
        private double Lon;
        /// <summary>
        /// ZodiacSign Constructor
        /// </summary>
        /// <param name="birthYear">Enter Birth Year YYYY</param>
        /// <param name="birthMonth">Enter Birth Month MM</param>
        /// <param name="birthDay">Enter Birth Day DD</param>
        /// <param name="birthHour">Enter Birth Hour HH</param>
        /// <param name="birthMinutes">Enter Birth Minutes MM</param>
        /// <param name="timeZone">Enter Time Zone Between -12.0 to +12.0</param>
        /// <param name="lat">Enter Latitude Between-90.0 to +90.0</param>
        /// <param name="lon">Enter Longitude Between-90.0 to +90.0</param>
        public ZodiacSign(int birthYear, int birthMonth, int birthDay, int birthHour, int birthMinutes, float timeZone, double lat, double lon)
        {
            TimeZoneValidator(timeZone);
            LatitudeLongitudeValidator(lat, "Latitude");
            LatitudeLongitudeValidator(lon, "Longitude");
            
            BirthYear = birthYear;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
            BirthHour = birthHour;
            BirthMinutes = birthMinutes;
            TimeZone = timeZone;
            Lat = lat;
            Lon = lon;
        }


        private void TimeZoneValidator(float timeZone)
        {
            if(timeZone > 12.0 && timeZone < -12.0)
            {
                throw new ArgumentException("Enter Time Zone Between -12.0 to +12.0'","timeZone");
            }
            
        }

        private void LatitudeLongitudeValidator(double LatLon, string type)
        {
            if (LatLon > 90.0 && LatLon < -90.0)
            {
                throw new ArgumentException(type + " Between-90.0 to +90.0'", type);
            }

        }

        public PlanetaryDetail GetZodiacSign()
        {
            return Ascendant;
        }

        public void CalcualteZodiacSign()
        {
           Ascendant = new PlanetaryDetail(14.24f, "Capricon");
        }

        public void CalcualtePlanetGetJulDay()
        {
           Ascendant = new PlanetaryDetail(14.24f, "Capricon");
        }

    }
}
