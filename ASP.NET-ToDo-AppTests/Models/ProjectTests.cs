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
            Project project = LoadProject();
            // Returns list of completed tasks
            Assert.AreEqual(project.CompletedTasks().Count, 2);
        }

        [Test()]
        public void IncompleteTasksTest()
        {
            Project project = LoadProject();
            // Returns list of completed tasks
            Assert.AreEqual(project.CompletedTasks().Count, 1);
        }

        [Test()]
        public void GetTasksByPriority()
        {
            Project project = LoadProject();
            // Returns list of tasks, ordered by priority
            Assert.AreEqual(project.GetTasksByPriority()[0].Priority, 1);
            Assert.AreEqual(project.GetTasksByPriority()[1].Priority, 3);
            Assert.AreEqual(project.GetTasksByPriority()[2].Priority, 4);
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

        private Project LoadProject(string description = "Some project", bool tasksComplete = false, bool variedTaskPriority = true)
        {
            return new Project
            (
                description: description, 
                tasks: LoadTasks(tasksComplete, variedTaskPriority)
            );
        }

        private List<TDTask> LoadTasks(bool allComplete = false, bool variedPriority = true)
        {
            List<TDTask> tasks = new List<TDTask>
            {
                new TDTask(description: "Some task.", priority: 1),
                new TDTask(description: "Some other task.", priority: 3),
                new TDTask(description: "Completed task.", priority: 4, completed: true)
            };
            if (allComplete)
            {
                tasks[0].Completed = true;
                tasks[1].Completed = true;
            }
            if (!variedPriority)
            {
                foreach(TDTask task in tasks) { task.Priority = 3; }
            }
            return tasks;
        }
    }
}