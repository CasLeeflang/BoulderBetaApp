using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class PostProcessor
    {
        public static int CreatePost(int userId, int boulderId, string url)
        {
            //Mapping view model to logic model
            PostModel data = new PostModel
            {
                UserId = userId,
                BoulderId = boulderId,
                NofRatings = 0,
                TotRating = 0,
                VideoUrl = url
            };

            //parameterised sql
            string sql = @"insert into dbo.Post (UserId, BoulderId, NofRatings, TotRating, VideoUrl)
                            values(@UserId, @BoulderId, @NofRatings, @TotRating, @VideoUrl);";

            return SQLDataAccess.SaveData(sql, data);
        }
        public static List<PostModel> LoadPostsByBoulder(int id)
        {
            string sql = @"select *
                            from dbo.Post where BoulderId =" + id;

            return SQLDataAccess.LoadData<PostModel>(sql);
        }



    }
}
