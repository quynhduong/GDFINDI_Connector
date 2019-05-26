using GDfindi;
using GDfindi.Models.Rendering;
using MasterDetailsDemo.Models.StationActivity;
using MasterDetailsDemo.Models.Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class ToolingsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Tooling()
        {

            GDFService _svc = new GDFService();
            var ret = await _svc.LoginAsync(Session["user"].ToString(), Session["pass"].ToString());
            if (!ret)
            {
                return null;

            }

            var proj = await _svc.GetProjectAsync(Convert.ToInt32(Session["id"]));



          
            var result = await _svc.ExecRenderingAsync(
                          (s, e) => Console.WriteLine("time={0}, status={1}", e.Time, e.Result.RunningStatus),
                             proj
                           );

            RenderingResult rendering = new RenderingResult();

            List<ToolingInfo_View> toolingInfo_Views = new List<ToolingInfo_View>();
            
            if (result != null)
            {
                rendering.Summary = result.Summary;
                SummaryResult summary = new SummaryResult();
                summary = result.Summary;
                List<ToolingInfo> toolingInfos = new List<ToolingInfo>(summary.Toolings);
                //Define object summary_view
                ToolingInfo_View toolingInfo_View = new ToolingInfo_View();
                ToolingInfo toolingInfo = new ToolingInfo();
                foreach (var i in toolingInfos)
                {
                    toolingInfo_View.UnusedCount = i.UnusedCount;
                    toolingInfo_View.UsedCount = i.UsedCount;
                    toolingInfo_View.ZeroLifeCount = i.ZeroLifeCount;
                    toolingInfo_Views.Add(toolingInfo_View);

                }



            }


            return View(toolingInfo_Views);









        }
    }
}