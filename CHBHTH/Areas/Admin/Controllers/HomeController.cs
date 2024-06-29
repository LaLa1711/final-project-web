
using CHBHTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace CHBHTH.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var u = Session["use"] as CHBHTH.Models.TaiKhoan;
            if (u.PhanQuyen.TenQuyen == "Adminstrator")
            {
                return View();
            }

            return RedirectPermanent("~/Home/Index");
        }
    }
}