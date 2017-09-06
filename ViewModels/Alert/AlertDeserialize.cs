using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CIAN_API.ViewModels.Alert.PublicSub;

namespace CIAN_API.ViewModels.Alert
{
    public class AlertDeserialize
    {   
        /// <summary>
        /// 災害消息編號
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 災害標題
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 發布時間
        /// </summary>
        public DateTime updated { get; set; }
        /// <summary>
        /// 發布單位
        /// </summary>
        public Author author { get; set; }
        public Link link { get; set; }
        public Summary summary { get; set; }
        public Category category { get; set; }
    }
}