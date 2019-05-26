using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class StationStatus_View
    {
     
        public Station_View Station { get; set; }
        public ObservableCollection<Inventory_View> Inventories { get; }
      
        public ObservableCollection<Tooling_View> Toolings { get; set; }
    }
}