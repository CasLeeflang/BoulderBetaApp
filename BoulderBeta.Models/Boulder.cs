using System;
using System.Collections.Generic;

namespace BoulderBeta.Models
{
    public class Boulder
    {        
        public int BoulderID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Grade { get; set; }

        //Constructor
        public Boulder(int id, string name, string location, string grade)
        {
            this.BoulderID = id;
            this.Name = name;
            this.Location = location;
            this.Grade = grade;
        }

        //Parameterless constructor
        public Boulder()
        {
           
        }
    }    
}
