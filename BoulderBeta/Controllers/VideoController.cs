using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BoulderBeta.MVC.Controllers
{
    public class VideoController : Controller
    {      

        [HttpPost("SaveVideo")]
        public async Task<IActionResult> SaveVideo(List<IFormFile> videoFiles, int boulderId, int userId)
        {
            var size = videoFiles.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach(var formFile in videoFiles)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory()+"/VideoUploads/", formFile.FileName);
                filePaths.Add(filePath);

                using( var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            
            return RedirectToAction("Index", "Home");
        }
    }
}
