using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.StationActivity
{
    public class Material_View
    {
        public Part_View Part { get; set; }
        public int? Quantity { get; set; }
        public int? Production { get; set; }
    }
}