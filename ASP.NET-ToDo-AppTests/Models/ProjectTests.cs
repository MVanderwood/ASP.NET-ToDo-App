using NUnit.Framework;
using ASP.NET_ToDo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_ToDo_App.Models.Tests
{
    [TestFixture()]
    public class ProjectTests
    {
        [Test()]
        public void CompletedTasksTest()
        {
            List<TDTask> test_tasks = new List<TDTask>
            {
                new TDTask(priority: 3, description: "complete task", completed: true),
                new TDTask(priority: 3, description: "also complete", completed: true),
                new TDTask(priority: 3, description: "incomplete task", completed: false)
            };
            Project project = new Project(tasks: test_tasks);
            Assert.AreEqual(project.CompletedTasks().Count, 2);
        }
    }
}