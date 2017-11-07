using GPSBoard.Data;
using GPSBoard.Map.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GPSBoard.Common;

namespace GPSBoard.Map.ViewModelRepositories
{
    public class CoordinateViewModelRepository
    {
        ICoordinateRepository coordinateRepo;

        public CoordinateViewModelRepository(ICoordinateRepository coordinateRepo)
        {
            this.coordinateRepo = coordinateRepo;
        }

        public CoordinateViewModel GetNewest()
        {
            return ParseToViewModel(coordinateRepo.GetNewest());
        }

        private CoordinateViewModel ParseToViewModel(Coordinate coordinate)
        {
            return new CoordinateViewModel
            {
                Latitude = coordinate.Latitude,
                Longitude = coordinate.Longitude
            };
        }
    }
}
