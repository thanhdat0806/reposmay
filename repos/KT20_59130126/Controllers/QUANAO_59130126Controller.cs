using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KT20_59130126.Models;

namespace KT20_59130126.Controllers
{
    public class QUANAO_59130126Controller : Controller
    {
        private KT20_59130126Entities db = new KT20_59130126Entities();

        // GET: QUANAO_59130126
        public ActionResult Index()
        {
            var qUANAOs = db.QUANAOs.Include(q => q.LOAIQUANAO);
            return View(qUANAOs.ToList());
        }

        // GET: QUANAO_59130126/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUANAO qUANAO = db.QUANAOs.Find(id);
            if (qUANAO == null)
            {
                return HttpNotFound();
            }
            return View(qUANAO);
        }

        // GET: QUANAO_59130126/Create
        public ActionResult Create()
        {
            ViewBag.MaLQA = new SelectList(db.LOAIQUANAOs, "MaLQA", "TenLQA");
            return View();
        }

        // POST: QUANAO_59130126/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaQA,TenQA,MoTa,DonGia,XuatXu,Anh,MaLQA")] QUANAO qUANAO)
        {
            //System.Web.HttpPostedFileBase Avatar;
            var imgQA = Request.Files["Avatar"];
            //Lấy thông tin từ input type=file có tên Avatar
            string postedFileName = System.IO.Path.GetFileName(imgQA.FileName);
            //Lưu hình đại diện về Server
            var path = Server.MapPath("/Images/" + postedFileName);
            imgQA.SaveAs(path);
            if (ModelState.IsValid)
            {
                qUANAO.Anh = postedFileName;
                db.QUANAOs.Add(qUANAO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLQA = new SelectList(db.LOAIQUANAOs, "MaLQA", "TenLQA", qUANAO.MaLQA);
            return View(qUANAO);
        }

        // GET: QUANAO_59130126/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUANAO qUANAO = db.QUANAOs.Find(id);
            if (qUANAO == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLQA = new SelectList(db.LOAIQUANAOs, "MaLQA", "TenLQA", qUANAO.MaLQA);
            return View(qUANAO);
        }

        // POST: QUANAO_59130126/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaQA,TenQA,MoTa,DonGia,XuatXu,Anh,MaLQA")] QUANAO qUANAO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qUANAO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLQA = new SelectList(db.LOAIQUANAOs, "MaLQA", "TenLQA", qUANAO.MaLQA);
            return View(qUANAO);
        }

        // GET: QUANAO_59130126/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QUANAO qUANAO = db.QUANAOs.Find(id);
            if (qUANAO == null)
            {
                return HttpNotFound();
            }
            return View(qUANAO);
        }

        // POST: QUANAO_59130126/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QUANAO qUANAO = db.QUANAOs.Find(id);
            db.QUANAOs.Remove(qUANAO);
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
