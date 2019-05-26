using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models;
using MasterDetailsDemo.Models.StationActivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class InOutController : Controller
    {
        // GET: InOut
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Input()
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

                List<InOut_View> inOut_Views = new List<InOut_View>();

                foreach (var p in stationActivities)
                {
                    Process process = new Process();

                    process = p.Process;
                    processes.Add(process);

                   

                    //Define station object
                    Process_View process_View = new Process_View();

                    foreach(var ele in processes)
                    {
                        //Define a list of InOut Objects
                        List<InOut> inputs = new List<InOut>(ele.Inputs);

                        //Define a list of InOut_View Objects
                        List<InOut_View> input_Views = new List<InOut_View>();
                        foreach(var inp in inputs)
                        {
                            List<Material> materials = new List<Material>(inp.Materials);

                            List<Material_View> material_Views = new List<Material_View>();

                            foreach(var m in materials)
                            {
                                Material_View material_View = new Material_View();
                                material_View.Production = m.Production;
                                material_View.Quantity = m.Quantity;

                                material_Views.Add(material_View);
                            }

                            return View(material_Views);
                        }


                      //  List<InOut> outputs = new List<InOut>(ele.Outputs);
                       
                    }

                    process_Views.Add(process_View);



                }//end of foreach

                return View(process_Views);


            }//end of else

            return null;

        }//end of project info



        //Output Materials
        public async Task<ActionResult> Output()
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

                List<InOut_View> inOut_Views = new List<InOut_View>();

                foreach (var p in stationActivities)
                {
                    Process process = new Process();

                    process = p.Process;
                    processes.Add(process);



                    //Define station object
                    Process_View process_View = new Process_View();

                    foreach (var ele in processes)
                    {
                        //Define a list of InOut Objects
                        List<InOut> outputs = new List<InOut>(ele.Outputs);

                        //Define a list of InOut_View Objects
                        List<InOut_View> output_Views = new List<InOut_View>();
                        foreach (var outp in outputs)
                        {
                            List<Material> materials = new List<Material>(outp.Materials);

                            List<Material_View> material_Views = new List<Material_View>();

                            foreach (var m in materials)
                            {
                                Material_View material_View = new Material_View();
                                material_View.Production = m.Production;
                                material_View.Quantity = m.Quantity;

                                material_Views.Add(material_View);
                            }

                            return View(material_Views);
                        }


                        //  List<InOut> outputs = new List<InOut>(ele.Outputs);

                    }

                    process_Views.Add(process_View);



                }//end of foreach

                return View(process_Views);


            }//end of else

            return null;

        }//end of project info
    }
}