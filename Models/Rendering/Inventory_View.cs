using MasterDetailsDemo.Models.StationActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class Inventory_View
    {
    
        public Part_View Part { get; set; }
     
        public Product_View Product { get; set; }
        public int? InputStock { get; set; }
        public int? InputBufferSize { get; set; }
        public int? OutputStock { get; set; }
        public int? OutputBufferSize { get; set; }
    }
}