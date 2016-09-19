using HairCare.DB;
using HairCare.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    public class AskExpertController : BaseController
    {

        public ActionResult Index()
        {
            srvAskExpert srv = new srvAskExpert();
            return View(srv.GetAllActive());
        }

        public ActionResult Form()
        {
            ViewBag.IsSent = false;
            return View();
        }

        [HttpPost]
        public ActionResult Form(AskExpert model)
        {            
            srvAskExpert srv = new srvAskExpert();
            model.SenderIP = HttpContext.Request.UserHostAddress;
            srv.SaveAsNotActive(model);
            ViewBag.IsSent = true;
            return View();
        }

        public PartialViewResult MainPart()
        {
            return PartialView();
        }
	}
}