using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ToDo_App.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Description { get; set; }
        public virtual List<TDTask> Tasks { get; set; }

        public List<TDTask> GetTasksByPriority()
        {
            return Tasks.OrderBy(o => o.Priority).ToList();
        }

        public void AddTask(TDTask Task)
        {
            Tasks.Add(Task);
        }

        public List<TDTask> CompletedTasks()
        {

        }
    }
}