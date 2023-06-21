using baitap410.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap410.Models;

namespace baitap410.Controllers
{
    public class Sinhvien61130137Controller : Controller
    {
        // GET: Sinhvien61130137
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail1(StudenInfo st)
        {
            ViewBag.Id = st.Id;
            ViewBag.Name = st.Name;
            ViewBag.Marks = st.Marks;
            return View();
        }
        public ActionResult Detail2(StudenInfo st)
        {
            ViewBag.Id = st.Id;
            ViewBag.Name = st.Name;
            ViewBag.Marks = st.Marks;
            return View();
        }
    }
}