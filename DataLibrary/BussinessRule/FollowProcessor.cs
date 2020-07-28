using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessRule
{
    public static class FollowProcessor
    {
        /// <summary>
        /// check if uI follow an acount
        /// </summary>
        /// <param name="meid"></param>
        /// <param name="youid"></param>
        /// <returns></returns>
        public static bool isFollowing(int meid,int youid)
        {
            string sql = @"select * from Follow
where FollowerID = @me and FollowedID = @you";
            SqlParameter param = new SqlParameter("@me", SqlDbType.Int);
            param.Value = meid;
            SqlParameter param1 = new SqlParameter("@you", SqlDbType.Int);
            param1.Value = youid;
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param, param1);
            return (dt.Rows.Count != 0);
        }

        /// <summary>
        /// click follow
        /// </summary>
        /// <param name="meid"></param>
        /// <param name="youid"></param>
        /// <returns></returns>
        public static int DoFollow(int meid, int youid)
        {
            string sql = @"declare @notiid as int
set @notiid = (
select NotiID
from Notification
where SenderID = @me and TargetID = @you and TypeNoti = 'Follow'
);
insert into Follow
values (@me,@you,@notiid)";
            SqlParameter param = new SqlParameter("@me", SqlDbType.Int);
            param.Value = Convert.ToInt32(meid);
            SqlParameter param1 = new SqlParameter("@you", SqlDbType.Int);
            param1.Value = Convert.ToInt32(youid);
            return SqlDataAccess.ExecuteSQL(sql, param, param1);
        }

        /// <summary>
        /// click unfollow
        /// </summary>
        /// <param name="meid"></param>
        /// <param name="youid"></param>
        /// <returns></returns>
        public static int DoUnFollow(int meid,int youid)
        {
            string sql = @"delete from Follow
where FollowerID = @me and FollowedID = @you";
            SqlParameter param = new SqlParameter("@me", SqlDbType.Int);
            param.Value = meid;
            SqlParameter param1 = new SqlParameter("@you", SqlDbType.Int);
            param1.Value = youid;
            return SqlDataAccess.ExecuteSQL(sql, param, param1);
        }
    }
}
