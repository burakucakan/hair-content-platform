using FbManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HairCare.Web.Models;
using HairCare.DB;
using HairCare.Service;

namespace HairCare.Web.Controllers
{
    public class FacebookController : BaseController
    {
        public ActionResult Landing()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string JsonData, string AccessToken)
        {
            try
            {
                session.User = new UserDataManager().Handler(JsonData);
                session.FbAccessToken = AccessToken;

                return Json(new { result = "OK" }, "text/plain");
            }
            catch (Exception ex)
            {
                return Json(new { result = "ERR: " + ex.Message + " inner ex: " + ex.InnerException }, "text/plain");
            }
        }

        public ActionResult LoginCallBack()
        {

            return Content("alert('hop')", "text/javascript");
            //if (session.IsFbLogin)
            //    return RedirectToAction("Index", "Game");

            //return RedirectToAction("Index", "Home");
        }
	}


}