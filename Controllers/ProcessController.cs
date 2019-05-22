using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Process()
        {
            GDFService _svc = new GDFService();
            var ret = await _svc.LoginAsync(Session["user"].ToString(), Session["pass"].ToString());
            if (!ret)
            {
                return null;

            }

            var proj = await _svc.GetProjectAsync(Convert.ToInt32(Session["id"]));



            if (proj == null)
            {
                ViewBag("There is no data in the system!");
            }
            else
            {
                List<StationActivity> stationActivities = new List<StationActivity>(proj.StationActivities);

                StationActivity stationActivity = new StationActivity();

                List<Process> processes = new List<Process>();

                List<Process_View> process_Views = new List<Process_View>();

                List<StationActivity_View> stationActivities_Views = new List<StationActivity_View>();
                StationActivity_View stationActivity_View = new StationActivity_View();

                foreach (var p in stationActivities)
                {
                    Process process = new Process();

                    process = p.Process;
                    processes.Add(process);


                    //Define station object
                    Process_View process_View = new Process_View();

                    process_View.Desc = process.Desc;
                    process_View.Disabled = process.Disabled;
                    process_View.Frequency = process.Frequency;
                    process_View.InputProcess = process.InputProcess;
                    process_View.IsFinal = process.IsFinal;
                    process_View.Name = process.Name;
                    process_View.OutputProcess = process.OutputProcess;
                    process_View.Setup = process.Setup;
                    process_View.Worktime = process.Worktime;
                    process_View.X = process.X;
                    process_View.Y = process.Y;

                    process_Views.Add(process_View);



                }//end of foreach

                return View(process_Views);
              

            }//end of else

            return null;

        }//end of project info
    }
}