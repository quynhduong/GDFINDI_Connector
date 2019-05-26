using GDfindi;
using GDfindi.Models;
using GDfindi.Models.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class RenderingController : Controller
    {
       
        // GET: Rendering
        public ActionResult Index()
        {
            return View();
        }


        public void PlayMusicEvent(object sender, EventArgs e)
        {
            //music.player.Stop();
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();
        }

        public async Task<Project> Mydelagate()
        {

            GDFService _svc = new GDFService();
            var ret = await _svc.LoginAsync(Session["user"].ToString(), Session["pass"].ToString());
            if (!ret)
            {
                return null;

            }
            
            var proj = await _svc.GetProjectAsync(Convert.ToInt32(Session["id"]));

            
          

            // 2. Execute Simulation
            var task1 = _svc.ExecRenderingAsync(
                           (s, e) => Console.WriteLine("time={0}, status={1}", e.Time, e.Result.RunningStatus),
                            proj
                         );

            RenderingResult rets = await task1;
            {
                var result = task1.Result;
                if (result != null)
                {
                    List<PartLog> partLogs = new List<PartLog>(result.PartLogs);
                    foreach(var i in partLogs)
                    {
                        var a = i.Parts;
                        var b = i.Time;
                    }
                    List<StatusLog> statusLogs = new List<StatusLog>(result.StatusLogs);
                   foreach(var y in statusLogs)
                    {
                        var c = y.Time;
                        var k = y.OperationRateOfStations;

                    }
                   // rets.FlowLogs = result.FlowLogs;
                 //   rets.PartLogs = result.PartLogs;
                 //   rets.StatusLogs = result.StatusLogs;
                   // rets.Summary = result.Summary;
                  //  rets.RenderingTime = result.RenderingTime;

                    var FlowLogs = result.FlowLogs;
                    var PartLogs = result.PartLogs;
                    var StatusLogs = result.StatusLogs;
                    var Summary = result.Summary;
                    var RenderingTime = result.RenderingTime;
                    partLogs.Add(result.PartLogs);
                    

                }
                return null ;
            }

        }
    }
}