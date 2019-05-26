using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class RenderingParameters_View
    {
        public int? StartTime { get; set; }
        public int? Period { get; set; }
        public int? Sampling { get; set; }
        public int? DataInterval { get; set; }
    }
}