using System;
using System.Collections.Generic;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DataLibrary.BusinessRule.ProfileProcessor;
using static DataLibrary.BusinessRule.AccountProcessor;
using static DataLibrary.BusinessRule.PostProcessor;
using static DataLibrary.BusinessRule.FollowProcessor;
using static DataLibrary.BusinessRule.NotificationProcessor;
using PostModel = NockNock.Models.PostModel;

namespace NockNock.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index(int? id)
        {
            return RedirectToAction("ViewProfile");
            //if (id == null)
            //{
            //    return ViewProfile(HttpContext.Session.GetObjectFromJson<ProfileModel>("profile").ProfileID.ToString());
            //}
            //if (id == HttpContext.Session.GetObjectFromJson<ProfileModel>("profile").ProfileID)
            //    return ViewProfile(id.ToString());
            //ProfileModel profile = GetProfileById(id);
            //if (profile == null)
            //    return NotFound();
            //ViewData["ViewProfile"] = profile;
            //return ViewProfile(id.ToString());
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditInfo(string profileName, string bio, string phone, string email, DateTime dateOfBirth, string gender)
        {
            ProfileModel thisProfile = HttpContext.Session.GetObjectFromJson<ProfileModel>("profile");
            thisProfile.ProfileName = profileName;
            thisProfile.Bio = bio;
            thisProfile.Phone = phone;
            thisProfile.Email = email;
            thisProfile.DateOfBirth = dateOfBirth;
            gender = gender.ToLower().Trim();
            if (gender.Equals("male"))
                thisProfile.Gender = true;
            else if (gender.Equals("female"))
                thisProfile.Gender = false;
            else
                thisProfile.Gender = null;
            if (UpdateProfile(thisProfile) == 1)
            {
                HttpContext.Session.Remove("profile");
                HttpContext.Session.SetObjectAsJson("profile", thisProfile);
            }
            return View("Edit");
        }

        [HttpPost]
        public IActionResult EditPassword(IFormCollection form)
        {
            string oldPassword = form["OldPassword"].ToString();
            string newPassword = form["NewPassword"].ToString();
            string reNewPassword = form["ReNewPassword"].ToString();
            bool a = IsValidLogin(HttpContext.Session.GetString("username"), oldPassword);
            if (!reNewPassword.Equals(newPassword))
            {
                ViewData["PasswordError"] = "\"Re-New Password\" field must match \"New Password\" field";
            }
            else if (!IsValidLogin(HttpContext.Session.GetString("username"), oldPassword))
            {
                ViewData["PasswordError"] = "Wrong password";
            }
            else
            {
                if ((UpdateAccount(HttpContext.Session.GetString("username"), newPassword) == 1))
                    ViewData["PasswordSuccess"] = "Change password success";
                else
                {
                    ViewData["PasswordError"] = "Change password fail";
                }
            }
            return View("Edit");
        }

        /// <summary>
        /// View Profile (mới display info, list post thôi nhé :v)
        /// </summary>
        /// <param name="profileid"></param>
        /// <returns></returns>
        public ActionResult ViewProfile(string profileid)
        {
            string myid = HttpContext.Session.GetString("profileid");
            if (profileid == null)
            {
                profileid = myid;
            }
            //get list post by a profileid
            var data = ListPostByProfileID(profileid);
            List<PostModel> postList = new List<PostModel>();
            foreach (var row in data)
            {
                postList.Add(new PostModel
                {
                    PostID = row.PostID,
                    ProfileID = row.ProfileID,
                    PostContent = row.PostContent,
                    PostDate = row.PostDate,
                    NoOfCmts = row.NoOfCmts,
                    NoOfLikes = row.NoOfLikes,
                    ProfileName = row.ProfileName,
                    ProfileImage = row.ProfileImage
                });

            }
            //get profile by a profileid
            var profile = getProfilebyProfileID(profileid) as DataLibrary.Models.ProfileModel;
            ProfileModel p = new ProfileModel
            {
                ProfileID = profile.ProfileID,
                ProfileName = profile.ProfileName,
                ProfilePhoto = profile.ProfilePhoto,
                NoOfPosts = profile.NoOfPosts,
                AccountID = profile.AccountID,
                Bio = profile.Bio,
                DateOfBirth = profile.DateOfBirth,
                Email = profile.Email,
                Follower = profile.Follower,
                Following = profile.Following,
                Gender = profile.Gender,
                Phone = profile.Phone

            };
            List<ProfileModel> followerList = getListMyFollower(Convert.ToInt32(profileid));
            List<ProfileModel> followingList = getListMyFollowing(Convert.ToInt32(profileid));
            ViewBag.followerlist = followerList;
            ViewBag.followinglist = followingList;
            ViewBag.profile = p;
            return View(postList);
        }
        /// <summary>
        /// add new post
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult NewPost()
        {
            //request content status
            string content = HttpContext.Request.Form["status"];
            string profileid = HttpContext.Session.GetString("profileid");
            //create a new post
            int n = createNewPost(profileid, content, DateTime.Now);
            //success
            if (n != 0)
            {
                //increase noOfPosts session +1
                int numOfPosts = Convert.ToInt32(HttpContext.Session.GetString("noOfPosts"));
                HttpContext.Session.SetString("noOfPosts", (numOfPosts + 1).ToString());
                return RedirectToAction("ViewProfile", "Profile");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public ActionResult Follow(string id)
        {
            DateTime d = DateTime.Now;
            string username = HttpContext.Session.GetString("username");
            int pid = Convert.ToInt32(HttpContext.Session.GetString("profileid"));
            bool isFollow = isFollowing(pid, Convert.ToInt32(id));
            //if follow
            if (isFollow)
            {
                //do unfollow
                int n1 = DoUnFollow(pid, Convert.ToInt32(id));
                //delete noti unfollow
                int n2 = deleteNotiFollow(pid, Convert.ToInt32(id));
                //if success
                if (n1 != 0 && n2 != 0)
                {
                    //decrease following session +1
                    int following = Convert.ToInt32(HttpContext.Session.GetString("following"));
                    HttpContext.Session.SetString("following", (following - 1).ToString());
                    return RedirectToAction("ViewProfile", "Profile", new { profileid = id });
                }
                else
                    return NotFound();
                //if has not follow
            }
            else
            {
                //add noti follow
                int n1 = addNoti(username, id, null, "Follow", d);
                //do follow
                int n2 = DoFollow(pid, Convert.ToInt32(id));
                //success
                if (n1 != 0 && n2 != 0)
                {
                    //increase following session +1
                    int following = Convert.ToInt32(HttpContext.Session.GetString("following"));
                    HttpContext.Session.SetString("following", (following + 1).ToString());
                    return RedirectToAction("ViewProfile", "Profile", new { profileid = id });
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
