using MasterDetailsDemo.Models.StationActivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class InOut_View
    {
        
        public Process_View Destination { get; }
        
        public ObservableCollection<Material_View> Material_Views { get; }
    }
}