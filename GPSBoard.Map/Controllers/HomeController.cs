using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GPSBoard.Map.Models;
using GPSBoard.Map.ViewModelRepositories;

namespace GPSBoard.Map.Controllers
{
    public class HomeController : Controller
    {
        CoordinateViewModelRepository coordinateViewModelRepo;

        public HomeController(CoordinateViewModelRepository coordinateViewModelRepo)
        {
            this.coordinateViewModelRepo = coordinateViewModelRepo;
        }

        public IActionResult Index()
        {
            return View(coordinateViewModelRepo.GetNewest());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
