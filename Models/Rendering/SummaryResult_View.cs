using MasterDetailsDemo.Models.Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class SummaryResult_View
    {
        public List<double> Times { get; set; }
        public Dictionary<string, ProductInfo_View> Products { get; set; }
        public Dictionary<string, StationInfo_View> StationStatuses { get; set; }
        public Dictionary<string, List<StatusInfo_View>> AssetStatuses { get; set; }
        public List<ProcessInfo> Processes { get; set; }
        public List<ToolingInfo_View> Toolings { get; set; }
    }
}