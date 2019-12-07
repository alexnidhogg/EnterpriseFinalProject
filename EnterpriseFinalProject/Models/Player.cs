using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseFinalProject.Models
{
    public class Player
    {
        public int ID { get; set; }
        public int TeamID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
    }
}