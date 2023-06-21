using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class btvdController : Controller
    {
        // GET: btvd
        public ActionResult Detail()
        {
            ViewBag.Id = "SV001";
            ViewBag.Name = "Nguyễn Anh Tuấn";
            ViewData["Marks"] = 9.5;
            return View();
        }
    }
}