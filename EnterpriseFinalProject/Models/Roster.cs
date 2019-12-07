using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseFinalProject.Models
{
    public class Roster
    {
        public int ID { get; set; }
        public int TeamID { get; set; }
        public int[] Players { get; set; }
    }
}