using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using truonglol.Models;

namespace truonglol.Controllers
{
    public class QUANAOsController : Controller
    {
        private KT7899_59136106Entities db = new KT7899_59136106Entities();

        // GET: QUANAOs
        public ActionResult Index()
        {
            var qUANAO = db.QUANAO.Include(q => q.LOAIQUANAO);
            return View(qUANAO.ToList());
        }

        // GET: QUANAOs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUANAO qUANAO = db.QUANAO.Find(id);
            if (qUANAO == null)
            {
                return HttpNotFound();
            }
            return View(qUANAO);
        }

        // GET: QUANAOs/Create
        public ActionResult Create()
        {
            ViewBag.MaLQA = new SelectList(db.LOAIQUANAO, "MaLQA", "TenLQA");
            return View();
        }

        // POST: QUANAOs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAQA,TenQA,MOTA,DonGia,XuatXu,Anh,MaLQA")] QUANAO qUANAO)
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
                qUANAO.Anh = postedFileName;
                db.QUANAO.Add(qUANAO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLQA = new SelectList(db.LOAIQUANAO, "MaLQA", "TenLQA", qUANAO.MaLQA);
            return View(qUANAO);
        }

        // GET: QUANAOs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUANAO qUANAO = db.QUANAO.Find(id);
            if (qUANAO == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLQA = new SelectList(db.LOAIQUANAO, "MaLQA", "TenLQA", qUANAO.MaLQA);
            return View(qUANAO);
        }

        // POST: QUANAOs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAQA,TenQA,MOTA,DonGia,XuatXu,Anh,MaLQA")] QUANAO qUANAO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qUANAO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLQA = new SelectList(db.LOAIQUANAO, "MaLQA", "TenLQA", qUANAO.MaLQA);
            return View(qUANAO);
        }

        // GET: QUANAOs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUANAO qUANAO = db.QUANAO.Find(id);
            if (qUANAO == null)
            {
                return HttpNotFound();
            }
            return View(qUANAO);
        }

        // POST: QUANAOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QUANAO qUANAO = db.QUANAO.Find(id);
            db.QUANAO.Remove(qUANAO);
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
