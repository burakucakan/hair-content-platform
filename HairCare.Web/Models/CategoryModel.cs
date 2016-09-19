using HairCare.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairCare.Web.Models
{
    public class CategoryModel
    {
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }

        public IEnumerable<GetCategoryContentList_Result> ContentList { get; set; }

    }
}