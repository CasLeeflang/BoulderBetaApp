using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BoulderBeta.Models;
using BoulderBeta.Logic;

namespace BoulderBeta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Boulder()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Listen for Http Post and send data to the server
        [HttpPost]
        public ActionResult Index(Boulder boulder)
        {
            //Add boulder to Storage location lis BoulderStorage
            BoulderBeta.Logic.BoulderProcessor.Save(boulder);
            BoulderBeta.Logic.TagProcessor.SaveTag(boulder);
            //BoulderBeta.Logic.BoulderProcessor.addBoulder(boulder.BoulderName, boulder.Location, boulder.Grade, boulder.Tag);
            ModelState.Clear();
            return View();
        }
    }
}
