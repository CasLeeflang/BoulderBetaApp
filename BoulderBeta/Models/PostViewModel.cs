using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoulderBeta.MVC.Models
{
    public class PostViewModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int BoulderId { get; set; }

        [Required(ErrorMessage = "Please fill in a URL for the video.")]
        [DataType(DataType.Url)]
        public string VideoUrl { get; set; }


        //Not neccessary in viewModel (yet)
        //public int  NofRatings { get; set; }
        //public int TotRating { get; set; }

    }
}
