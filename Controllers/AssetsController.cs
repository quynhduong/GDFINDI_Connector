using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models.Assets;
using MasterDetailsDemo.Models.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class AssetsController : Controller
    {
        // GET: Assets
        public ActionResult Index()
        {
            return View();
        }


        public async Task<ActionResult> AssetsTools()
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
                //assign list of Part to proj variable

                List<Tooling> toolings = new List<Tooling>(proj.Assets.Toolings);
                List<Tooling_View> tooling_Views = new List<Tooling_View>();

                foreach (var i in toolings)
                {
                    Tooling_View tooling_View = new Tooling_View();
                    tooling_View.Name = i.Name;
                    tooling_View.Life = i.Life;
                    tooling_View.Policy = i.Policy;
                    tooling_View.ReleaseTime = i.ReleaseTime;
                    tooling_View.SetTime = i.SetTime;
                    tooling_View.Stock = i.Stock;
                    tooling_View.Unit = i.Unit;
                    tooling_Views.Add(tooling_View);
                }


                return View(tooling_Views);
            }
            return null;


        }//end of foreach


    }//end of else
         
}//end of project info

    

