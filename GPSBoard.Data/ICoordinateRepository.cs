using GPSBoard.Common;

namespace GPSBoard.Data
{
    public interface ICoordinateRepository
    {
        void Create(Coordinate dc);
        Coordinate GetNewest();
    }
}