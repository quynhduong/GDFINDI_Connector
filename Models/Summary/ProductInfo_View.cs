using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Summary
{
    public class ProductInfo_View
    {
        public List<int> Productions { get; set; }
        public double? AveragePitch { get; set; }
        public double? MaxPitch { get; set; }
        public double? MinPitch { get; set; }
    }
}