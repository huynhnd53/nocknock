using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class NotificationModel
    {

        public NotificationModel()
        {

        }

        public NotificationModel(int notiID, int senderID, int targetID, int postID, string typeNoti, DateTime notiDate, string senderName, string senderPhoto)
        {
            NotiID = notiID;
            SenderID = senderID;
            TargetID = targetID;
            PostID = postID;
            TypeNoti = typeNoti;
            NotiDate = notiDate;
            SenderName = senderName;
            SenderPhoto = senderPhoto;
        }

        public int NotiID { get; set; }
        public int SenderID { get; set; }
        public int TargetID { get; set; }
        public int PostID { get; set; }
        public string TypeNoti { get; set; }
        public DateTime NotiDate { get; set; }
        public string SenderName { get; set; }
        public string SenderPhoto { get; set; }

    }
}
