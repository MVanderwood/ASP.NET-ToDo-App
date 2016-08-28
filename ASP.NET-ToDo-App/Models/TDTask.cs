using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_ToDo_App.Models
{
    public class TDTask
    {
        [Key]
        public int TDTaskID { get; set; }

        [Required()]
        public string Description { get; set; }

        [Required()]
        public bool Completed { get; set; }
        
        [Required()]
        [Range(1, 10)]
        public int Priority { get; set; }

        public int ProjectID { get; set; }

        public virtual Project Project { get; set; }

    }
}