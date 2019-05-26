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
    public class Product_PPController : Controller
    {
        // GET: Product_PP
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Product()
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


                List<Product_View> product_Views = new List<Product_View>();

                foreach (var p in productionProcesses)
                {
                    //Define Process Object

                    List<Product> products = new List<Product>(p.Products);
                    foreach (var k in products)
                    {
                        Product_View product = new Product_View();
                        product.Name = k.Name;
                        product.Desc = k.Desc;


                        product_Views.Add(product);
                    }





                }//end of foreach

                return View(product_Views);

            }//end of else
            return null;
        }//end of project info

    }
}