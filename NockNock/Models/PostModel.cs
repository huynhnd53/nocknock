using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NockNock.Models
{
    public class PostModel
    {
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
