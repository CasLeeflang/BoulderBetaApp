﻿using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.BusinessLogic
{
    public static class BoulderProcessor
    {
        public static int CreateBoulder(string name, string location, string grade)
        {
            //Mapping view model to logic model
            BoulderModel data = new BoulderModel
            {                
                Name = name,
                Location = location,
                Grade = grade
            };

            //parameterised sql
            string sql = @"insert into dbo.Boulder (Name, Location, Grade)
                            values(@Name, @Location, @Grade);";

            return SQLDataAccess.SaveData(sql, data);
        }

        //Why not allowed to be public?!
        static List<BoulderModel> LoadBoulders()
        {
            string sql = @"select Id, BoulderId, Name, Location, Grade
                            from dbo.Boulder;";

            return SQLDataAccess.LoadData<BoulderModel>(sql);
        }
    }
}