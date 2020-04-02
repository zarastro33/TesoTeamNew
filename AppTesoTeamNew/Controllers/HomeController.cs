using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppTesoTeamNew.Utilities;

namespace AppTesoTeamNew.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Tesitmonio()
        {

            return View();
        }
        [HttpPost]
        public bool EnviarEmail(string email)
        {
            bool nueo;
            return  nueo = new Email().SendEmail("zarastro.33@hotmail.com", "esto es una porquería", "Email nuevo");
        }
    }
}