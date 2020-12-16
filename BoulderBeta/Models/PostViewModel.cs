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
        public int UserId { get; private set; }

        [Required]
        public int BoulderId { get; private set; }

        [Required(ErrorMessage = "Please fill in a URL for the video.")]
        [DataType(DataType.Url)]
        public string VideoUrl { get; private set; }

        public PostViewModel(int userId, int boulderId)
        {
            this.UserId = userId;
            this.BoulderId = boulderId;
        }



    }
}
