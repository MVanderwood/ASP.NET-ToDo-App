using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ASP.NET_ToDo_App.Models;


namespace ASP.NET_ToDo_App.Controllers
{
    [RoutePrefix("projects")]
    public class ProjectsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}