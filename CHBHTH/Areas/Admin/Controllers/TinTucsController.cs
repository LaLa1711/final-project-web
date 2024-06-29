﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CHBHTH.Models;

namespace CHBHTH.Areas.Admin.Controllers
{
    public class TinTucsController : Controller
    {
        private QLbanhang db = new QLbanhang();

        public ActionResult Index()
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.PhanQuyen);
            var u = Session["use"] as CHBHTH.Models.TaiKhoan;
            if (u.PhanQuyen.TenQuyen == "Adminstrator")
            {
                return View(db.TinTucs.ToList());
            }
            return RedirectPermanent("~/Home/Index");
        }

        public ActionResult Details(int? id)
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.PhanQuyen);
            var u = Session["use"] as CHBHTH.Models.TaiKhoan;
            if (u.PhanQuyen.TenQuyen == "Adminstrator")
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                TinTuc tinTuc = db.TinTucs.Find(id);
                if (tinTuc == null)
                {
                    return HttpNotFound();
                }
                return View(tinTuc);
            }
            return RedirectPermanent("~/Home/Index");
        }

        public ActionResult Create()
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.PhanQuyen);
            var u = Session["use"] as CHBHTH.Models.TaiKhoan;
            if (u.PhanQuyen.TenQuyen == "Adminstrator")
            {
                return View();
            }
            return RedirectPermanent("~/Home/Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "MaTT,TieuDe,NoiDung")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                db.TinTucs.Add(tinTuc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tinTuc);
        }

        public ActionResult Edit(int? id)
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.PhanQuyen);
            var u = Session["use"] as CHBHTH.Models.TaiKhoan;
            if (u.PhanQuyen.TenQuyen == "Adminstrator")
            {
                    if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                TinTuc tinTuc = db.TinTucs.Find(id);
                if (tinTuc == null)
                {
                    return HttpNotFound();
                }
                return View(tinTuc);
            }
            return RedirectPermanent("~/Home/Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "MaTT,TieuDe,NoiDung")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tinTuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tinTuc);
        }

        public ActionResult Delete(int? id)
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.PhanQuyen);
            var u = Session["use"] as CHBHTH.Models.TaiKhoan;
            if (u.PhanQuyen.TenQuyen == "Adminstrator")
            {
                if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinTuc tinTuc = db.TinTucs.Find(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            return View(tinTuc);
            }
            return RedirectPermanent("~/Home/Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TinTuc tinTuc = db.TinTucs.Find(id);
            db.TinTucs.Remove(tinTuc);
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