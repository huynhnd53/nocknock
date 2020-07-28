using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.BussinessRule;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using static DataLibrary.BussinessRule.PostProcess;
using PostModel = NockNock.Models.PostModel;

namespace Search.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Search all of Post by Key | Content
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IActionResult SearchPostByKey(string textSearch)
        {
            ViewData["textSearch"] = textSearch;
            var data = PostProcess.SearchPostByKey(textSearch);
            List<PostModel> listPost = new List<PostModel>();
            foreach (var item in data)
            {
                listPost.Add(new PostModel
                {
                    PostID = item.PostID,
                    ProfileID = item.ProfileID,
                    PostContent = item.PostContent,
                    PostDate = item.PostDate,
                    NoOfCmts = item.NoOfCmts,
                    NoOfLikes = item.NoOfLikes,
                    ProfileName = item.ProfileName,
                    ProfileImage = item.ProfileImage
                });
            }
            ViewData["ListPost"] = listPost;
            return View();
        }

        /// <summary>
        /// Search Top 3 Post by Key | Content of Post
        /// </summary>
        /// <param name="textSearch"></param>
        /// <returns></returns>
        public IActionResult SearchTop3PostByKey(string textSearch)
        {
            var data = PostProcess.SearchTop3PostByKey(textSearch);
            List<PostModel> listPost = new List<PostModel>();
            foreach (var item in data)
            {
                listPost.Add(new PostModel
                {
                    PostID = item.PostID,
                    ProfileID = item.ProfileID,
                    PostContent = item.PostContent,
                    PostDate = item.PostDate,
                    NoOfCmts = item.NoOfCmts,
                    NoOfLikes = item.NoOfLikes,
                    ProfileName = item.ProfileName,
                    ProfileImage = item.ProfileImage
                });
            }
            return View(listPost);
        }

        /// <summary>
        /// Search Top 3 Profile by Key | Content of Post
        /// </summary>
        /// <param name="textSearch"></param>
        /// <returns></returns>
        public IActionResult SearchTop3ProfileByKey(string textSearch)
        {
            var data = ProfileProcess.SearchProfileByKey(textSearch);
            List<ProfileModel> listProfile = new List<ProfileModel>();
            foreach (var item in data)
            {
                listProfile.Add(new ProfileModel
                {
                    ProfileID = item.ProfileID,
                    AccountID = item.AccountID,
                    ProfileName = item.ProfileName,
                    Bio = item.Bio,
                    Email = item.Email,
                    Phone = item.Phone,
                    Gender = item.Gender,
                    DateOfBirth = item.DateOfBirth,
                    ProfilePhoto = item.ProfilePhoto,
                    Follower = item.Follower,
                    Following = item.Following,
                    NoOfPosts = item.NoOfPosts
                });
            }
            return View(listProfile);
        }

        /// <summary>
        /// Search all Profile by textSearch
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IActionResult SearchProfileByKey(string textSearch)
        {
            ViewData["textSearch"] = textSearch;
            var data = ProfileProcess.SearchProfileByKey(textSearch);
            List<ProfileModel> listProfile = new List<ProfileModel>();
            foreach (var item in data)
            {
                listProfile.Add(new ProfileModel
                {
                    ProfileID = item.ProfileID,
                    AccountID = item.AccountID,
                    ProfileName = item.ProfileName,
                    Bio = item.Bio,
                    Email = item.Email,
                    Phone = item.Phone,
                    Gender = item.Gender,
                    DateOfBirth = item.DateOfBirth,
                    ProfilePhoto = item.ProfilePhoto,
                    Follower = item.Follower,
                    Following = item.Following,
                    NoOfPosts = item.NoOfPosts
                });
            }
            ViewData["ListProfile"] = listProfile;
            return View();
        }
        public IActionResult SearchByKey(string textSearch)
        {
            ViewData["textSearch"] = textSearch;
            var dataProfile = ProfileProcess.SearchProfileByKey(textSearch);
            List<ProfileModel> listProfile = new List<ProfileModel>();
            foreach (var item in dataProfile)
            {
                listProfile.Add(new ProfileModel
                {
                    ProfileID = item.ProfileID,
                    AccountID = item.AccountID,
                    ProfileName = item.ProfileName,
                    Bio = item.Bio,
                    Email = item.Email,
                    Phone = item.Phone,
                    Gender = item.Gender,
                    DateOfBirth = item.DateOfBirth,
                    ProfilePhoto = item.ProfilePhoto,
                    Follower = item.Follower,
                    Following = item.Following,
                    NoOfPosts = item.NoOfPosts
                });
            }
            ViewData["ListProfile"] = listProfile;

            var data = PostProcess.SearchPostByKey(textSearch);
            List<PostModel> listPost = new List<PostModel>();
            foreach (var item in data)
            {
                listPost.Add(new PostModel
                {
                    PostID = item.PostID,
                    ProfileID = item.ProfileID,
                    PostContent = item.PostContent,
                    PostDate = item.PostDate,
                    NoOfCmts = item.NoOfCmts,
                    NoOfLikes = item.NoOfLikes,
                    ProfileName = item.ProfileName,
                    ProfileImage = item.ProfileImage
                });
            }
            ViewData["ListPost"] = listPost;
            // truyen qua viewBag |  View Data
            return View();
        }

    }
}
