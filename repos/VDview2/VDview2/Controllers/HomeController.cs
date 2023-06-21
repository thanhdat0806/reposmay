using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VDview2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            {
                ViewBag.Id = "SV001";
                ViewBag.Name = "Nguyễn Anh Tuấn";
                ViewData.["Marks"] = 9.5;
                return View();
            }
        }
    }
}