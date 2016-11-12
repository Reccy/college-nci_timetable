using NCIOnlineTimetable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCIOnlineTimetable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Floor(int id)
        {
            if (id < 1)
                id = 1;
            else if (id > 3)
                id = 3;
            
            ViewBag.Floor = id;
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
    }
}