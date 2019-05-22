using GDfindi;
using GDfindi.Models;
using MasterDetailsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Project = GDfindi.Models.Project;

namespace MasterDetailsDemo.Controllers
{
    public class HomeController : Controller
    {
        private GDFService _svc;
        private Project _project;
        private FindiClient _client;

        public ActionResult Index()
        {
            return View();
        }

        //Load Projects
        public ActionResult UserPage(Initialize initialize)
        {
           
           
            //return RedirectToAction("Load", "Home", Session["userName"]);
            return View(Session["userName"]);
        }

       
       

        public ActionResult Run()
        {
          

            return View();
        }

       public ActionResult GetProjects()
        {

            return View();

            
       
        }
        
        public async Task<ActionResult> LoginAsync(Login login)
        {
            GDFService _svc = new GDFService();
            var user = login.user;
            Session["user"] = user;
            var password = login.password;
            Session["pass"] = password;
            var ret = await _svc.LoginAsync(user, password);
          
            var projectsL = await _svc.GetProjectsAsync();
           
            List<project> projects = new List<project>();
                
             foreach (var i in projectsL)
             {
                project project = new project();
                project.name = i.Name;
                project.id = i.Id;
                projects.Add(project);

                //return RedirectToAction("GetProjects", "Home");
                 

             }

            return View(projects);
        }



       
    }
}