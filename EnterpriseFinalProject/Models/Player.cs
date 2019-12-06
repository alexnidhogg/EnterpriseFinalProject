using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Written By Alex Teodorescu
// Holds information to represent a hockey player

namespace EnterpriseFinalProject.Models
{
    public class Player
    {
        // Unique ID
        public int ID { get; set; }
        // Hold's the team's ID here to reference which team they're on
        public int TeamID { get; set; }
        // Player's Name
        public string Name { get; set; }
        // Player's Number
        public int Number { get; set; }
        // Player's Position
        public string Position { get; set; }
    }
}