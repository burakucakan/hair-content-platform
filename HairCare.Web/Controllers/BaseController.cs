using HairCare.Web.App_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    public class BaseController : Controller
    {
        protected SessionManager session { get { return SessionManager.GetInstance(); } }

        protected ConfigManager config { get { return ConfigManager.GetInstance(); } }

        protected ActionResult GoHomePage() { return RedirectToAction("Index", "Home"); }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
	}
}