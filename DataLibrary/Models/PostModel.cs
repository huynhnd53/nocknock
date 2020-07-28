using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class PostModel
    {

        public PostModel()
        {

        }


        public PostModel(int postID, int profileID, string profileName, string profileImage, string postContent, DateTime postDate, int noOfLikes, int noOfCmts)
        {
            PostID = postID;
            ProfileID = profileID;
            ProfileName = profileName;
            ProfileImage = profileImage;
            PostContent = postContent;
            PostDate = postDate;
            NoOfLikes = noOfLikes;
            NoOfCmts = noOfCmts;
        }

        public int PostID { get; set; }
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileImage { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }
        public int NoOfLikes { get; set; }
        public int NoOfCmts { get; set; }

    }
}
