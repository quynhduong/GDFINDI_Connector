using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class ProductionSchedule_View
    {

        public ObservableCollection<Goal_View> Goals { get; }
      
        public ObservableCollection<Order_View> Orders { get; }
    }
}