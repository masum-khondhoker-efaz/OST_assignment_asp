using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using OST_Assignment_02.Models;

namespace OST_Assignment_02.Controllers
{
    public class AuthController : Controller
    {
     
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account model)
        {
            if (model == null)
            {
                ViewBag.Message = "Invalid login attempt.";
                return View();
            }

            if (ModelState.IsValid)
            {
                if (model.username == "efaz" && model.password == "efaz")
                {
                    Session["Username"] = model.username;
                    TempData["Message"] = "Login Successful";
                    return RedirectToAction("Dashboard", "Auth");
                }
                else
                {
                    ViewBag.Message = "Incorrect Username or Password";
                }
            }
            else
            {
                ViewBag.Message = "Please provide valid data.";
            }

            return View(model);
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();

            
            return RedirectToAction("Login", "Auth");
        }


    }
}