using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class FollowModel
    {
        public FollowModel(int followerID, int followedID, int notiID, DateTime followDate)
        {
            FollowerID = followerID;
            FollowedID = followedID;
            NotiID = notiID;
            FollowDate = followDate;
        }

        public FollowModel()
        {

        }

        public int FollowerID { get; set; }
        public int FollowedID { get; set; }
        public int NotiID { get; set; }
        public DateTime FollowDate { get; set; }

    }
}
