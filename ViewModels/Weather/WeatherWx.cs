﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIAN_API.ViewModels.Weather
{
    public class WeatherWx
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string elementValue { get; set; }
        public string parameterName { get; set; }
        public string parameterValue { get; set; }

    }
}