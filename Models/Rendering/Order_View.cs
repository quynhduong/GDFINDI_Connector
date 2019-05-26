using MasterDetailsDemo.Models.StationActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class Order_View
    {

        public Product_View Product { get; set; }
        public int? Lotsize { get; set; }
        public long? Daytime { get; set; }
        public Process_View Process { get; set; }
        
        public Station_View Station { get; set; }
        public bool? Aslot { get; set; }
    }
}