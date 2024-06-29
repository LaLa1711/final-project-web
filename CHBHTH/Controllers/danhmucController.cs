using CHBHTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHBHTH.Controllers
{
    public class danhmucController : Controller
    {
        QLbanhang db = new QLbanhang();
        public ActionResult danhmucpartial()
        {
            var danhmuc = db.LoaiHangs.Where(n => n.TenLoai != "A").Take(6).ToList();
            return PartialView(danhmuc);
        }

    }
}