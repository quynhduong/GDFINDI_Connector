using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class StatusLog_View
    {
        public double Time { get; set; }
        public int? Production { get; set; }
        public double? OperationRateOfStations { get; set; }
        public double? OperationRateOfAssets { get; set; }
        public List<StaticItemLog_View> Stations { get; set; }
        public List<DynamicItemLog_View> Assets { get; set; }
        public List<DynamicItemLog_View> Toolings { get; set; }
    }
}