﻿using Newtonsoft.Json;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CIAN_API.Models;
using CIAN_API.Models.Interface;
using CIAN_API.ViewModels.Parking;

namespace CIAN_API.Controllers.V1.Park
{
    public class ParkingController : ApiController
    {

        /// <summary>
        /// 取得停車場資訊
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/v1/Park/Parking/GetParking")]
        [SwaggerResponse(HttpStatusCode.OK, "", typeof(ParkingDeserialize))]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerImplementationNotes("取得停車場資訊(桃園地區)")]
        //[SwaggerImplementationNotes("取得所有公車路線")]
        public IHttpActionResult GetParking()
        {
            //Initial
            IHttpActionResult responseResult;
            IParking repos = DataFactory.ParkingRepository();
            //序列化撈出來的資料
            var jsonSerialize = JsonConvert.SerializeObject(repos.GetOutParkingInfo());
            //做成JSON字串包裝到最後輸出
            StringContent responseMsgString = new StringContent(jsonSerialize, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage responseMsg = new HttpResponseMessage() { Content = responseMsgString };
            responseResult = ResponseMessage(responseMsg);

            return responseResult;
        }
    }
}