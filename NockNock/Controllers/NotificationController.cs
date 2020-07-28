using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static DataLibrary.BusinessRule.NotificationProcessor;
using Microsoft.AspNetCore.Http;
using System.Data;
using NockNock.Models;

namespace NockNock.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        /// <summary>
        /// View Notification Board
        /// </summary>
        /// <returns></returns>
        public ActionResult NotiBoard()
        {
            //get notification board of a username
            DataTable dt = getNotiBoard(HttpContext.Session.GetString("username"));
            List<NotificationModel> list = new List<NotificationModel>();
            //cast sqlModel datatable to pj model list
            foreach (DataRow dr in dt.Rows)
            {
                NotificationModel n = new NotificationModel();
                n.NotiID = Convert.ToInt32(dr["NotiID"]);
                if (!dr["TypeNoti"].ToString().Equals("Follow"))
                {
                    n.PostID = Convert.ToInt32(dr["PostID"]);
                }
                n.SenderID = Convert.ToInt32(dr["SenderID"]);
                n.TargetID = Convert.ToInt32(dr["TargetID"]);
                n.TypeNoti = dr["TypeNoti"].ToString();
                n.SenderName = dr["SenderName"].ToString();
                n.SenderPhoto = dr["SenderPhoto"].ToString();
                n.NotiDate = Convert.ToDateTime(dr["NotiDate"]);
                list.Add(n);
            }
            return View(list);
        }
       
    }
}
