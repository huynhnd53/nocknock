using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NockNock.Models;
using static DataLibrary.BusinessRule.AccountProcessor;
using static DataLibrary.BusinessRule.ProfileProcessor;

namespace NockNock.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            // If user had already login.
            if (HttpContext.Session.GetString("username") != null)
            {
                return RedirectToAction("Edit", "Profile");
            }
            return View("Login");
        }

        public IActionResult Login(LoginModel model)
        {
            // If user had already login.
            if (HttpContext.Session.GetString("username") != null)
            {
                return RedirectToAction("ViewHome", "Home");
            }
            // If ModelState is invalid, return to Login.cshtml.
            if (!ModelState.IsValid)
            {
                return View();
            }
            // If login information is valid, login.
            if (IsValidLogin(model.Username, model.Password))
            {
                // Add username to Session.
                HttpContext.Session.SetString("username", model.Username);
                // Add profile to Session.
                DataLibrary.Models.ProfileModel thisProfile = GetProfileByUsername(model.Username);
                thisProfile = getProfilebyUsername(model.Username);
                HttpContext.Session.SetObjectAsJson("profile", thisProfile);
                HttpContext.Session.SetString("noOfPosts", thisProfile.NoOfPosts.ToString());
                HttpContext.Session.SetString("follower", thisProfile.Follower.ToString());
                HttpContext.Session.SetString("following", thisProfile.Following.ToString());
                HttpContext.Session.SetString("profileid", thisProfile.ProfileID.ToString());
                ViewBag.sessionu = model.Username;
                // TODO: redirect to home page.
                return RedirectToAction("ViewHome", "Home");
            }
            else
            {
                ViewData["LoginError"] = "Wrong username or password";
                return View();
            }
        }

        public IActionResult Register()
        {
            // If user had already login.
            if (HttpContext.Session.GetString("username") != null)
            {
                return RedirectToAction("Edit", "Profile");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            // If user had already login.
            if (HttpContext.Session.GetString("username") != null)
            {
                return RedirectToAction("Edit", "Profile");
            }
            // If ModelState is invalid, return to Register.cshtml.
            if (!ModelState.IsValid)
                return View();
            // TODO: Add new account to database and redirect to other page.
            if (IsExistedUsername(model.Username))
            {
                ViewData["RegisterError"] = "Duplicated Username";
                return View();
            }
            // If Account should have been created successfully.
            if (CreateAccount(model.Username, model.Password) == 1)
            {
                // Add username to Session.
                HttpContext.Session.SetString("username", model.Username);
                // Create new corresponding profile.
                CreateProfile(GetAccountIdByUsername(model.Username), model.Username);
                // Add profile to Session.
                ProfileModel thisProfile = GetProfileByUsername(model.Username);
                HttpContext.Session.SetObjectAsJson("profile", thisProfile);
                // TODO: Redirect to profile page.
                return RedirectToAction("Edit", "Profile");
            }
            else
            {
                ViewData["RegisterError"] = "Something went wrong, please try again";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("profile");
            return RedirectToAction("Index");
        }
    }
}
