using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairCare.DB;
using FbManager.Models;

namespace HairCare.Service
{
    public class srvCategory : BaseService<Category>, IBaseService<Category>
    {
        public IEnumerable<GetCategoryContentList_Result> GetCategoryContentList(int CategoryId)
        {
            return c.GetCategoryContentList(CategoryId);
        }

    }
}