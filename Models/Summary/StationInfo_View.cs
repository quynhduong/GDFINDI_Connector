using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Summary
{
    public class StationInfo_View
    {
        public Dictionary<string, List<int>> FrontInventories;
        public Dictionary<string, List<int>> BackInventories;
        public List<StatusInfo_View> Statuses;
    }
}