using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class WorkingHourGroup
    {
       // public WorkingHourGroup();

        [JsonProperty]
        public int? Id { get; }
        public string Name { get; set; }
        [JsonIgnore]
        public Worktime_View Worktime { get; set; }
        [JsonIgnore]
        public Calendar_View Calendar { get; set; }
        [JsonIgnore]
        public WorkingHourGroup Parent { get; set; }
    }
}