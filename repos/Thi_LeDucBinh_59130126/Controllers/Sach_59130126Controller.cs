using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Thi_LeDucBinh_59130126.Models;

namespace Thi_LeDucBinh_59130126.Controllers
{
    public class Sach_59130126Controller : Controller
    {
        private Thi_59130126Entities db = new Thi_59130126Entities();

        // GET: Sach_59130126
        public ActionResult Index()
        {
            var sACH = db.SACH.Include(s => s.LOAISACH);
            return View(sACH.ToList());
        }

        // GET: Sach_59130126/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SACH sACH = db.SACH.Find(id);
            if (sACH == null)
            {
                return HttpNotFound();
            }
            return View(sACH);
        }

        // GET: Sach_59130126/Create
        public ActionResult Create()
        {
            ViewBag.MaLS = new SelectList(db.LOAISACH, "MaLS", "TenLS");
            return View();
        }

        // POST: Sach_59130126/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSach,TenSach,AnhDaiDien,MoTa,NgonNgu,DonGia,TacGia,MaLS")] SACH sACH)
        {
            //System.Web.HttpPostedFileBase Avatar;
            var imgND = Request.Files["Avatar"];
            //Lấy thông tin từ input type=file có tên Avatar
            string postedFileName = System.IO.Path.GetFileName(imgND.FileName);
            //Lưu hình đại diện về Server
            var path = Server.MapPath("/Images/" + postedFileName);
            imgND.SaveAs(path);
            if (ModelState.IsValid)
            {
                sACH.AnhDaiDien = postedFileName;
                db.SACH.Add(sACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLS = new SelectList(db.LOAISACH, "MaLS", "TenLS", sACH.MaLS);
            return View(sACH);
        }

        // GET: Sach_59130126/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SACH sACH = db.SACH.Find(id);
            if (sACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLS = new SelectList(db.LOAISACH, "MaLS", "TenLS", sACH.MaLS);
            return View(sACH);
        }

        // POST: Sach_59130126/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSach,TenSach,AnhDaiDien,MoTa,NgonNgu,DonGia,TacGia,MaLS")] SACH sACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLS = new SelectList(db.LOAISACH, "MaLS", "TenLS", sACH.MaLS);
            return View(sACH);
        }

        // GET: Sach_59130126/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SACH sACH = db.SACH.Find(id);
            if (sACH == null)
            {
                return HttpNotFound();
            }
            return View(sACH);
        }

        // POST: Sach_59130126/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SACH sACH = db.SACH.Find(id);
            db.SACH.Remove(sACH);
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
