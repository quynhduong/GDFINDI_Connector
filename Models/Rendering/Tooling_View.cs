using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class Tooling_View
    {
     
        public int? Id { get; }
        public string Name { get; set; }
        public int? Stock { get; set; }
        public double? SetTime { get; set; }
        public double? ReleaseTime { get; set; }
        public double? Life { get; set; }
        public int? Unit { get; set; }
        public int? Policy { get; set; }
    }
}