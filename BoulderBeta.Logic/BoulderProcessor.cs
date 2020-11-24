using BoulderBeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoulderBeta.Logic
{
    public class BoulderProcessor
    {
        //Temporary boulder storage location
        public static List<Boulder> BoulderStorage = new List<Boulder>() {
            new Boulder
            {
                Name = "Rainbow Rocket",
                Location = "Fontaine Bleu",
                Grade = "9A",
                BoulderID = 0
                
            },
            new Boulder
            {
                Name = "DynoDino",
                Location = "Fontaine Bleu",
                Grade = "6A+",
                BoulderID = 1
                
            }
            
        };

        //Create list sortedList
        public static List<Boulder> sortedList = new List<Boulder>();

        //Return a list of boulders with the specified tag
        //public static List<Boulder> GetTagList(string tag)
        //{
        //    foreach (var boulder in BoulderStorage)
        //    {
        //        if (boulder.Tag == tag && !sortedList.Contains(boulder))
        //        {
        //            sortedList.Add(boulder);
        //        }
        //    }

        //    return sortedList;
        //}

        //Return a list of all boulders
        public static List<Boulder> GetAll()
        {
            return BoulderStorage;
        }

        //Save a boulder. Change to save to DB instead of BoulderStorage
        public static void Save(Boulder boulder)
        {
            //BoulderID Increases with every boulder added by 1
            var maxID = BoulderStorage.Max(x => x.BoulderID);
            boulder.BoulderID = maxID + 1;
            BoulderStorage.Add(boulder);

        }
    }
}
