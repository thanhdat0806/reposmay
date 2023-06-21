using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KT100720_59131885.Models;

namespace KT100720_59131885.Controllers
{
    public class TaiSan_59131885Controller : Controller
    {
        private KT100720_59131885Entities db = new KT100720_59131885Entities();

        // GET: TaiSan_59131885
        public ActionResult Index()
        {
            var taiSan = db.TaiSan.Include(t => t.LoaiTaiSan);
            return View(taiSan.ToList());
        }

        // GET: TaiSan_59131885/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiSan taiSan = db.TaiSan.Find(id);
            if (taiSan == null)
            {
                return HttpNotFound();
            }
            return View(taiSan);
        }

        // GET: TaiSan_59131885/Create
        public ActionResult Create()
        {
            ViewBag.MaLTS = new SelectList(db.LoaiTaiSan, "MaLTS", "TenLTS");
            return View();
        }

        // POST: TaiSan_59131885/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTS,TenTS,DVT,XuatXu,DonGia,AnhMH,MaLTS,GhiChu")] TaiSan taiSan)
        {
            //System.Web.HttpPostedFileBase Avatar;
            var imgNV = Request.Files["Avatar"];
            //Lấy thông tin từ input type=file có tên Avatar
            string postedFileName = System.IO.Path.GetFileName(imgNV.FileName);
            //Lưu hình đại diện về Server
            var path = Server.MapPath("/Images/" + postedFileName);
            imgNV.SaveAs(path);
            if (ModelState.IsValid)
            {
                taiSan.AnhMH = postedFileName;
                db.TaiSan.Add(taiSan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLTS = new SelectList(db.LoaiTaiSan, "MaLTS", "TenLTS", taiSan.MaLTS);
            return View(taiSan);
        }

        // GET: TaiSan_59131885/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiSan taiSan = db.TaiSan.Find(id);
            if (taiSan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLTS = new SelectList(db.LoaiTaiSan, "MaLTS", "TenLTS", taiSan.MaLTS);
            return View(taiSan);
        }

        // POST: TaiSan_59131885/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTS,TenTS,DVT,XuatXu,DonGia,AnhMH,MaLTS,GhiChu")] TaiSan taiSan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taiSan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLTS = new SelectList(db.LoaiTaiSan, "MaLTS", "TenLTS", taiSan.MaLTS);
            return View(taiSan);
        }

        // GET: TaiSan_59131885/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiSan taiSan = db.TaiSan.Find(id);
            if (taiSan == null)
            {
                return HttpNotFound();
            }
            return View(taiSan);
        }

        // POST: TaiSan_59131885/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TaiSan taiSan = db.TaiSan.Find(id);
            db.TaiSan.Remove(taiSan);
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
