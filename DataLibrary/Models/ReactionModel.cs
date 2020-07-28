using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class ReactionModel
    {
        public ReactionModel()
        {

        }

        public ReactionModel(int typeID, int postID, int profileID, int notiID)
        {
            TypeID = typeID;
            PostID = postID;
            ProfileID = profileID;
            NotiID = notiID;
        }

        public int TypeID { get; set; }
        public int PostID { get; set; }
        public int ProfileID { get; set; }
        public int NotiID { get; set; }
        public DateTime ReactionDate { get; set; }

    }
}
