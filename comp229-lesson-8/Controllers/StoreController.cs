using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comp229_lesson_8.Controllers {
    public class StoreController : Controller {

        public ActionResult Index() {
            return View();
        }


        public ActionResult Browse() {
            return View();
        }

        public ActionResult Details() {
            return View();
        }

        [ActionName("service-1")]
        public string service1() {
            return "service result";
        }

        public JsonResult serviceJson() {
            return Json(new Dictionary<string, object>() {
                {"firstName", "Thiago" },
                {"lastName", "Andrade" },
                {"age", 31 },
                {"bornDate", new DateTime(1985, 02, 10) },
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult search(string person) {
            return Json(new Dictionary<string, object>() {
                {"firstName", person },
                {"age", 12 },
                {"bornDate", new DateTime(2004, 02, 10) },
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult searchById(int id) {
            return Json(new Dictionary<string, object>() {
                {"id", id },
            }, JsonRequestBehavior.AllowGet);
        }
    }
}