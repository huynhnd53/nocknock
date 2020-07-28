using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.BussinessRule
{
   public class ProfileProcess
    {
        public static List<ProfileModel> SearchProfileByKey(string key)
        {
            string sql =
                @"with p1 as (select count(FollowedID) as Following, FollowerID
                    from Follow
                    group by FollowerID),

                    p2 as(select count(FollowerID) as Follower, FollowedID
                    from Follow 
                    group by FollowedID)

                    select p.*, p2.Follower, p1.Following
                    from Profile p join p1 on p.ProfileID = p1.FollowerID
                    join p2 on p.ProfileID = p2.FollowedID
                    where ProfileName like '%"+key+"%'";
            return SqlDataAccess.LoadData<ProfileModel>(sql);
        }

        public static List<ProfileModel> SearchTop3ByKey(string key)
        {
            string sql =
                @"SELECT       TOP 3  ProfileID, AccountID, ProfileName, Bio, Email, Phone, Gender, DateOfBirth, ProfilePhoto
                FROM            Profile
                WHERE        (ProfileName LIKE N'%" + key + "%')";
            return SqlDataAccess.LoadData<ProfileModel>(sql);
        }
    }
}
