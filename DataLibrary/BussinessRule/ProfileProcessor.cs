using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Text;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessRule
{
    public static class ProfileProcessor
    {
        public static int CreateProfile(int accountId, string profileName)
        {
            ProfileModel data = new ProfileModel
            {
                AccountID = accountId,
                ProfileName = profileName,
                DateOfBirth = DateTime.Today
            };
            string sql = @"INSERT INTO dbo.Profile VALUES(@AccountID, @ProfileName, @Bio, @Email, @Phone, @Gender, @DateOfBirth, @ProfilePhoto)";
            return SqlDataAccess.InsertData(sql, data);
        }

        public static int UpdateProfile(ProfileModel data)
        {
            string sql =
                @"UPDATE dbo.Profile SET [ProfileName] = @ProfileName, [Bio] = @Bio, [Email] = @Email, [Phone] = @Phone, [Gender] = @Gender, [DateOfBirth] = @DateOfBirth, [ProfilePhoto] = @ProfilePhoto WHERE [ProfileID] = @ProfileID or [AccountID] = @AccountID";
            return SqlDataAccess.InsertData(sql, data);
        }

        public static ProfileModel GetProfileByUsername(string username)
        {
            string sql =
                "SELECT * FROM dbo.Profile p, dbo.Account a WHERE p.AccountID = a.AccountID and a.Username = '" + username + "'";
            List<ProfileModel> profile = SqlDataAccess.LoadData<ProfileModel>(sql);
            if (profile != null && profile.Count == 1)
                return profile[0];
            return null;
        }

        public static ProfileModel GetProfileById(int? id)
        {
            if (id == null)
                return null;
            string sql = "SELECT * FROM dbo.Profile WHERE ProfileID = '" + id + "'";
            List<ProfileModel> profile = SqlDataAccess.LoadData<ProfileModel>(sql);
            if (profile != null && profile.Count == 1)
                return profile[0];
            return null;
        }
        /// <summary>
        /// get profile by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static ProfileModel getProfilebyUsername(string username)
        {
            string sql = @"declare @profileid as int
set @profileid = (
select pro.ProfileID
from Profile pro join Account a on pro.AccountID = a.AccountID
where Username = @username
);
with t as (
select count(FollowedID) as MyFollowing
from Follow
where FollowerID = @profileid

),
t2 as (
select count(FollowedID) as MyFollower
from Follow 
where FollowedID = @profileid

),
t3 as (
select count(postid) as NoOfPosts
from Post
where ProfileID = @profileid

)
select p.*, t.MyFollowing, t2.MyFollower, NoOfPosts
from Profile p,t,t2,t3
where p.ProfileID=@profileid";
            SqlParameter param = new SqlParameter("@username", SqlDbType.NVarChar);
            param.Value = username;
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param);
            ProfileModel data = new ProfileModel();
            foreach (DataRow dr in dt.Rows)
            {

                data.AccountID = Convert.ToInt32(dr["AccountID"]);
                data.Bio = dr["Bio"].ToString();
                data.ProfileID = Convert.ToInt32(dr["ProfileID"]);
                data.ProfileName = dr["ProfileName"].ToString();
                data.ProfilePhoto = dr["ProfilePhoto"].ToString();
                data.Gender = Convert.ToBoolean(dr["Gender"]);
                data.Email = dr["Email"].ToString();
                data.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                data.Follower = Convert.ToInt32(dr["MyFollower"]);
                data.Following = Convert.ToInt32(dr["MyFollowing"]);
                data.NoOfPosts = Convert.ToInt32(dr["NoOfPosts"]);

            }
            return data;

        }
        /// <summary>
        /// get profile by profileid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ProfileModel getProfilebyProfileID(string id)
        {
            string sql = @"declare @profileid as int
set @profileid = @id;
with t as (
select count(FollowedID) as MyFollowing
from Follow
where FollowerID = @profileid

),
t2 as (
select count(FollowedID) as MyFollower
from Follow 
where FollowedID = @profileid

),
t3 as (
select count(postid) as NoOfPosts
from Post
where ProfileID = @profileid

)
select p.*, t.MyFollowing, t2.MyFollower, NoOfPosts
from Profile p,t,t2,t3
where p.ProfileID=@profileid";
            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = Convert.ToInt32(id);
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param);
            ProfileModel data = new ProfileModel();
            foreach (DataRow dr in dt.Rows)
            {
                data.AccountID = Convert.ToInt32(dr["AccountID"]);
                data.Bio = dr["Bio"].ToString();
                data.ProfileName = dr["ProfileName"].ToString();
                data.ProfilePhoto = dr["ProfilePhoto"].ToString();
                data.Gender = Convert.ToBoolean(dr["Gender"]);
                data.Email = dr["Email"].ToString();
                data.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                data.AccountID = Convert.ToInt32(dr["AccountID"]);
                data.ProfileID = Convert.ToInt32(id);
                data.Follower = Convert.ToInt32(dr["MyFollower"]);
                data.Following = Convert.ToInt32(dr["MyFollowing"]);
                data.NoOfPosts = Convert.ToInt32(dr["NoOfPosts"]);
                data.Phone = dr["Phone"].ToString();

            }
            return data;

        }

        public static List<ProfileModel> getListMyFollower(int profileid)
        {
            string sql = @"with p as(select p.*
from Profile p join Follow f on p.ProfileID = f.FollowerID 
where f.FollowedID = @profileid),
p1 as (
select count(FollowerID) as MyFollower, FollowedID
from Follow 
group by FollowedID
) 
select p.*, p1.MyFollower
from p join p1 on p.ProfileID = p1.FollowedID";
            SqlParameter param = new SqlParameter("@profileid", SqlDbType.Int);
            param.Value = profileid;
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param);
            List<ProfileModel> list = new List<ProfileModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ProfileModel p = new ProfileModel
                {
                    AccountID = Convert.ToInt32(dr["AccountID"]),
                    Bio = dr["Bio"].ToString(),
                    ProfileName = dr["ProfileName"].ToString(),
                    ProfilePhoto = dr["ProfilePhoto"].ToString(),
                    Gender = Convert.ToBoolean(dr["Gender"]),
                    Email = dr["Email"].ToString(),
                    DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]),
                    ProfileID = Convert.ToInt32(dr["ProfileID"]),
                    Follower = Convert.ToInt32(dr["MyFollower"]),
                    Phone = dr["Phone"].ToString()
                };
                list.Add(p);
            }
            return list;
        }

        public static List<ProfileModel> getListMyFollowing(int profileid)
        {
            string sql = @"with p as(select p.*
from Profile p join Follow f on p.ProfileID = f.FollowedID 
where f.FollowerID = @profileid),
p1 as (
select count(FollowerID) as MyFollower, FollowedID
from Follow 
group by FollowedID 
) 
select p.*, p1.MyFollower
from p join p1 on p.ProfileID = p1.FollowedID";
            SqlParameter param = new SqlParameter("@profileid", SqlDbType.Int);
            param.Value = profileid;
            DataTable dt = SqlDataAccess.GetDataBySQL(sql, param);
            List<ProfileModel> list = new List<ProfileModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ProfileModel p = new ProfileModel
                {
                    AccountID = Convert.ToInt32(dr["AccountID"]),
                    Bio = dr["Bio"].ToString(),
                    ProfileName = dr["ProfileName"].ToString(),
                    ProfilePhoto = dr["ProfilePhoto"].ToString(),
                    Gender = Convert.ToBoolean(dr["Gender"]),
                    Email = dr["Email"].ToString(),
                    DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]),
                    ProfileID = Convert.ToInt32(dr["ProfileID"]),
                    Follower = Convert.ToInt32(dr["MyFollower"]),
                    Phone = dr["Phone"].ToString()
                };
                list.Add(p);
            }
            return list;
        }

    }
}
