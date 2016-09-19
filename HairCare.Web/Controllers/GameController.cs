using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIB.ExtentionMethods;
using HairCare.Web.Models;

namespace HairCare.Web.Controllers
{
    public class GameController : BaseAuthController
    {

        public ActionResult Index()
        {
            return View();
        }

        public void GameStart()
        {
            
        }

        public ActionResult End()
        {
            return View();            
        }

        public ActionResult Repeat()
        {
            return View();
        }

	}
}