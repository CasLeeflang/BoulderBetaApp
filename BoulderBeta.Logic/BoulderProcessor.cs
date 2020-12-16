using BoulderBeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoulderBeta.Logic
{
    public static class BoulderProcessor
    {
        public static List<Boulder> BoulderStorage = new List<Boulder>() {
            new Boulder(1, "Rainbow Rocket", "FontainBleu", "9A")           
        };

        //Return a list of all boulders, get from DB instead of boulderstorage
        public static List<Boulder> GetAll() => BoulderStorage;

        //Save a boulder. Change to save to DB instead of BoulderStorage
        public static void Save(Boulder boulder)
        {
            //BoulderID Increases with every boulder added by 1
            var maxID = BoulderStorage.Max(x => x.BoulderID);
            //boulder.BoulderID = maxID + 1;
            BoulderStorage.Add(boulder);

        }
    }
}
