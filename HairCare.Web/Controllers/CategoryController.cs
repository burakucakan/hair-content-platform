using HairCare.DB;
using HairCare.Service;
using HairCare.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HairCare.Web.Controllers
{
    public class CategoryController : BaseController
    {
        public ActionResult Index(int? Id)
        {
            if (Id != null)
            {
                srvCategory service = new srvCategory();

                CategoryModel model = new CategoryModel();

                model.ContentList = service.GetCategoryContentList(Id.Value).ToList();

                if (model.ContentList != null & model.ContentList.Count() > 0)
                {
                    GetCategoryContentList_Result FirstItem = model.ContentList.FirstOrDefault();
                    model.CategoryTitle = FirstItem.CategoryTitle;
                    model.CategoryDescription = FirstItem.CategoryDescription;
                    model.CategoryImage = FirstItem.CategoryImage;
                    return View(model);
                }
                else
                    GoHomePage();
                
            }

            return GoHomePage();
        }
	}
}