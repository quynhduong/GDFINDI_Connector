using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class RenderingConditionController : Controller
    {
        // GET: RenderingCondition
        public ActionResult Index()
        {
            return View();
        }


        public async Task<ActionResult> RenderingCondition()
        {
            GDFService _svc = new GDFService();
            var ret = await _svc.LoginAsync(Session["user"].ToString(), Session["pass"].ToString());
            if (!ret)
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

                RenderingCondition rendering = new RenderingCondition();
                rendering = proj.RenderingCondition;
                RenderingParameters parameters = new RenderingParameters();
                parameters = rendering.RenderingParameters;

                //Define the object the rendering parameters_View object
                RenderingParameters_View renderingParameters_View = new RenderingParameters_View();

                renderingParameters_View.StartTime = parameters.StartTime;
                renderingParameters_View.Sampling = parameters.Sampling;
                renderingParameters_View.Period = parameters.Period;
                renderingParameters_View.DataInterval = parameters.DataInterval;


               

                return View(renderingParameters_View);

            }//end of else
            return null;
        }
    }
}