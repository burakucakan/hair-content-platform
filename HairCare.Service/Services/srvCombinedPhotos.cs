using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairCare.DB;
namespace HairCare.Service
{
    public class srvCombinedPhotos : BaseService<GetCombinedPhotoList_Result>, IBaseService<GetCombinedPhotoList_Result>
    {
        public List<GetCombinedPhotoList_Result> GetCombinedPhotoList()
        {
            return c.GetCombinedPhotoList().Take(200).ToList();
        }

        public List<GetCombinedPhotoList_Result> GetTopNCombinedPhotoList(int topN, int source=-1)
        {
            if (source == -1)
                return c.GetCombinedPhotoList().OrderBy(m => Guid.NewGuid()).Take(topN).ToList();
            else return c.GetCombinedPhotoList().OrderBy(m => Guid.NewGuid()).Where(m => m.Source == source).Take(topN).ToList();
        }
    }
}
