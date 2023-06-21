using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Thi_61130137.Models;

namespace Thi_61130137.Controllers
{
    public class TaiSans_61130137Controller : Controller
    {
        private Thi_61130137Entities db = new Thi_61130137Entities();

        // GET: TaiSans_61130137
        public ActionResult TimKiem_61130137()
        {
            var Thi_61130137 = db.TaiSans.Include(s => s.LoaiTaiSan);
            return View(Thi_61130137.ToList());

        }
        [HttpPost]
        public ActionResult TimKiem_61130137(string maTS, string tenTS)
        {
            var Thi_61130137 = db.TaiSans.Include(s => s.LoaiTaiSan).Where(ts => ts.MaTS == maTS);
            return View(Thi_61130137.ToList());
        }
        public ActionResult Index()
        {
            var taiSans = db.TaiSans.Include(t => t.LoaiTaiSan);
            return View(taiSans.ToList());
        }

        // GET: TaiSans_61130137/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiSan taiSan = db.TaiSans.Find(id);
            if (taiSan == null)
            {
                return HttpNotFound();
            }
            return View(taiSan);
        }

        // GET: TaiSans_61130137/Create
        public ActionResult Create()
        {
            ViewBag.MaLTS = new SelectList(db.LoaiTaiSans, "MaLTS", "TenLTS");
            return View();
        }

        // POST: TaiSans_61130137/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTS,TenTS,DVT,XuatXu,Dongia,AnhMH,Ghichu,MaLTS")] TaiSan taiSan)
        {
            if (ModelState.IsValid)
            {
                db.TaiSans.Add(taiSan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLTS = new SelectList(db.LoaiTaiSans, "MaLTS", "TenLTS", taiSan.MaLTS);
            return View(taiSan);
        }

        // GET: TaiSans_61130137/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiSan taiSan = db.TaiSans.Find(id);
            if (taiSan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLTS = new SelectList(db.LoaiTaiSans, "MaLTS", "TenLTS", taiSan.MaLTS);
            return View(taiSan);
        }

        // POST: TaiSans_61130137/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTS,TenTS,DVT,XuatXu,Dongia,AnhMH,Ghichu,MaLTS")] TaiSan taiSan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taiSan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLTS = new SelectList(db.LoaiTaiSans, "MaLTS", "TenLTS", taiSan.MaLTS);
            return View(taiSan);
        }

        // GET: TaiSans_61130137/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiSan taiSan = db.TaiSans.Find(id);
            if (taiSan == null)
            {
                return HttpNotFound();
            }
            return View(taiSan);
        }

        // POST: TaiSans_61130137/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TaiSan taiSan = db.TaiSans.Find(id);
            db.TaiSans.Remove(taiSan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
