using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NockNock.Models
{
    public class NotificationModel
    {
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
