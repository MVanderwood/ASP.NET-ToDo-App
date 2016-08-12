using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ToDo_App.Models
{
    public class TDTask
    {
        public int PropID { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public int Priority { get; set; }
        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }

        public void Complete()
        {
            Completed = true;
        }
    }
}