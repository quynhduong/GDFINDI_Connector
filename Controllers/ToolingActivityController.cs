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
    public class ToolingActivityController : Controller
    {
        // GET: ToolingActivity
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ToolingActivity()
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

                

                List<ToolingActivity_View> tooling_Views = new List<ToolingActivity_View>();

                List<StationActivity_View> stationActivities_Views = new List<StationActivity_View>();
                StationActivity_View stationActivity_View = new StationActivity_View();

                foreach (var p in stationActivities)
                {
                    ToolingActivity tooling = new ToolingActivity();

                    List<ToolingActivity> toolings = new List<ToolingActivity>(p.ToolingActivities);

                    foreach(var t in toolings)
                    {

                    //Define tooling object
                    ToolingActivity_View tool_View = new ToolingActivity_View();

                        tool_View.Activation = t.Activation;
                        tool_View.Condition = t.Condition;
                        tool_View.Behavior = t.Behavior;
                        tool_View.Headcount = t.Headcount;
                        tool_View.Quantity = t.Quantity;
                        tool_View.Worktime = t.Worktime;
                        tool_View.WorkerBehavior = t.WorkerBehavior;
                        tool_View.Operation = t.Operation;



                        tooling_Views.Add(tool_View);


                       
                     

                    }//end of foreach tooling activity

                }//end of foreach

                return View(tooling_Views);
               

            }//end of else
            return null;
        }//end of project info
    }
}