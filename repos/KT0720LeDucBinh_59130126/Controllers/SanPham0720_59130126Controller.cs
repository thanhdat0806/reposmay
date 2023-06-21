using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KT0720LeDucBinh_59130126.Models;

namespace KT0720LeDucBinh_59130126.Controllers
{
    public class SanPham0720_59130126Controller : Controller
    {
        public ActionResult GioiThieu_59130126()
        {
            
            return View();
        }

        private KT0720_59130126Entities db = new KT0720_59130126Entities();

        [HttpGet]
        public ActionResult TimKiem_59130126(string maSP = "", string loaiSP = "")
        {
            ViewBag.maSP = maSP;
            ViewBag.loaiSP = loaiSP;
            var SanPham = db.SANPHAM.SqlQuery("TimKiemThanhVien'" + maSP + "','" + loaiSP + "'");
            if (SanPham.Count() == 0)
                ViewBag.TB = "Không có thông tin cần tìm";
            return View(SanPham.ToList());
        }
        // GET: SanPham0720_59130126
        public ActionResult Index()
        {
            var sANPHAM = db.SANPHAM.Include(s => s.LOAISP);
            return View(sANPHAM.ToList());
        }

        // GET: SanPham0720_59130126/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // GET: SanPham0720_59130126/Create
        public ActionResult Create()
        {
            ViewBag.MaLSP = new SelectList(db.LOAISP, "MaLSP", "TenLSP");
            return View();
        }

        // POST: SanPham0720_59130126/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSP,TenSP,DVT,DonGia,XuatXu,NhaCungCap,GhiChu,MaLSP")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.SANPHAM.Add(sANPHAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLSP = new SelectList(db.LOAISP, "MaLSP", "TenLSP", sANPHAM.MaLSP);
            return View(sANPHAM);
        }

        // GET: SanPham0720_59130126/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLSP = new SelectList(db.LOAISP, "MaLSP", "TenLSP", sANPHAM.MaLSP);
            return View(sANPHAM);
        }

        // POST: SanPham0720_59130126/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSP,TenSP,DVT,DonGia,XuatXu,NhaCungCap,GhiChu,MaLSP")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sANPHAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLSP = new SelectList(db.LOAISP, "MaLSP", "TenLSP", sANPHAM.MaLSP);
            return View(sANPHAM);
        }

        // GET: SanPham0720_59130126/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }


        // POST: SanPham0720_59130126/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            db.SANPHAM.Remove(sANPHAM);
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
