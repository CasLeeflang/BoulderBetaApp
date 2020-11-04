using BoulderBeta.Models;
using System;
using System.Collections.Generic;

namespace BoulderBeta.Logic
{
    public class BoulderProcessor
    {
        //Temporary boulder storage location
        public static List<Boulder> BoulderStorage = new List<Boulder>() {
            new Boulder
            {
                BoulderName = "Rainbow Rocket",
                Location = "Fontaine Bleu",
                Grade = "9A",
                BoulderID = 0,
                Tag = "Dynamic"
            },
            new Boulder
            {
                BoulderName = "DynoDino",
                Location = "Fontaine Bleu",
                Grade = "6A+",
                BoulderID = 1,
                Tag = "Dynamic"
            },
            new Boulder
            {
                BoulderName = "Gaffer",
                Location = "Fontaine Bleu",
                Grade = "7B",
                BoulderID = 2,
                Tag = "Crimp"
            },
            new Boulder
            {
                BoulderName = "Gaffer",
                Location = "Fontaine Bleu",
                Grade = "7B",
                BoulderID = 3
            }
        };

        public static List<Boulder> sortedList = new List<Boulder>();

        public static void CreateTagList(string tag)
        {
            foreach (var boulder in BoulderStorage)
            {
                if (boulder.Tag == tag)
                {
                    sortedList.Add(boulder);
                }               
            }
        }

        //Constructs boulder based on form input
        public static void addBoulder(string boulderName, string location, string grade, string tag)
        {
            Boulder tempBoulder = new Boulder
            {
                BoulderName = boulderName,
                Location = location,
                Grade = grade,
                BoulderID = BoulderStorage.Count,
                Tag = tag
            };
            //Add boulder to storage
            BoulderStorage.Add(tempBoulder);
        }

    }
}
