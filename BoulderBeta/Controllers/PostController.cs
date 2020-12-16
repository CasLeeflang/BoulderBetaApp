﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using static DataLibrary.BusinessLogic.PostProcessor;

namespace BoulderBeta.MVC.Controllers
{
    public class PostController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadPost(PostModel model, int boulderId, int userId)
        {         


            if (ModelState.IsValid)
            {

                int recordsCreate = CreatePost(userId,
                    boulderId,                    
                    model.VideoUrl);
                return RedirectToAction("Boulder", "Home");
            }
            return RedirectToAction("Post", "Home");
        }
    }
}
