using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class PartLog_View
    {
        public double Time { get; set; }
        public List<DynamicItemLog_View> Parts { get; set; }
    }
}