using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CIAN_API.Models;
using CIAN_API.Models.Interface;
using CIAN_API.ViewModels;

namespace CIAN_API.Controllers.V1.Bus
{
    public class BusEstimateController : Controller
    {
        // GET: BusEstimate
        public async Task<ActionResult> Index()
        {
            //var BusRouteSource = await GetBusRouteData();
            //Setting target Url
            string targetURI = ConfigurationManager.AppSettings["BusEstimatedTimeURL"].ToString() + "?$format=JSON";
            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = Int32.MaxValue;
            //Get Json String
            var response = await client.GetStringAsync(targetURI);
            //Deserialize
            var collection = JsonConvert.DeserializeObject<IEnumerable<BusEstimatedTimeDeserialize>>(response);
            IBusRoute repos = DataFactory.BusRouteRepository();

            //將JSON反序列化的資料填進資料庫中
            repos.AddBusEstimate(collection);

            return View();
        }
    }
}