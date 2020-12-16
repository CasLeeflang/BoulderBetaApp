using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BoulderBeta.Models;
using Microsoft.Extensions.Configuration;
using DataLibrary.BusinessLogic;
using DataLibrary.Models;
using BoulderBeta.MVC.Models;

namespace BoulderBeta.Controllers
{
    public class HomeController : Controller
    {      

        public IActionResult Index()
        {
            List<BoulderModel> BoulderList = BoulderProcessor.LoadBoulders();
            return View(BoulderList);
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }       

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Boulder()
        {
            List<BoulderModel> BoulderList = BoulderProcessor.LoadBoulders();
            return View(BoulderList);
        }

        public IActionResult BoulderView(int id)
        {
            List<BoulderModel> boulder = BoulderProcessor.LoadBoulderById(id);
            return View(boulder);
        }

        public IActionResult DeleteBoulderView(int boulderId, int numberOfPosts)
        {
            List<BoulderModel> deleteBoulder = BoulderProcessor.LoadBoulderById(boulderId);
            ViewData["numberOfPosts"] = numberOfPosts;
            
            return View(deleteBoulder);
        }

        public IActionResult Post(int boulderId, int userId)
        {
            PostViewModel newPost = new PostViewModel(userId, boulderId);
            return View(newPost);
        }

        public IActionResult SearchPage(string searchTerm)
        {
            Console.WriteLine(searchTerm);
            List<BoulderModel> searchList = BoulderProcessor.SearchBoulders(searchTerm);
            return View(searchList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
