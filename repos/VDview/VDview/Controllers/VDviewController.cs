using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VDview.Controllers
{
    public class VDviewController : Controller
    {
        // GET: VDview
        public ActionResult Detail => View();
        {
            return View();
         }
    [HttpPost]
        public ActionResult Detail
        {
            get
            {
                ViewBag.Id = "SV001";
                ViewBag.Name = "Nguyễn Anh Tuấn";
                ViewData.["Marks"] = 9.5;
                return View();
            }
        }
    }