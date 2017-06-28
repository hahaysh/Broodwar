using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Starcraft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //동일프로젝트 내 클래스
            //Starcraft.GoDoWa goDowa = new GoDoWa();
            //string strTemp = string.Empty;
            //strTemp = goDowa.ReturnReturn(new string[] { "저그와 ", "테란" });

            //클래스 라이브러리 참조
            StarcraftClassLibrary.GoDoWa goDowa = new StarcraftClassLibrary.GoDoWa();
            string strTemp = string.Empty;
            strTemp = goDowa.ReturnReturn(new string[] { "저그와 ", "테란" });


            ViewBag.Label = strTemp;

            return View();
        }


        public ActionResult About()
        {

            ViewBag.Message = "Your application description page.";
            //ViewBag.Message = strTemp;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}