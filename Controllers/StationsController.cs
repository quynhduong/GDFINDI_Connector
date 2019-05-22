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
    public class StationsController : Controller
    {
        // GET: Stations
        public ActionResult Index()
        {
            return View();
        }


        public async Task<ActionResult> Station()
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
               
                List<Station> stations = new List<Station>();

                List<Station_View> stations_Views = new List<Station_View>();

                List<StationActivity_View> stationActivities_Views = new List<StationActivity_View>();
                StationActivity_View stationActivity_View = new StationActivity_View();

                foreach (var p in stationActivities)
                {
                   Station station = new Station();

                   station = p.Station;
                   stations.Add(station);
                   
                    
                        //Define station object
                        Station_View station_View = new Station_View();

                        station_View.H = station.H;
                        station_View.InputBufferSize = station.InputBufferSize;
                        station_View.OutputBufferSize = station.OutputBufferSize;
                        station_View.TotalBufferSize = station.TotalBufferSize;
                        station_View.X = station.X;
                        station_View.Y = station.Y;
                        station_View.Name = station.Name;


                        stations_Views.Add(station_View);

                         stations.Add(station);

                    //stationActivities.Add(stationActivity);

                   // stationActivities_Views.Add(stationActivity_View);



                }//end of foreach
                return View(stations_Views);
               // return View(stationActivities_Views);

            }//end of else
            return null;
        }//end of project info
    }
}