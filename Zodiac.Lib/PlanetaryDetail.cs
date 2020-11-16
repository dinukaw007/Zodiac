using System;
using System.Collections.Generic;
using System.Text;

namespace Zodiac.Lib
{
    public class PlanetaryDetail
    {
        public PlanetaryDetail(float degrees, string rasi)
        {
            Degrees = degrees;
            Rasi = rasi;
        }

        public float Degrees { get; set; }
        public string Rasi { get; set; }
    }
}
