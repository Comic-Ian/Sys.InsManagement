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
        //保单界面
        public ActionResult Index()
        { return View(); }

        //业务查询界面
        public ActionResult PageContent()
        { return View(); }

        //用户登录界面
        public ActionResult LoginInterface()
        { return View(); }

        //用户登录
        public JsonResult Validation_User(User u)
        {
            bool result = false;

            LoginInterface loginInit = new LoginInterface();

            return Json(result);
        }

        //用户注册界面
        public ActionResult LoginView()
        { return View(); }

        //用户注册功能
        public JsonResult Add_User(User u)
        {
            bool result = false;

            LoginInterface loginInit = new LoginInterface();
            result = loginInit.AddUser(u);

            return Json(result);
        }
    }

}