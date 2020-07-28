using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessRule
{
    public static class CommentProcessor
    {
        /// <summary>
        /// get all comments of a post with postid know
        /// </summary>
        /// <param name="postid"></param>
        /// <returns></returns>
        public static DataTable getAllCommenybyPostID(string postid)
        {
            string sql = @"select c.*, ProfileName, ProfilePhoto, NotiDate as DateComment
from Comment c join Post p on c.PostID = p.PostID
join Profile pro on pro.ProfileID = c.ProfileID
join Notification n on n.NotiID = c.NotiID
where p.PostID = @id";
            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = Convert.ToInt32(postid);
            return SqlDataAccess.GetDataBySQL(sql, param);

        }
        /// <summary>
        /// add a new cmt to a post
        /// </summary>
        /// <param name="postid"></param>
        /// <param name="username"></param>
        /// <param name="content"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int addComment(string postid, string username, string content, DateTime d)
        {
            string sql = @"declare  @profileid as int
set @profileid = (
select ProfileID
from Profile p join Account a on a.AccountID = p.ProfileID
where Username = @username
)
declare @notiid as int
set @notiid = (
select NotiID from Notification
where postid = @postid and SenderID = @profileid and TypeNoti = 'Comment' and NotiDate = @date
);
insert into Comment(PostID,ProfileID,CommentContent,NotiID)
values (@postid,@profileid,@cmt,@notiid)";
            SqlParameter param0 = new SqlParameter("@username", SqlDbType.VarChar);
            param0.Value = username;
            SqlParameter param1 = new SqlParameter("@postid", SqlDbType.Int);
            param1.Value = Convert.ToInt32(postid);
            SqlParameter param2 = new SqlParameter("@cmt", SqlDbType.NVarChar);
            param2.Value = content;
            SqlParameter param3 = new SqlParameter("@date", SqlDbType.DateTime);
            param3.Value = d;
            int n = SqlDataAccess.ExecuteSQL(sql, param0, param1, param2,param3);
            return n;
        }
    }
}
