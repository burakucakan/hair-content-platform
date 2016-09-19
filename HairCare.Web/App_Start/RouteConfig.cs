using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HairCare.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Cat2", "sac-bakimi/banyo-ritueli", new { controller = "Category", action = "Index", Id = 2 });
            routes.MapRoute("Cat6", "sac-bakimi/yipranmis-saclar-icin-bakim", new { controller = "Category", action = "Index", Id = 6 });
            routes.MapRoute("Cat3", "sac-bakimi/boyali-saclar-icin-bakim", new { controller = "Category", action = "Index", Id = 3 });
            routes.MapRoute("Cat4", "sac-bakimi/dokulen-saclar-icin-bakim", new { controller = "Category", action = "Index", Id = 4 });
            routes.MapRoute("Cat5", "sac-bakimi/uzun-saclar-icin-bakim", new { controller = "Category", action = "Index", Id = 5 });
            routes.MapRoute("Cat7", "sac-bakimi/sac-yaglari", new { controller = "Category", action = "Index", Id = 7 });
            
            routes.MapRoute("Cat10", "sac-modelleri/sac-modeli-trendleri", new { controller = "Category", action = "Index", Id = 10 });
            routes.MapRoute("Cat12", "sac-modelleri/ozel-gunlere-ozel-modeller", new { controller = "Category", action = "Index", Id = 12 });
            routes.MapRoute("Cat15", "sac-modelleri/pratik-sac-modelleri", new { controller = "Category", action = "Index", Id = 15 });
            routes.MapRoute("Cat16", "sac-modelleri/acik-sac-modelleri", new { controller = "Category", action = "Index", Id = 16 });
            routes.MapRoute("Cat17", "sac-modelleri/dalgali-sac-modelleri", new { controller = "Category", action = "Index", Id = 17 });
            routes.MapRoute("Cat18", "sac-modelleri/kisa-sac-modelleri", new { controller = "Category", action = "Index", Id = 18 });
            routes.MapRoute("Cat19", "sac-modelleri/topuz-modelleri", new { controller = "Category", action = "Index", Id = 19 });
            routes.MapRoute("Cat20", "sac-modelleri/orgu-sac-modelleri", new { controller = "Category", action = "Index", Id = 20 });
            
            routes.MapRoute("Cat22", "sac-tipleri/yagli", new { controller = "Category", action = "Index", Id = 22 });
            routes.MapRoute("Cat23", "sac-tipleri/normal", new { controller = "Category", action = "Index", Id = 23 });
            routes.MapRoute("Cat24", "sac-tipleri/kuru", new { controller = "Category", action = "Index", Id = 24 });
            routes.MapRoute("Cat25", "sac-tipleri/duz", new { controller = "Category", action = "Index", Id = 25 });
            routes.MapRoute("Cat26", "sac-tipleri/dalgali", new { controller = "Category", action = "Index", Id = 26 });
            routes.MapRoute("Cat27", "sac-tipleri/kivircik", new { controller = "Category", action = "Index", Id = 27 });
            routes.MapRoute("Cat28", "sac-tipleri/uzun", new { controller = "Category", action = "Index", Id = 28 });
            routes.MapRoute("Cat29", "sac-tipleri/orta", new { controller = "Category", action = "Index", Id = 29 });
            routes.MapRoute("Cat30", "sac-tipleri/kisa", new { controller = "Category", action = "Index", Id = 30 });
            routes.MapRoute("Cat31", "sac-tipleri/boyali", new { controller = "Category", action = "Index", Id = 31 });
            routes.MapRoute("Cat32", "sac-tipleri/yipranmis", new { controller = "Category", action = "Index", Id = 32 });
            routes.MapRoute("Cat33", "sac-tipleri/zayif", new { controller = "Category", action = "Index", Id = 33 });
            routes.MapRoute("Cat34", "sac-tipleri/dokulen", new { controller = "Category", action = "Index", Id = 34 });
            routes.MapRoute("Cat35", "sac-tipleri/kirik-uclu", new { controller = "Category", action = "Index", Id = 35 });
            routes.MapRoute("Cat36", "sac-tipleri/hacimsiz", new { controller = "Category", action = "Index", Id = 36 });
            routes.MapRoute("Cat37", "sac-tipleri/kabaran", new { controller = "Category", action = "Index", Id = 37 });
            routes.MapRoute("Cat38", "sac-tipleri/kepekli", new { controller = "Category", action = "Index", Id = 38 });
            routes.MapRoute("Cat39", "sac-tipleri/elektriklenen", new { controller = "Category", action = "Index", Id = 39 });
            
            routes.MapRoute("UnlulerdenTavsiyeler", "unlulerden-tavsiyeler", new { controller = "Category", action = "Index", Id = 13 });
            
            routes.MapRoute("AskExpert", "uzmana-sor", new { controller = "AskExpert", action = "Index", Id = UrlParameter.Optional });
            routes.MapRoute("AskExpertSoruSor", "uzmana-sor/soru-sor", new { controller = "AskExpert", action = "Form" });


            routes.MapRoute("Cat41", "izle-ve-uygula", new { controller = "WatchAndTry", action = "Index", Id = UrlParameter.Optional });
            
            routes.MapRoute("Cat42", "urunu-bul", new { controller = "Category", action = "Index", Id = 42 });

            routes.MapRoute("Cat43", "saclariyla-unluler", new { controller = "StrongWomen", action = "Index", Id = UrlParameter.Optional });
            
            routes.MapRoute("Cat14", "ipuclari", new { controller = "Tips", action = "Index", Id = UrlParameter.Optional });


            routes.MapRoute("Search", "arama", new { controller = "Search", action = "Index" });

            routes.MapRoute("Detail", "detay/{id}/{content-title}", new { controller = "Content", action = "Detail" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
