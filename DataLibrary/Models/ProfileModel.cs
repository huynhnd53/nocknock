using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class ProfileModel
    {
        public int ProfileID { get; set; }
        public int AccountID { get; set; }
        public string ProfileName { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfilePhoto { get; set; }
        public int Follower { get; set; }
        public int Following { get; set; }
        public int NoOfPosts { get; set; }

    }
}
