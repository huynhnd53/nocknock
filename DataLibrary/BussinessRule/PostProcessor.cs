using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLibrary.DataAccess;
using DataLibrary.Models;


namespace DataLibrary.BusinessRule
{
    public static class PostProcessor
    {
       
        /// <summary>
        /// get new feed of a person: include posts of people he follows (exclude his own)
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static DataTable getPostByUsername(string username)
        {
            string sql = @"with p1 as(select pro.ProfileID, ProfileName, ProfilePhoto
from Follow f join Profile pro on f.FollowedID = pro.ProfileID
where FollowerID = (
select ProfileID
from Profile pro join Account a on pro.AccountID = a.AccountID
where Username = @user
)),
p2 as (select count(r.ProfileID) as NoOflikes, p.PostID
from Post p left join Reaction r on p.PostID = r.PostID
join ReactionType t on t.TypeID = r.TypeID
group by p.PostID),
p3 as(select count(CommentID) as NoOfCmts, p.PostID
from Post p inner join Comment c 
on p.PostID = c.PostID
group by p.PostID
)
select p.PostID, p1.ProfileID, p1.ProfileName, p1.ProfilePhoto,PostContent,PostDate, ISNULL(NoOflikes, 0) as NoOfLikes, ISNULL(NoOfCmts, 0) as NoOfCmts
from Post p join Profile pro on p.ProfileID = pro.ProfileID
join p1 on p1.ProfileID = p.ProfileID
left join p2 on p2.PostID = p.PostID
left join p3 on p3.PostID = p.PostID
order by PostDate desc

";
            SqlParameter param = new SqlParameter("@user", SqlDbType.VarChar);
            param.Value = username;
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param);
            return dt;
        }
        /// <summary>
        /// load new feed
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static DataTable getPostByPageByUsername(string username, int start, int end)
        {
            string sql = @"with p1 as(select pro.ProfileID, ProfileName, ProfilePhoto
from Follow f join Profile pro on f.FollowedID = pro.ProfileID
where FollowerID = (
select ProfileID
from Profile pro join Account a on pro.AccountID = a.AccountID
where Username = @user
)),
p2 as (select count(r.ProfileID) as NoOflikes, p.PostID
from Post p left join Reaction r on p.PostID = r.PostID
join ReactionType t on t.TypeID = r.TypeID
group by p.PostID),
p3 as(select count(CommentID) as NoOfCmts, p.PostID
from Post p inner join Comment c 
on p.PostID = c.PostID
group by p.PostID
),
p4 as (select p.PostID, p1.ProfileID, p1.ProfileName, p1.ProfilePhoto,PostContent,PostDate, ISNULL(NoOflikes, 0) as NoOfLikes, ISNULL(NoOfCmts, 0) as NoOfCmts
from Post p join Profile pro on p.ProfileID = pro.ProfileID
join p1 on p1.ProfileID = p.ProfileID
left join p2 on p2.PostID = p.PostID
left join p3 on p3.PostID = p.PostID)
--order by PostDate desc
select *
from (
select *,ROW_NUMBER() Over (order by PostDate desc) as rownum
from p4
) a
where rownum >=@start and rownum <=@end

";
            SqlParameter param = new SqlParameter("@user", SqlDbType.VarChar);
            param.Value = username;
            SqlParameter param1 = new SqlParameter("@start", SqlDbType.Int);
            param1.Value = start;
            SqlParameter param2 = new SqlParameter("@end", SqlDbType.Int);
            param2.Value = end;
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param,param1,param2);
            return dt;
        }


        /// <summary>
        /// get all post of an profileid
        /// </summary>
        /// <param name="profileid"></param>
        /// <returns></returns>
        public static DataTable getPostByProfileID(string profileid)
        {
            string sql = @"with p1 as(select ProfileID, ProfileName, ProfilePhoto
from Profile 
where ProfileID = @profileid),
--dem so like
p2 as (select count(r.ProfileID) as NoOflikes, p.PostID
from Post p left join Reaction r on p.PostID = r.PostID
join ReactionType t on t.TypeID = r.TypeID
group by p.PostID),
--dem so cmt
p3 as(select count(CommentID) as NoOfCmts, p.PostID
from Post p inner join Comment c 
on p.PostID = c.PostID
group by p.PostID
)
---1.2 Lấy các post của các profiles
select p.PostID, p1.ProfileID, p1.ProfileName, p1.ProfilePhoto,PostContent,PostDate, ISNULL(NoOflikes, 0) as NoOfLikes, ISNULL(NoOfCmts, 0) as NoOfCmts
from Post p join Profile pro on p.ProfileID = pro.ProfileID
join p1 on p1.ProfileID = p.ProfileID
left join p2 on p2.PostID = p.PostID
left join p3 on p3.PostID = p.PostID
order by PostDate desc";
            SqlParameter param = new SqlParameter("@profileid", SqlDbType.Int);
            param.Value = Convert.ToInt32(profileid);
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param);
            return dt;
        }
        //danh sách post của những người mình follow

        /// <summary>
        /// get my following posts list
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static List<PostModel> ListPostsMyFollowing(string username)
        {
            DataTable dt = getPostByUsername(username);
            List<PostModel> list = new List<PostModel>();
            foreach (DataRow dr in dt.Rows)
            {
                PostModel data = new PostModel
                {
                    PostID = Convert.ToInt32(dr["PostID"]),
                    ProfileID = Convert.ToInt32(dr["ProfileID"]),
                    PostContent = dr["PostContent"].ToString(),
                    PostDate = Convert.ToDateTime(dr["PostDate"]),
                    NoOfLikes = Convert.ToInt32(dr["NoOfLikes"]),
                    NoOfCmts = Convert.ToInt32(dr["NoOfCmts"]),
                    ProfileImage = dr["ProfilePhoto"].ToString(),
                    ProfileName = dr["ProfileName"].ToString()
                };
                list.Add(data);
            }
            return list;

        }

        public static List<PostModel> ListPostsMyFollowingByPage(string username, int start,int end)
        {
            DataTable dt = getPostByPageByUsername(username, start, end);
            List<PostModel> list = new List<PostModel>();
            foreach (DataRow dr in dt.Rows)
            {
                PostModel data = new PostModel
                {
                    PostID = Convert.ToInt32(dr["PostID"]),
                    ProfileID = Convert.ToInt32(dr["ProfileID"]),
                    PostContent = dr["PostContent"].ToString(),
                    PostDate = Convert.ToDateTime(dr["PostDate"]),
                    NoOfLikes = Convert.ToInt32(dr["NoOfLikes"]),
                    NoOfCmts = Convert.ToInt32(dr["NoOfCmts"]),
                    ProfileImage = dr["ProfilePhoto"].ToString(),
                    ProfileName = dr["ProfileName"].ToString()
                };
                list.Add(data);
            }
            return list;

        }
        /// <summary>
        /// get list post of person with profileid
        /// </summary>
        /// <param name="profileid"></param>
        /// <returns></returns>
        public static List<PostModel> ListPostByProfileID(string profileid)
        {
            DataTable dt = getPostByProfileID(profileid);
            List<PostModel> list = new List<PostModel>();
            foreach (DataRow dr in dt.Rows)
            {
                PostModel data = new PostModel
                {
                    PostID = Convert.ToInt32(dr["PostID"]),
                    ProfileID = Convert.ToInt32(dr["ProfileID"]),
                    PostContent = dr["PostContent"].ToString(),
                    PostDate = Convert.ToDateTime(dr["PostDate"]),
                    NoOfLikes = Convert.ToInt32(dr["NoOfLikes"]),
                    NoOfCmts = Convert.ToInt32(dr["NoOfCmts"]),
                    ProfileImage = dr["ProfilePhoto"].ToString(),
                    ProfileName = dr["ProfileName"].ToString()
                };
                list.Add(data);
            }
            return list;
        }
        /// <summary>
        /// get post by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable getPostbyID(string id)
        {
            string sql = @"with p2 as (select count(r.ProfileID) as NoOflikes, p.PostID
from Post p left join Reaction r on p.PostID = r.PostID
join ReactionType t on t.TypeID = r.TypeID
group by p.PostID),
p3 as(select count(CommentID) as NoOfCmts, p.PostID
from Post p inner join Comment c 
on p.PostID = c.PostID
group by p.PostID
)
select p.PostID, p.ProfileID, pro.ProfileName, pro.ProfilePhoto,PostContent,PostDate, ISNULL(NoOflikes, 0) as NoOfLikes, ISNULL(NoOfCmts, 0) as NoOfCmts
from Post p join Profile pro on p.ProfileID = pro.ProfileID
left join p2 on p2.PostID = p.PostID
left join p3 on p3.PostID = p.PostID
where p.PostID = @id";
            SqlParameter param1 = new SqlParameter("@id", SqlDbType.Int);
            param1.Value = Convert.ToInt32(id);
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param1);
            return dt;
        }


        /// <summary>
        /// create a new post
        /// </summary>
        /// <param name="profileid"></param>
        /// <param name="content"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int createNewPost(string profileid,string content,DateTime d)
        {
            string sql = @"insert into Post(ProfileID,PostContent,PostDate)
values (@profileid,@content,@date)";
            SqlParameter param = new SqlParameter("@profileid", SqlDbType.Int);
            param.Value = Convert.ToInt32(profileid);
            SqlParameter param1 = new SqlParameter("@content", SqlDbType.NVarChar);
            param1.Value = content;
            SqlParameter param2 = new SqlParameter("@date", SqlDbType.DateTime);
            param2.Value = d;
            return SqlDataAccess.ExecuteSQL(sql, param, param1, param2);
        }

    }
}
