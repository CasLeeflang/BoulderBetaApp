using System;
using System.Collections.Generic;
using System.Text;

namespace BoulderBeta.Models
{
    public class Tag
    {
        public string TagName{ get; set; }
        public int TagID { get; set; }

        public Tag(string name, int id) {
            this.TagName = name;
            this.TagID = id;
        }
    }


}
