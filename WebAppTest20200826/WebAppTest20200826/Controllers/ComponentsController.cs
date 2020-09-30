using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTest20200826.Controllers
{
    public class ComponentsController : Controller
    {
        // GET: Components
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alerts()
        {
            return View();
        }
    }
}