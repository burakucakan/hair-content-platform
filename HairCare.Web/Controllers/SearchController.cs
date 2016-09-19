using HairCare.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    public class SearchController : BaseController
    {
        public ActionResult Index()
        {
            var q = (Request.QueryString["q"] != null) ? Request.QueryString["q"] : null;

            if (q != null && q != String.Empty)
            {
                q = LIB.Util.r(q);

                srvContent service = new srvContent();
                var model = service.Search(q);

                ViewBag.q = q;

                return View(model);
            }
            else
                return GoHomePage();
        }
	}
}