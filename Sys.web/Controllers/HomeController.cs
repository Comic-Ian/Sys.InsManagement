﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { return View(); }

        public ActionResult PageContent()
        { return View(); }

        public ActionResult LoginInterface()
        { return View(); }

        public ActionResult LoginView()
        { return View(); }
    }
}