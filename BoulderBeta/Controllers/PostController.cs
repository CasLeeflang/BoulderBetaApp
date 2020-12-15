using System;
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
        public ActionResult UploadPost(PostModel model)
        {         


            if (ModelState.IsValid)
            {

                int recordsCreate = CreatePost(model.UserId,
                    model.BoulderId,                    
                    model.VideoUrl);
                return RedirectToAction("Boulder", "Home");
            }
            return RedirectToAction("Post", "Home");
        }
    }
}
