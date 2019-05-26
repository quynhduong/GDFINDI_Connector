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
    public class ProductionProcessController : Controller
    {
        // GET: ProductionProcess
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> ProductionProcess()
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
                List<ProductionProcess> productionProcesses = new List<ProductionProcess>(proj.ProductionProcesses);


                List<ProductionProcess_View> productionProc_Views = new List<ProductionProcess_View>();



                foreach (var p in productionProcesses)
                {
                    ProductionProcess_View prodProc_View = new ProductionProcess_View();
                    prodProc_View.Desc = p.Desc;
                    prodProc_View.Name = p.Name;

                    productionProc_Views.Add(prodProc_View);



                }//end of foreach

                return View(productionProc_Views);

            }//end of else
            return null;
        }//end of project info

    }
}