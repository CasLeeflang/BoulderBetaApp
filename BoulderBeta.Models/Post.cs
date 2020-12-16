using System;
using System.Collections.Generic;
using System.Text;

namespace BoulderBeta.Models
{
    class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public int BoulderID { get; set; }
        public int NOfRatings { get; set; }
        public int TotRating { get; set; }

        public Post(int postid, int userid, int boudlerid, int nofrating, int totrating)
        {
            this.PostID = postid;
            this.UserID = userid;
            this.BoulderID = boudlerid;
            this.NOfRatings = nofrating;
            this.TotRating = totrating;
        }
    }
}
