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
            // Returns list of completed tasks
            Assert.AreEqual(project.CompletedTasks().Count, 2);
        }

        [Test()]
        public void IncompleteTasksTest()
        {
            List<TDTask> test_tasks = new List<TDTask>
            {
                new TDTask(priority: 3, description: "complete task", completed: true),
                new TDTask(priority: 3, description: "also complete", completed: true),
                new TDTask(priority: 3, description: "incomplete task", completed: false)
            };
            Project project = new Project(tasks: test_tasks);
            // Returns list of completed tasks
            Assert.AreEqual(project.CompletedTasks().Count, 2);
        }

        [Test()]
        public void GetTasksByPriority()
        {
            List<TDTask> test_tasks = new List<TDTask>
            {
                new TDTask(priority: 1, description: "highest priority task", completed: true),
                new TDTask(priority: 3, description: "high priority task", completed: true),
                new TDTask(priority: 7, description: "low priority task", completed: false)
            };
            Project project = new Project(tasks: test_tasks);
            // Returns list of tasks, ordered by priority
            Assert.AreEqual(project.GetTasksByPriority()[0].Description, "highest priority task");
            Assert.AreEqual(project.GetTasksByPriority()[1].Description, "high priority task");
            Assert.AreEqual(project.GetTasksByPriority()[2].Description, "low priority task");
        }

        [Test()]
        public void AddTaskTest()
        {
            List<TDTask> test_tasks = new List<TDTask>
            {
                new TDTask(priority: 1),
                new TDTask(priority: 3)
            };
            Project project = new Project(tasks: test_tasks);
            project.AddTask(new TDTask(priority: 7, description: "new task"));
            // Adds a new task to the Tasks attribute
            Assert.AreEqual(project.Tasks.Count, 3);
            // The new task is at the bottom position in the list
            Assert.AreEqual(project.Tasks[2].Description, "new task");
        }

        private Project LoadProject()
        {

        }

        private List<TDTask> LoadTasks()
        {

        }
        
    }
}