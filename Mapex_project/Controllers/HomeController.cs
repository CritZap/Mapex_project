using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mapex_project.Repositories;

namespace Mapex_project.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Map()
        {
            var mapRepository = new MapRepository();
            var map = mapRepository.GetById(1);
            return Json(map);
        }
    }
}
