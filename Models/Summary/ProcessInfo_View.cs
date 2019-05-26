using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Summary
{
    public class ProcessInfo_View
    {
        public string ProductName { get; set; }
        public double? StartTime { get; set; }
        public double? EndTime { get; set; }
        public Dictionary<string, double?> Productions { get; set; }
        public Dictionary<string, double?> Requirements { get; set; }
    }
}