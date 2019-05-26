using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class StationActivity_View
    {
        //public StationActivity();

       
        public Station_View Station_View { get; set; }
       
       // public Product_View Product_View { get; set; }
        
       // public Process Process { get; set; }
        
        public ObservableCollection<object> Assignments { get; }
        public int? Headcount { get; set; }
        public double? Worktime { get; set; }
        public string Dispersion { get; set; }
        public string Position { get; set; }
        public bool? ShowToolingActivities { get; set; }
        public string WorkerBehavior { get; set; }
        public string Behavior { get; set; }
        public string Activation { get; set; }

        public ObservableCollection<ToolingActivity_View> ToolingActivities { get; }
        //public List<ToolingActivity_View> ToolingActivities { get; }
    }
}