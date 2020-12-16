using System;
using System.Collections.Generic;
using System.Text;

namespace BoulderBeta.Models
{
    class Comment
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }
        public string Content { get; set; }

        public Comment(int commentid, int userid, int postid, string content)
        {
            this.CommentID = commentid;
            this.UserID = userid;
            this.PostID = postid;
            this.Content = content;
        }
    }
}
