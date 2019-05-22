using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class Station_View
    {
        // public Station();

        public double X { get; set; }
        public double Y { get; set; }
        public double H { get; set; }
        public double V { get; set; }
        public string Desc { get; set; }
        public int? Parallel { get; set; }
        [JsonIgnore]
        public WorkingHourGroup WorkingHourGroup { get; set; }
        public int? TotalBufferSize { get; set; }
        public int? InputBufferSize { get; set; }
        public int? OutputBufferSize { get; set; }

        public string Name { get; set; }
                                           //  public ObservableCollection<Port> Ports { get; }

        //    public ObservableCollection<Hyperlink> Hyperlinks { get; }
    }
}