using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoulderBeta.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.BoulderProcessor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using DataLibrary.Models;
using Microsoft.Extensions.Logging;
using BoulderBeta.Models;
using DataLibrary.BusinessLogic;

namespace BoulderBeta.MVC.Controllers
{
    public class BoulderController : Controller
    {
        
        
        public ActionResult UploadBoulder()
        {
            ViewBag.Message = "Upload Boulder";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadBoulder(BoulderModel model)
        {
            //string connString = appSettingsReaderService.connectionStringSection.SqlConn;

            //Console.WriteLine(connString);
            if (ModelState.IsValid)
            {               

                int recordsCreate = CreateBoulder(model.Name, 
                    model.Location, 
                    model.Grade);
                return RedirectToAction("Boulder", "Home");
            }
            return View();
        }

        public ActionResult DeleteBoulder(int boulderId)
        {
            BoulderProcessor.DeleteBoulder(boulderId);
            return RedirectToAction("Boulder", "Home");
        }       

    }
}



//Code to read connection string from appsettings.json (dont know how to use)

//private IOptions<AppSettingsModel> settings;

//public BoulderController(IOptions<AppSettingsModel> settings)
//{
//    this.settings = settings;
//}

//public IConfiguration configuration;
//public BoulderController(IConfiguration iConfig)
//{
//    configuration = iConfig;
//}



//private readonly ILogger<BoulderController> _logger;
//private readonly IAppSettingsReaderService appSettingsReaderService;


//public BoulderController(ILogger<BoulderController> logger, IAppSettingsReaderService _appSettingsReaderService)
//{
//    _logger = logger;
//    appSettingsReaderService = _appSettingsReaderService;
//}