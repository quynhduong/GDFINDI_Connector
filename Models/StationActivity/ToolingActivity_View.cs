using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class ToolingActivity_View
    {
        public string Condition { get; set; }
        public string Tooling { get; set; }
        public string Quantity { get; set; }
        public string Operation { get; set; }
       
        public ObservableCollection<object> Assignments { get; }
        public int? Headcount { get; set; }
        public double? Worktime { get; set; }
        public string Position { get; set; }
        public string WorkerBehavior { get; set; }
        public string Behavior { get; set; }
        public string Activation { get; set; }
    }
}