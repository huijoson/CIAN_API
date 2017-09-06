using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIAN_API.ViewModels
{
    
    public class BusStopDeserialize
    {
        public string RouteUID { get; set; }
        public string RouteID { get; set; }
        public Routename RouteName { get; set; }
        public bool KeyPattern { get; set; }
        public string SubRouteUID { get; set; }
        public string SubRouteID { get; set; }
        public Subroutename SubRouteName { get; set; }
        public int Direction { get; set; }
        public Stop[] Stops { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
    
}