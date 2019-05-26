using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Content
{
    public class Process_PPController : Controller
    {
        // GET: Process_PP
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

                List<Process_View> process_Views = new List<Process_View>();

                foreach (var p in productionProcesses)
                {
                    //Define Process Object
                   
                    List<Process> processes = new List<Process>(p.Processes);
                    foreach(var k in processes)
                    {
                        Process_View process_View = new Process_View();
                        process_View.Name = k.Name;
                        process_View.Desc = k.Desc;
                        process_View.Disabled = k.Disabled;
                        process_View.Frequency = k.Frequency;
                        process_View.InputProcess = k.InputProcess;
                        process_View.OutputProcess = k.OutputProcess;
                        process_View.Worktime = k.Worktime;
                        process_View.X = k.X;
                        process_View.Y = k.Y;
                        process_View.Setup = k.Setup;
                        process_View.IsFinal = k.IsFinal;

                        process_Views.Add(process_View);
                    }

                   



                }//end of foreach

                return View(process_Views);

            }//end of else
            return null;
        }//end of project info

    }
}