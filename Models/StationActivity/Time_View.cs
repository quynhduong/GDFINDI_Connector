
using GDfindi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class Time
    {

        [JsonIgnore]
        public DateTime Begin { get; set; }
        [JsonIgnore]
        public DateTime End { get; set; }
        public BehaviorOnTerminate BehaviorOnTerminate { get; set; }
    }
}