using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class Production
    {
        public List<Goal> production_goals { get; set; }

        public List<Orders> production_orders { get; set; }
    }
}