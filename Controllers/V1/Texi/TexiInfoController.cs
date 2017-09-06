using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIAN_API.Models;
using CIAN_API.Models.Interface;

namespace CIAN_API.Controllers.V1.Texi
{
    public class TexiInfoController : Controller
    {
        // GET: TextInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTexiInfo()
        {
            //Initial Variables
            ITexi repos = DataFactory.TexiRepository();
            return Content(JsonConvert.SerializeObject(repos.GetTexiInfo()), "application/json");
        }
    }
}