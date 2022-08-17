using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelperMVC.Controllers
{
    public class DropDownCheckboxController : Controller
    {
        // GET: DropDownCheckbox
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            return View();
        }
    }
}