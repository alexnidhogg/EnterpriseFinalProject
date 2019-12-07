using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Written by Alex Teodorescu
// Holds the data to represent the results of a single game

namespace EnterpriseFinalProject.Models
{
    public class WinLoss
    {
        // Unique ID (Primary Key)
        public int ID { get; set; }
        // Winner's ID (Seconday Key)
        public int Winner { get; set; }
        // Loser's ID (Secondary Key)
        public int Loser { get; set; }
    }
}