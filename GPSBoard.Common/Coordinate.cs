using System;
using System.Globalization;

namespace GPSBoard.Common
{
    public class Coordinate
    {
        public int Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public override string ToString()
        {
            return "Latitude: " + Latitude.ToString(CultureInfo.InvariantCulture) + ", Longitude: " + Longitude.ToString(CultureInfo.InvariantCulture);
        }
    }
}
