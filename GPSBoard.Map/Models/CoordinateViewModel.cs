using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GPSBoard.Map.Models
{
    public class CoordinateViewModel
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public String ToInvariantCulture(decimal point)
        {
            return point.ToString(CultureInfo.InvariantCulture);
        }
    }
}
