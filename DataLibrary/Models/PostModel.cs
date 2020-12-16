using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BoulderId { get; set; }
        public int NofRatings { get; set; }
        public int TotRating { get; set; }
        public string VideoUrl { get; set; }

        //public PostModel(int userId, int boulderId, int nofRatings, int totRating)
        //{
        //    this.UserId = userId;
        //    this.BoulderId = boulderId;
        //    this.NofRatings = nofRatings;
        //    this.TotRating = totRating;
        //}

        //public PostModel()
        //{

        //}
    }
}
