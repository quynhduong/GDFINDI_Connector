using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models.StationActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class PartController : Controller
    {
        // GET: Part
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Part()
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
                List<Part> parts = new List<Part>(proj.PartsList);


                List<Part_View> Part_Views = new List<Part_View>();



                foreach (var p in parts)
                {
                    Part_View part_View = new Part_View();
                    part_View.Id = p.Id;
                    part_View.Name = p.Name;

                    Part_Views.Add(part_View);



                }//end of foreach

                return View(Part_Views);

            }//end of else
            return null;
        }//end of project info

    }
}