using MasterDetailsDemo.Models.StationActivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class ProductionProcess_View
    {

      //  public Project Parent { get; }
        
        public int? Id { get; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public ObservableCollection<Process_View> Processes { get; }
        public ObservableCollection<Product_View> Products { get; }
       // public VisibilityEx Visibility { get; set; }
        public int TabIndex { get; set; }
        public DateTime Updated { get; }
    }
}