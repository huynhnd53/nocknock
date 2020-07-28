using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static DataLibrary.BusinessRule.AccountProcessor;
using static DataLibrary.BusinessRule.PostProcessor;
using static DataLibrary.BusinessRule.CommentProcessor;
using static DataLibrary.BusinessRule.ReactionProcessor;
using static DataLibrary.BusinessRule.NotificationProcessor;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using DataLibrary.DataAccess;
using DataLibrary.BusinessRule;
using System.Data;
using NockNock.Models;

namespace NockNock.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View("ViewHome");
        }
        /// <summary>
        /// View Home Page
        /// </summary>
        /// <returns></returns>
        public ActionResult ViewHome()
        {
            string username = HttpContext.Session.GetString("username");

            //lấy list các post của những người mình follow đưa newfeed
            var data = ListPostsMyFollowingByPage(username,1,10);
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
            return View(postList);
        }

        /// <summary>
        /// View Post Detail to reaction, leave comment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ViewDetail(string id)
        {
            string username = HttpContext.Session.GetString("username");
            //lấy thông tin post khi biết postid
            DataTable dt = getPostbyID(id);
            var data = new PostModel();
            foreach (DataRow dr in dt.Rows)
            {
                data.PostID = Convert.ToInt32(dr["PostID"]);
                data.ProfileID = Convert.ToInt32(dr["ProfileID"]);
                data.PostContent = dr["PostContent"].ToString();
                data.PostDate = Convert.ToDateTime(dr["PostDate"]);
                data.NoOfLikes = Convert.ToInt32(dr["NoOfLikes"]);
                data.NoOfCmts = Convert.ToInt32(dr["NoOfCmts"]);
                data.ProfileImage = dr["ProfilePhoto"].ToString();
                data.ProfileName = dr["ProfileName"].ToString();
            }
            ViewBag.detail = data;
            //lấy cmt của post
            DataTable dt2 = getAllCommenybyPostID(id);
            List<CommentModel> cmtList = new List<CommentModel>();
            foreach (DataRow dr in dt2.Rows)
            {
                CommentModel cmt = new CommentModel
                {
                    CommentID = Convert.ToInt32(dr["CommentID"]),
                    PostID = Convert.ToInt32(dr["PostID"]),
                    CommentContent = dr["CommentContent"].ToString(),
                    ProfileID = Convert.ToInt32(dr["ProfileID"]),
                    CommentDate = Convert.ToDateTime(dr["DateComment"]),
                    ProfileName = dr["ProfileName"].ToString(),
                    ProfilePhoto = dr["ProfilePhoto"].ToString(),
                    NotiID = Convert.ToInt32(dr["NotiID"])
                };
                cmtList.Add(cmt);
            }
            ViewBag.cmtList = cmtList;
            //ViewBag.sessionu = username;
            return View();
        }
        /// <summary>
        /// Reaction (Like)
        /// </summary>
        /// <param name="postid"></param>
        /// <param name="targetid"></param>
        /// <returns></returns>
        public ActionResult React(string postid, string targetid)
        {
            if (postid != null)
            {
                string username = HttpContext.Session.GetString("username");
                //check if one liked the post
                bool check = checkLike(username, Convert.ToInt32(postid));
                //if liked
                if (check)
                {
                    //unlike
                    int n = DoUnLike(username, Convert.ToInt32(postid));
                    //delete noti like
                    int n2 = deleteNotiReaction(postid, username);
                    //success
                    if (n != 0 && n2 != 0)
                    {
                        //redirect
                        return RedirectToAction("ViewDetail", "Home", new { id = postid });
                        //sql ko thành công
                    }
                    else
                    {
                        return ViewHome();
                    }
                    //nếu chưa like
                }
                else
                {
                    DateTime d = DateTime.Now;
                    //add noti like
                    int n1 = addNoti(username, targetid, postid, "Like", d);
                    //like
                    int n2 = DoLike(Convert.ToInt32(postid), username);
                    //success
                    if (n1 != 0 && n2 != 0)
                    {
                        //redirect
                        return RedirectToAction("ViewDetail", "Home", new { id = postid });
                    }
                    else
                    {
                        return ViewHome();
                    }
                }
            }
            // TODO: somethign
            return NotFound();

        }
        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            //remove session username
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login", "Login");
        }

        /// <summary>
        /// Add new post
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult NewPost()
        {
            //request content
            string content = HttpContext.Request.Form["status"];
            //get profileid through session
            string profileid = HttpContext.Session.GetString("profileid");
            //add new post
            int n = createNewPost(profileid, content, DateTime.Now);
            //if add successfully
            if (n != 0)
            {
                int numOfPosts = Convert.ToInt32(HttpContext.Session.GetString("noOfPosts"));
                //increase numofposts session +!
                HttpContext.Session.SetString("noOfPosts", (numOfPosts + 1).ToString());
                return RedirectToAction("ViewHome", "Home");
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// add comment
        /// </summary>
        /// <param name="postid"></param>
        /// <param name="targetid"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Comment(string postid, string targetid)
        {
            DateTime d = DateTime.Now;
            string username = HttpContext.Session.GetString("username");
            //add noti comment
            int n1 = addNoti(username, targetid, postid, "Comment", d);
            //add comment
            int n2 = addComment(postid, username, HttpContext.Request.Form["newcmt"], d);
            //success
            if (n2 != 0 && n1 != 0)
            {
                return RedirectToAction("ViewDetail", "Home", new { id = postid });
            }
            else
            {
                return RedirectToAction("ViewHome", "Home");
            }
        }

        public JsonResult LoadPostAtEndOfPage(int start, int end)
        {
            string username = HttpContext.Session.GetString("username");
            var postList = ListPostsMyFollowingByPage(username, start, end);
            return Json(postList);
        }

        public JsonResult CheckLike(string username, int postId)
        {
            return Json(checkLike(username, postId));
        }
    }
}
