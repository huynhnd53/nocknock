using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NockNock.Models
{
    public class FollowModel
    {
        public int FollowerID { get; set; }
        public int FollowedID { get; set; }
        public int NotiID { get; set; }
        public DateTime FollowDate { get; set; }
    }
}
