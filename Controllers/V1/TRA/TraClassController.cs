﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CIAN_API.Models;
using CIAN_API.Models.Interface;

namespace CIAN_API.Controllers.V1.TRA
{
    public class TraClassController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var traClassSource = await new TraPubFunc().GetTraClassData();
            //將JSON反序列化的資料填進資料庫中
            using (ITraLine repos = DataFactory.TraRepository())
            {
                repos.AddTraClass(traClassSource);
            }
            return View();
        }
    }
}