using Sys.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sys.dal;

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

        public JsonResult Add_User(User u)
        {
            bool result = false;

            LoginInterface loginInit = new LoginInterface();
            result = loginInit.AddUser(u);

            return Json(result);
        }
    }

}