using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GPSBoard.WebApi.Converters;
using GPSBoard.Data;

namespace GPSBoard.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GPSController : Controller
    {
        CoordinateConverter coordinateConverter;
        ICoordinateRepository coordinateRepo;

        public GPSController(CoordinateConverter coordinateConverter, ICoordinateRepository coordinateRepo)
        {
            this.coordinateConverter = coordinateConverter;
            this.coordinateRepo = coordinateRepo;
        }

        // GET api/gps/{dcm}
        [HttpGet("{dcm}")]
        public String Get(String dcm)
        {
            var dc = coordinateConverter.Convert(dcm);
            return "DD: " + dc.ToString();
        }

        // GET api/gps/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/gps
        [HttpPost("new/{dcm}")]
        public string Post(string dcm)
        {
            var dc = coordinateConverter.Convert(dcm);
            coordinateRepo.Create(dc);
            return "DD: " + dc.ToString() + " has been added to DB";
        }

        // DELETE api/gps/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
