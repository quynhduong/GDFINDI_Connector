using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class StaticItemLog_View
    {

        public int FrontBufInventory { get; set; }
        public int WorkInBufInventory { get; set; }
        public int BackBufInventory { get; set; }
        public int Production { get; set; }
        public string Module { get; set; }
        public string Product { get; set; }
        public string Process { get; set; }
        public int Status { get; set; }
    }
}