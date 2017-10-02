using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string Ornek()
        {
            return "Merhaba";
        }
        public ActionResult OrnekHtml()
        {
            return View();
        }
        public JsonResult OrnekJson()
        {
            return Json(new { status = true, data = "Sayfa basariyla cagrildi" },JsonRequestBehavior.AllowGet);
        }


    }
}