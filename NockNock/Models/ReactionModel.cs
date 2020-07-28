using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NockNock.Models
{
    public class ReactionModel
    {
        public int TypeID { get; set; }
        public int PostID { get; set; }
        public int ProfileID { get; set; }
        public int NotiID { get; set; }
        public DateTime ReactionDate { get; set; }
    }
}
