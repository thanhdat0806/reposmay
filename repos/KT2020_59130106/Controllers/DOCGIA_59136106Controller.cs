using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KT2020_59130106.Models;

namespace KT2020_59130106.Controllers
{
    public class DOCGIA_59136106Controller : Controller
    {
        private KT20020_59136106Entities db = new KT20020_59136106Entities();

        // GET: DOCGIA_59136106
        public ActionResult Index()
        {
            var dOCGIAs = db.DOCGIAs.Include(d => d.LOAIDG);
            return View(dOCGIAs.ToList());
        }

        // GET: DOCGIA_59136106/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCGIA dOCGIA = db.DOCGIAs.Find(id);
            if (dOCGIA == null)
            {
                return HttpNotFound();
            }
            return View(dOCGIA);
        }

        // GET: DOCGIA_59136106/Create
        public ActionResult Create()
        {
            ViewBag.MaLDG = new SelectList(db.LOAIDGs, "MaLDG", "TenLDG");
            return View();
        }

        // POST: DOCGIA_59136106/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDG,HoDG,TenDG,NgaySinh,GioiTinh,Email,Anh,MaLDG")] DOCGIA dOCGIA)
        {
            if (ModelState.IsValid)
            {
                db.DOCGIAs.Add(dOCGIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLDG = new SelectList(db.LOAIDGs, "MaLDG", "TenLDG", dOCGIA.MaLDG);
            return View(dOCGIA);
        }

        // GET: DOCGIA_59136106/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCGIA dOCGIA = db.DOCGIAs.Find(id);
            if (dOCGIA == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLDG = new SelectList(db.LOAIDGs, "MaLDG", "TenLDG", dOCGIA.MaLDG);
            return View(dOCGIA);
        }

        // POST: DOCGIA_59136106/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDG,HoDG,TenDG,NgaySinh,GioiTinh,Email,Anh,MaLDG")] DOCGIA dOCGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dOCGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLDG = new SelectList(db.LOAIDGs, "MaLDG", "TenLDG", dOCGIA.MaLDG);
            return View(dOCGIA);
        }

        // GET: DOCGIA_59136106/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCGIA dOCGIA = db.DOCGIAs.Find(id);
            if (dOCGIA == null)
            {
                return HttpNotFound();
            }
            return View(dOCGIA);
        }

        // POST: DOCGIA_59136106/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DOCGIA dOCGIA = db.DOCGIAs.Find(id);
            db.DOCGIAs.Remove(dOCGIA);
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
