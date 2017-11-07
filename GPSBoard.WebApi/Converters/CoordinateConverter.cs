using GPSBoard.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPSBoard.WebApi.Converters
{
    public class CoordinateConverter
    {
        public Coordinate Convert(String dmsCoordinate)
        {
            int latitudeDeg;
            double latitudeMin;
            int longitudeDeg;
            double longitudeMin;

            if (String.IsNullOrEmpty(dmsCoordinate))
            {
                return null;
            }

            var gpsDetails = dmsCoordinate.Split(',');
            int.TryParse(gpsDetails[2].Substring(0, 2), out latitudeDeg);
            double.TryParse(gpsDetails[2].Substring(2), out latitudeMin);
            int.TryParse(gpsDetails[4].Substring(0, 3), out longitudeDeg);
            double.TryParse(gpsDetails[4].Substring(3), out longitudeMin);

            return new Coordinate
            {
                Latitude = CalculateDecimal(latitudeDeg, latitudeMin),
                Longitude = CalculateDecimal(longitudeDeg, longitudeMin)
            };
        }

        decimal CalculateDecimal(int degrees, double minutes)
        {
            return degrees + (decimal)minutes / 10000 / 60;
        }
    }
}
