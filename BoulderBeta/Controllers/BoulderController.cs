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

namespace BoulderBeta.MVC.Controllers
{
    public class BoulderController : Controller
    {
        //private IOptions<AppSettingsModel> settings;

        //public BoulderController(IOptions<AppSettingsModel> settings)
        //{
        //    this.settings = settings;
        //}

        public IConfiguration configuration;
        public BoulderController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }
        public ActionResult UploadBoulder()
        {
            ViewBag.Message = "Upload Boulder";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadBoulder(BoulderModel model)
        {
            if (ModelState.IsValid)
            {                
                int recordsCreate = CreateBoulder(model.Name, 
                    model.Location, 
                    model.Grade);
                return RedirectToAction("Boulder", "Home");
            }
            return View();
        }
    }
}
