using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseFinalProject.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Coach { get; set; }
    }
}