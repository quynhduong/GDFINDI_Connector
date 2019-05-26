using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsDemo.Models.Rendering
{
    public class RenderingResult_View
    {
        public RunningStatus_View RunningStatus { get; set; }
        public string Message { get; set; }
        public double ConvertTime { get; set; }
        public double RenderingTime { get; set; }
        public string Project { get; set; }
     //   public List<PartLog> PartLogs { get; set; }
     //   public List<StatusLog> StatusLogs { get; set; }
      //  public SummaryResult Summary { get; set; }
      //  public Dictionary<string, PartFlowLog> FlowLogs { get; set; }

      //  public void Add<T>(T log);
     //   public void Cancel();
    }
}