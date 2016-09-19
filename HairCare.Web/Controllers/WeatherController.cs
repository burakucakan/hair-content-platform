using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace HairCare.Web.Controllers
{
    public class WeatherController : Controller
    {
        [HttpPost]
        public JsonResult GetCityWeather(string city)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("http://api.weather.yandex.ru/partner/get_weather_tr?apikey=e36eXNgpF6gsBDC5HyC0WTta7TsvydGGfYzaIwRX");
            XmlNode xmlCity = xDoc.DocumentElement.SelectSingleNode("//node()[@name='" + city + "']");

            string code = xmlCity.ChildNodes[0].Attributes[0].Value;

            string condition = xmlCity.ChildNodes[0].InnerText;
            string temperature = xmlCity.ChildNodes[6].InnerText;

            return Json(new { code = code, condition = condition, temperature = temperature }, JsonRequestBehavior.AllowGet);
        }
	}
}