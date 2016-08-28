using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_ToDo_App.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }

        [Required()]
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
            List<TDTask> CompletedTasks = new List<TDTask>();
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Completed)
                {
                    CompletedTasks.Add(Tasks[i]);
                }
            }
            return CompletedTasks;
        }

        public List<TDTask> IncompleteTasks()
        {
            List<TDTask> IncompleteTasks = new List<TDTask>();
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (!Tasks[i].Completed)
                {
                    IncompleteTasks.Add(Tasks[i]);
                }
            }
            return IncompleteTasks;
        }

    }
}