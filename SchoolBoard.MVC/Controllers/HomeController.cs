﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolBoard.MVC.Controllers
{
    public class HomeController : ApplicationBaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}