using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoulderBeta.Models;

namespace BoulderBeta.Logic
{
    public class TagProcessor
    {
        public static List<Tag> TagStorage = new List<Tag>();
        public static void SaveTag(string tag)
        {
            TagStorage.Add(new Tag(tag, 0));            
        }
    }
}

 