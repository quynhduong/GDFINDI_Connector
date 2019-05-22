using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class Process_View
    {
        //public Process_View();
        public double Y { get; set; }
        
        public ObservableCollection<Hyperlink_View> Hyperlinks { get; }
        public ObservableCollection<InOut_View> Outputs { get; }
        public ObservableCollection<InOut_View> Inputs { get; }
        public string OutputProcess { get; set; }
        public string InputProcess { get; set; }
        public string Frequency { get; set; }
        public double? Setup { get; set; }
        public double? Worktime { get; set; }
       
        public bool IsFinal { get; set; }
        public double X { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }

        public string Id { get; }
        
        public Product_View Product { get; set; }
      
        public ProductionProcess_View Parent { get; }
        public bool? Disabled { get; set; }

        //public InOut_View Connect(Process_View item);
       // public bool Disconnect(Process_View item);
    }
}