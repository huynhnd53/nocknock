using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NockNock.Models
{
    public class CommentModel
    {
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
