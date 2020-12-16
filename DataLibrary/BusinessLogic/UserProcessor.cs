using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.BusinessLogic
{
    public class UserProcessor
    {
        public static List<UserModel> LoadUserById(int userId)
        {
            Console.WriteLine(userId);
            string sql = @"select *
                            from dbo.TempUsers where Id = " + userId;

            return SQLDataAccess.LoadData<UserModel>(sql);
        }
    }
}
