using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Written by Alex Teodorescu
// Stores information to represent a hockey team

namespace EnterpriseFinalProject.Models
{
    public class Team
    {
        // Unique ID
        public int ID { get; set; }
        // Team Name
        public string Name { get; set; }
        // Manager's Name
        public string Manager { get; set; }
        // Coach's Name
        public string Coach { get; set; }
    }
}