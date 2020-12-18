using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using static DataLibrary.BusinessLogic.PostProcessor;


namespace BoulderBeta.MVC.Controllers
{
    public class VideoController : Controller
    {      

        [HttpPost("SaveVideo")]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        [RequestSizeLimit(209715200)]
        public async Task<IActionResult> SaveVideo(List<IFormFile> videoFiles, int boulderId, int userId)
        {
            

            var size = videoFiles.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach(var formFile in videoFiles)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\VideoUploads", formFile.FileName).ToString();
                filePaths.Add(filePath);

                if (ModelState.IsValid)
                {
                    int recordsCreate = CreatePost(userId,
                        boulderId,
                        formFile.FileName);

                }

                using ( var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }

            

            return RedirectToAction("Index", "Home");
        }
    }
}
