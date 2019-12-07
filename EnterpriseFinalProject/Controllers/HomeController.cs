// Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnterpriseFinalProject.Data_Access;
using EnterpriseFinalProject.DAL;
using EnterpriseFinalProject.Models;
using EnterpriseFinalProject.ServiceReference1;

// Written by Andrew Mckie

namespace EnterpriseFinalProject.Controllers
{
    // This the class that holds the controllers for our views
    public class HomeController : Controller
    {
        // Initialize the varialbes that are used in methoods
        private Data_Context DB = new Data_Context();
        Service1Client client = new Service1Client();

        // This controls the home view, it is the default page
        public ActionResult Index()
        {
            return View("HomePage");
        }

        // This controls the tabel view, it displays the team and all of its details
        public ActionResult displayID(SearchClass model)
        {
            // Gets the team details from the service (team, players, wins & losses, and sponsers)
            ViewBag.Team = client.retreveTeamDetails(model.id).dt;
            ViewBag.Players = client.retreveAllPlayersByTeam(model.id).dt;
            ViewBag.WinLoss = client.retreveTeamWinLoss().dt;
            ViewBag.Sponsor = client.retreveSponsor().dt;
            ViewBag.TeamID = model.id;
            var teamArray = new string[6] { "Boston Bruins", "Toronto Maple Leafs", "Montreal Canadiens", "Chicago Black Hawks", "Detroit Red Wings", "New York Rangers" };
            ViewBag.TeamNames = teamArray;
            return View("TableView");
        }

        // This controls the Players view, it displays all of the players
        public ActionResult displayAllPlayers()
        {
            // Gets the player details from the service
            ViewBag.Players = client.retreveAllPlayers().dt;
            var teamArray = new string[6] { "Boston Bruins", "Toronto Maple Leafs", "Montreal Canadiens", "Chicago Black Hawks", "Detroit Red Wings", "New York Rangers" };
            ViewBag.TeamNames = teamArray;
            return View("TableViewPlayers");
        }

        //This controls the home view, it is the home page
        public ActionResult HomePage()
        {
            //Data_Initializer myInit = new Data_Initializer();
            //myInit.Populate(DB);
            return View("HomePage");
        }

        // This controls the team details view, it displays all of the teams
        public ActionResult ListTeamDetails()
        {
            // Gets the teams from the service
            ViewBag.Team = client.retreveAllTeams().dt;
            return View("ListTeamDetails");
        }

        // This controls the players by position view, it lists all of the players of the selected position
        public ActionResult displayAllPlayersByPosition(SearchClass model)
        {
            // Gets the players by position from the service
            ViewBag.Players = client.retreveAllPlayerByPosition(model.pos).dt;
            var teamArray = new string[6] { "Boston Bruins", "Toronto Maple Leafs", "Montreal Canadiens", "Chicago Black Hawks", "Detroit Red Wings", "New York Rangers" };
            ViewBag.TeamNames = teamArray;
            return View("PlayersByPosition");
        }
    }
}