using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Written By Alex Teodorescu
// Holds the data to represent a Sponsor

namespace EnterpriseFinalProject.Models
{
    public class Sponsor
    {
        // Secondary Key for the team being sponsor
        public int Team { get; set; }
        // Primary key, unique name
        public String Name { get; set; }
    }
}