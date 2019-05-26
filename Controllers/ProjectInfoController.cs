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
    public class ProjectInfoController : Controller
    {
        Project project = new Project("a");
        // GET: ProjectInfo
        public ActionResult Index()
        {
            return View();
        }


        public async Task<ActionResult> ProjectInfo()
        {
            GDFService _svc = new GDFService();
            var ret = await _svc.LoginAsync(Session["user"].ToString(), Session["pass"].ToString());
            if(!ret)
            {
                return null;
                   
            }
            //var id = Convert.ToInt32(Session["id"]);
            var proj = await _svc.GetProjectAsync(Convert.ToInt32(Session["id"]));

            //Project proj = new Project(Session["name"].ToString());

            if (proj == null)
            {
                ViewBag("There is no data in the system!");
            }
            else
            { 
            List<StationActivity> stationActivities = new List<StationActivity>(proj.StationActivities);
            

            List<StationActivity_View> stationActivity_Views = new List<StationActivity_View>();
           
           

                    foreach(var p in stationActivities)
                    {
                        StationActivity_View activity_View = new StationActivity_View();
                        activity_View.Worktime = p.Worktime;
                        activity_View.Dispersion = p.Dispersion;
                        activity_View.Position = p.Position;
                        activity_View.Activation = p.Activation;
                        activity_View.Behavior = p.Behavior;
                        activity_View.ShowToolingActivities = p.ShowToolingActivities;

                
                        stationActivity_Views.Add(activity_View);
                

                       
                    }//end of foreach

                return View(stationActivity_Views);

            }//end of else
            return null;
        }//end of project info

        [HttpPost]
        public ActionResult detail(bool Example)
        {

            if (Example != false)
            {
                var ID = Convert.ToString(Request.Form["id"]);
                Session["id"] = ID;
                var name = Convert.ToString(Request.Form["name"]);
                Session["name"] = name;
                return RedirectToAction("ProjectInfo", "ProjectInfo");

               
            }

            return null;
        }
    }
}