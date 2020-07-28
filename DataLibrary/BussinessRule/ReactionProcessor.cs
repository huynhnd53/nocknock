using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessRule
{
    public static class ReactionProcessor
    {
        /// <summary>
        /// check if like post or not
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postid"></param>
        /// <returns></returns>
        public static bool checkLike(string username, int postid)
        {
            string sql = @"select * from Reaction
where ProfileID = (
select ProfileID
from Profile p join Account a on p.AccountID = a.AccountID
where username = @username
) and PostID = @id and TypeID = 1";
            SqlParameter param = new SqlParameter("@username", SqlDbType.VarChar);
            param.Value = username;
            SqlParameter param1 = new SqlParameter("@id", SqlDbType.Int);
            param1.Value = Convert.ToInt32(postid);
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param, param1);
            return (dt.Rows.Count != 0);
        }

        /// <summary>
        /// unlike a post
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postid"></param>
        /// <returns></returns>
        public static int DoUnLike(string username,int postid)
        {
            string sql = @"declare @profileid as int
set @profileid = (
select ProfileID
from Profile p join Account a on p.AccountID = a.AccountID
where username = @username
)
declare @notiid as int
set @notiid = (
select NotiID
from Notification
where TypeNoti = 'Like' and PostID = @postid and SenderID = @profileid
)
delete from Reaction
where NotiID = @notiid";
            
            SqlParameter param = new SqlParameter("@postid", SqlDbType.Int);
            param.Value = Convert.ToInt32(postid);
            SqlParameter param1 = new SqlParameter("@username", SqlDbType.VarChar);
            param1.Value = username;
            int n = SqlDataAccess.ExecuteSQL(sql, param, param1);
            return n;
        }
        /// <summary>
        /// like a post
        /// </summary>
        /// <param name="postid"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public static int DoLike(int postid,string username)
        {
            string sql = @"declare @profileid as int
set @profileid = (
select ProfileID
from Profile pro join Account a on pro.AccountID = a.AccountID
where Username = @username
);
declare @notiid as int
set @notiid = (
select NotiID from Notification
where postid = @postid and SenderID = @profileid and TypeNoti = 'Like'
);
insert into Reaction
values (1,@postid,@profileid,@notiid)";
            SqlParameter param1 = new SqlParameter("@username", SqlDbType.VarChar);
            param1.Value = username;
            SqlParameter param2 = new SqlParameter("@postid", SqlDbType.Int);
            param2.Value = postid;
            return SqlDataAccess.ExecuteSQL(sql,param1,param2);
        }

    }
}
