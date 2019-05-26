using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models;
using MasterDetailsDemo.Models.StationActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Product(string name)
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

                List<Product> products = new List<Product>();

                List<Product_View> product_Views = new List<Product_View>();

                List<StationActivity_View> stationActivities_Views = new List<StationActivity_View>();
                StationActivity_View stationActivity_View = new StationActivity_View();

                foreach (var p in stationActivities)
                {
                   
                    Product_View product = new Product_View();

                    product.Name = p.Product.Name;
                    product.Desc = p.Product.Desc;
                    product_Views.Add(product);


                }//end of foreach

                return View(product_Views);


            }//end of else

            return null;

        }//end of project info
    }
}