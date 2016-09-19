using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    public class InterviewController : Controller
    {
        public PartialViewResult MainPart()
        {
            return PartialView();
        }
	}
}