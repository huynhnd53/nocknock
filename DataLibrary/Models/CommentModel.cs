using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class CommentModel
    {
        public CommentModel()
        {

        }

        public CommentModel(int commentID, int postID, int profileID, string commentContent, string profileName, string profilePhoto, int notiID)
        {
            CommentID = commentID;
            PostID = postID;
            ProfileID = profileID;
            CommentContent = commentContent;
            ProfileName = profileName;
            ProfilePhoto = profilePhoto;
            NotiID = notiID;
        }

        public int CommentID { get; set; }
        public int PostID { get; set; }
        public int ProfileID { get; set; }
        public string CommentContent { get; set; }
        public string ProfileName { get; set; }
        public string ProfilePhoto { get; set; }
        public int NotiID { get; set; }
        public DateTime CommentDate { get; set; }

    }
}
