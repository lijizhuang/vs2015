using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmptyMvc.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前！...";
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            string email = formCollection["inputEmail3"];
            string password = formCollection["inputPassword3"];
            ViewBag.LoginState = email + "登录后...";
            return View();
        }
    }
}