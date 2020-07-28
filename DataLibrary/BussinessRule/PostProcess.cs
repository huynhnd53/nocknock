using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.BussinessRule
{
    public static class PostProcess
    {
        public static List<PostModel> SearchPostByKey(string key)
        {
            string sql =
                @"with p2 as (select count(r.ProfileID) as NoOflikes, p.PostID
                    from Post p left join Reaction r on p.PostID = r.PostID
                    join ReactionType t on t.TypeID = r.TypeID
                    group by p.PostID),
                    p3 as(select count(CommentID) as NoOfCmts, p.PostID
                    from Post p inner join Comment c 
                    on p.PostID = c.PostID
                    group by p.PostID
                    )
                    select post.*, p.ProfileName,p.ProfileID,p.ProfilePhoto as ProfileImage,p2.NoOflikes, p3.NoOfCmts
                    from Profile p join Post post on p.ProfileID = post.ProfileID
                    join p2 on p2.PostID = post.PostID 
                    join p3 on p3.PostID = post.PostID
                    where post.PostContent like '%"+key+"%'";
            return SqlDataAccess.LoadData<PostModel>(sql);
        }

        public static List<PostModel> SearchTop3PostByKey(string key)
        {
            string sql =
                @"SELECT        TOP 3 PostID, ProfileID, PostContent, PostDate
                FROM            Post
                WHERE        (PostContent LIKE N'%" + key + "%')";
            return SqlDataAccess.LoadData<PostModel>(sql);
        }
    }
}
