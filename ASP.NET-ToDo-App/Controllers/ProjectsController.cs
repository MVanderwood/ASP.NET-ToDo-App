﻿using System;
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
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("")]
        public ActionResult Index()
        {
            List<Project> projects = db.Projects.ToList();
            return View(projects);
        }

        [Route("{id:int}")]
        public ActionResult Show(int id)
        {
            Project project = db.Projects.Find(id);
            if (project == null) return HttpNotFound();
            return View(project);
        }

        [Route("new")]
        public ActionResult New()
        {
            Project project = new Project();
            return View(project);
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Project newProject)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(newProject);
                db.SaveChanges();
                return RedirectToAction("Show", new { id = newProject.ProjectID});
            }
            else
            {
                return View(newProject);
            }
        }
    }
}