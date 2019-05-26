using MasterDetailsDemo.Models.Rendering;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Assets
{
    public class Assets_View
    {
        public ObservableCollection<Tooling_View> Toolings { get; }
       // public ObservableCollection<Member_View> Members { get; }
    }
}