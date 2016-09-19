using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HairCare.DB;
using HairCare.Service;
using System.Web.Script.Serialization;
using HairCare.Web.Models;
namespace HairCare.Web.Controllers
{
    public class StrongWomenController : BaseController
    {
        //
        // GET: /StrongWomen/
        public ActionResult Index()
        {
            srvCombinedPhotos srv = new srvCombinedPhotos();
            return View(srv.GetCombinedPhotoList());
        }

        public PartialViewResult MainPart()
        {
            srvCombinedPhotos srv = new srvCombinedPhotos();
            return PartialView(srv.GetTopNCombinedPhotoList(6));
        }

        public JsonResult SaveFriends(long[] ids)
        {
            srvFbNominee srv = new srvFbNominee();
            foreach (long id in ids)
            {
                FbNominee friend = UserFbFriendModel.FillNomineeModel(session.User.Friends.Where(m => m.FbId == id.ToString()).FirstOrDefault());
                srv.Save(friend);
            }
            return Json(new { Message=true }, JsonRequestBehavior.AllowGet);
        }
	}
}