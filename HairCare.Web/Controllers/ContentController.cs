using HairCare.Com;
using HairCare.Service;
using HairCare.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    public class ContentController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int Id)
        {
            srvContent service = new srvContent();

            var model = service.GetContentDetail(Id);
                        

            if (model != null)
                return View(model);

            return GoHomePage();
        }

        public PartialViewResult NextContent(int CurrContentId)
        {
            srvContent service = new srvContent();
            return PartialView(service.GetNextContent(CurrContentId, Vars.defaultNextContentCount));
        }

        public PartialViewResult Popular(int? ParentId)
        {
            srvContent service = new srvContent();
            var model = service.GetPopular(ParentId);

            return PartialView(model);
        }

        public PartialViewResult Recents()
        {
            srvContent service = new srvContent();
            var model = service.GetRecents();

            return PartialView(model);
        }


	}
}