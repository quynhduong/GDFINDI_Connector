
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class RenderingCondition_View
    {
        public RenderingParameters_View RenderingParameters { get; set; }
      
        public ObservableCollection<ProductionSchedule_View> ProductionSchedules { get; }
    
        public ObservableCollection<StationStatus_View> StationStatus { get; }
    }
}