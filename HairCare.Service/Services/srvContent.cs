using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairCare.DB;
using FbManager.Models;

namespace HairCare.Service
{
    public class srvContent : BaseService<Content>, IBaseService<Content>
    {
        public GetContentDetail_Result GetContentDetail(int ContentId)
        {
            return c.GetContentDetail(ContentId).FirstOrDefault();
        }

        public IEnumerable<Content> GetNextContent(int CurrContextId, int Count)
        {
            return c.Contents.Where(m => m.IsActive == true && m.IsDeleted == false && m.Id > CurrContextId).ToList().Take(Count);
        }

        public IEnumerable<GetRecentContents_Result> GetRecents()
        {
            return c.GetRecentContents();
        }

        public IEnumerable<GetPopularContents_Result> GetPopular(int? ParentId)
        {
            return c.GetPopularContents(ParentId);
        }

        public IEnumerable<Content> Search(string q)
        {
            return c.Contents.Where(m => m.IsActive == true && m.IsDeleted == false
                && (m.Title.Contains(q) || (m.Header.Contains(q))))
                .ToList();
        }

        public IEnumerable<Content> GetContentByCatId(int catId)
        {
            return (from con in c.Contents join conCat in c.ContentCategories on con.Id equals conCat.ContentId where conCat.CategoryId == catId select con).ToList();
        }

    }
}
