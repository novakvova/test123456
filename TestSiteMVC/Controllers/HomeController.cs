﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Branch = "Hello branch!";
            ViewBag.BranchMaste = "BranchMaste";
            ViewBag.BranchMaste = "My Hello";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            ViewBag.Message = "Test message";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Message = "Test message";

            return View();
        }
    }
}
