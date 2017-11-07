using System;
using System.Collections.Generic;
using System.Text;
using GPSBoard.Common;
using System.Linq;

namespace GPSBoard.Data
{
    public class CoordinateRepository : ICoordinateRepository
    {
        private GPSBoardContext gpsBoardContext;

        public CoordinateRepository(GPSBoardContext gpsBoardContext)
        {
            this.gpsBoardContext = gpsBoardContext;
        }

        public void Create(Coordinate dc)
        {
            gpsBoardContext.Coordinates.Add(dc);
            gpsBoardContext.SaveChanges();
        }

        public Coordinate GetNewest()
        {
            return gpsBoardContext.Coordinates.Last();
        }
    }
}
