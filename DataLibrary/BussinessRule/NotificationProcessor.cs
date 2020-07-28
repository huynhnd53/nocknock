using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessRule
{
    public static class NotificationProcessor
    {
        /// <summary>
        /// add a new noti
        /// </summary>
        /// <param name="username"></param>
        /// <param name="targetid"></param>
        /// <param name="postid"></param>
        /// <param name="type"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int addNoti(string username,string targetid,string postid,string type,DateTime d)
        {
            //insert noti like,comment
            string sql = @"declare  @profileid as int
set @profileid = (
select ProfileID
from Profile p join Account a on a.AccountID = p.ProfileID
where Username = @username
)
insert into Notification(SenderID,TargetID,PostID,TypeNoti,NotiDate)
values (@profileid,@target,@postid,@type,@date)";
            //insert noti follow
            //lười quá hic hic
            string sql2 = @"declare  @profileid as int
set @profileid = (
select ProfileID
from Profile p join Account a on a.AccountID = p.ProfileID
where Username = @username
)
insert into Notification(SenderID,TargetID,TypeNoti,NotiDate)
values (@profileid,@target,@type,@date)";
            SqlParameter param = new SqlParameter("@username", SqlDbType.VarChar);
            param.Value = username;
            SqlParameter param1 = new SqlParameter("@target", SqlDbType.Int);
            param1.Value = Convert.ToInt32(targetid);
            SqlParameter param3 = new SqlParameter("@postid", SqlDbType.Int);
            param3.Value = postid;
            SqlParameter param4 = new SqlParameter("@type", SqlDbType.NVarChar);
            param4.Value = type;
            SqlParameter param5 = new SqlParameter("@date", SqlDbType.DateTime);
            param5.Value = d;
            if (postid == null)
                return SqlDataAccess.ExecuteSQL(sql2, param, param1, param4, param5);
            else 
                return SqlDataAccess.ExecuteSQL(sql, param, param1, param3, param4,param5);
        }

        /// <summary>
        /// delete a noti reaction after an action is undo
        /// </summary>
        /// <param name="postid"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public static int deleteNotiReaction(string postid,string username)
        {
            string sql = @"declare @profileid as int
set @profileid = (
select ProfileID
from Profile p join Account a on p.AccountID = a.AccountID
where username = @username
)
delete from Notification
where TypeNoti = 'Like' and SenderID = @profileid and PostID = @postid";
            SqlParameter param = new SqlParameter("@username", SqlDbType.VarChar);
            param.Value = username;
            SqlParameter param3 = new SqlParameter("@postid", SqlDbType.Int);
            param3.Value = postid;
            return SqlDataAccess.ExecuteSQL(sql, param, param3);
        }
        /// <summary>
        /// delete noti follow when click unfollow
        /// </summary>
        /// <param name="meid"></param>
        /// <param name="youid"></param>
        /// <returns></returns>
        public static int deleteNotiFollow(int meid, int youid)
        {
            string sql = @"delete from Notification
where senderid = @me and targetid =@you and TypeNoti = 'Follow'";
            SqlParameter param = new SqlParameter("@me", SqlDbType.Int);
            param.Value = meid;
            SqlParameter param3 = new SqlParameter("@you", SqlDbType.Int);
            param3.Value = youid;
            return SqlDataAccess.ExecuteSQL(sql, param, param3);
        }

        /// <summary>
        /// get notification board
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static DataTable getNotiBoard(string username)
        {
            string sql = @"declare @profileid as int
set @profileid = (
select ProfileID
from Profile p join Account a on p.AccountID = a.AccountID
where username = @username
)
select n.*, p.ProfileName as SenderName, p.ProfilePhoto as SenderPhoto
from Notification n join Profile p on p.ProfileID = n.SenderID
where TargetID = @profileid and SenderID != @profileid
order by NotiDate desc";
            SqlParameter param = new SqlParameter("@username", SqlDbType.VarChar);
            param.Value = username;
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param);
            List<NotificationModel> list = new List<NotificationModel>();
            return dt;
        }
    }
}
