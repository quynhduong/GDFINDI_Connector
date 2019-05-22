using MasterDetailsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;


namespace MasterDetailsDemo.Controllers
{
    public class OrdersController : Controller
    {
        // OnlineShopEntities db = new OnlineShopEntities();
        FreppleEntities db = new FreppleEntities();
        public ActionResult Index()
        {
            List<Customer> OrderAndCustomerList = db.Customers.ToList();
            return View(OrderAndCustomerList);
        }

      
     
            }
           
        }
    