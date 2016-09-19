using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HairCare.Service;
using System.Xml;
namespace HairCare.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeroContents()
        {
            return PartialView();
        }

    }
}