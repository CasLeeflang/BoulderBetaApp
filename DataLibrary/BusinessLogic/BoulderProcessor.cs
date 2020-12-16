using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public static List<BoulderModel> LoadBoulders()
        {
            string sql = @"select Id, Name, Location, Grade
                            from dbo.Boulder;";

            return SQLDataAccess.LoadData<BoulderModel>(sql);
        }

        public static List<BoulderModel> LoadBoulderById(int id)
        {
            string sql = @"select Id, Name, Location, Grade
                            from dbo.Boulder where Id = " + id;

            return SQLDataAccess.LoadData<BoulderModel>(sql);
        }

        public static bool DeleteBoulder(int id)
        {
            try
            {
                string sql = @"delete from dbo.Boulder where Id = " + id;
                SQLDataAccess.DeleteData<BoulderModel>(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<BoulderModel> SearchBoulders(string searchTerm)
        {
            string searchCondition = "'%" + searchTerm + "%'";
            string sql = @"select *
                            from dbo.Boulder 
                            where Name like " + searchCondition +
                            "or Location like" + searchCondition +
                            "or Grade like" + searchCondition;

            return SQLDataAccess.LoadSearchData<BoulderModel>(sql);
        }
    }
}
