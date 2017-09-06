using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIAN_API.Models;
using CIAN_API.Models.Interface;

namespace CIAN_API.Controllers.V1.FreeWay
{
    public class FreeWayInfoController : Controller
    {
        // GET: FreeWayInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetFreeWay()
        {
            //Initialize
            IFreeWay repos = DataFactory.FreeWayRepository();

            //return radius range Info
            return Content(JsonConvert.SerializeObject(repos.GetFreeWayInfo()), "application/json");
        }
    }
}