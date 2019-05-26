using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Summary
{
    public class StatusInfo_View
    {
        public int Status { get; set; }
        public int ExecutedNumber { get; set; }
        public double SpanTime { get; set; }
        public string Place { get; set; }
        public string Product { get; set; }
        public string Process { get; set; }
        public Dictionary<string, int> LoadedParts { get; set; }
        public List<string> DeviceIds { get; set; }
    }
}