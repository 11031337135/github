using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace helloword.Areas.emp.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /emp/Default1/

        public ActionResult Index()
        {
            ViewBag.Desc = "Hello Emp";
            return View();
        }

    }
}
