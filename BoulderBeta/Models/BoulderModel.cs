﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoulderBeta.MVC.Models
{
    //View model
    public class BoulderModel
    {
        [Display(Name= "Boulder Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Fill in a Name.")]
        public string Name { get; set; }
        
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Fill in a Location.")]
        public string Location { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Fill in a Grade.")]
        public string Grade { get; set; }
    }
}
