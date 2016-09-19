using HairCare.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    public class TipsController : Controller
    {
        //
        // GET: /Tips/
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TipList()
        {
            srvContent srv = new srvContent();
            return PartialView(srv.GetContentByCatId(14));
        }

        public PartialViewResult MainPart()
        {
            return PartialView();
        }
	}
}