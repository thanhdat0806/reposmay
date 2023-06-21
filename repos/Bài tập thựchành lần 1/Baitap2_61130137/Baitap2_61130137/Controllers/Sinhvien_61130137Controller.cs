using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baitap2_61130137.Models;

namespace Baitap2_61130137.Controllers
{
    public class Sinhvien61130137Controller : Controller
    {
        // GET: Sinhvien61130137
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail1(StudentInfo st)
        {
            ViewBag.Id = st.Id;
            ViewBag.Name = st.Name;
            ViewBag.Marks = st.Marks;
            return View();
        }
        public ActionResult Detail2(StudentInfo st)
        {
            ViewBag.Id = st.Id;
            ViewBag.Name = st.Name;
            ViewBag.Marks = st.Marks;
            return View();
        }
    }
}