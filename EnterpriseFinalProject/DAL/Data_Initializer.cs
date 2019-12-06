using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnterpriseFinalProject.Data_Access;
using EnterpriseFinalProject.Models;

// Written by Alex Teodorescu
// Initializes each table in the database with values

namespace EnterpriseFinalProject.DAL
{
    public class Data_Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Data_Context>
    {
        public void Populate(Data_Context context)
        {
            List<Player> Players = new List<Player>
            {
                new Player{Name="Aline Doi", ID=0, Number=1, Position="Defense", TeamID=0},
                new Player{Name="Pasty Chavarria", ID=1, Number=2, Position="Defense", TeamID=0 },
                new Player{Name="Cher Akers", ID=2, Number=3, Position="Offense", TeamID=0 },
                new Player{Name="Windy Penrod", ID=3, Number=4, Position="Defense", TeamID=0 },
                new Player{Name="Gonzalo Dartez", ID=4, Number=5, Position="Offense", TeamID=0 },
                new Player{Name="Rebekah Nye", ID=5, Number=6, Position="Defense", TeamID=0 },
                new Player{Name="Elfreda Due", ID=6, Number=7, Position="Offense", TeamID=0 },
                new Player{Name="Blythe Heintz", ID=7, Number=8, Position="Defense", TeamID=0 },
                new Player{Name="Maple Bowne", ID=8, Number=9, Position="Offense", TeamID=0 },
                new Player{Name="Brittni Mckelvy", ID=9, Number=10, Position="Defense", TeamID=0 },
                new Player{Name="Annamae Bergren", ID=10, Number=11, Position="Defense", TeamID=0 },
                new Player{Name="Temeka Kendrick", ID=11, Number=12, Position="Offense", TeamID=0 },
                new Player{Name="Elina Niven", ID=12, Number=13, Position="Defense", TeamID=0 },
                new Player{Name="Ailene Millender", ID=13, Number=14, Position="Offense", TeamID=0 },
                new Player{Name="Danille Gaillard", ID=14, Number=15, Position="Goalie", TeamID=0 },
                new Player{Name="Jarrett Castile", ID=15, Number=1, Position="Defense", TeamID=1 },
                new Player{Name="Carlota Hofmann", ID=16, Number=2, Position="Offense", TeamID=1 },
                new Player{Name="Dino Glassford", ID=17, Number=3, Position="Defense", TeamID=1 },
                new Player{Name="Major Sola", ID=18, Number=4, Position="Offense", TeamID=1 },
                new Player{Name="Becky Hysell", ID=19, Number=5, Position="Offense", TeamID=1 },
                new Player{Name="Tamie Choy", ID=20, Number=6, Position="Defense", TeamID=1 },
                new Player{Name="Rosanna Ricketts", ID=21, Number=7, Position="Offense", TeamID=1 },
                new Player{Name="Arielle Burge", ID=22, Number=8, Position="Offense", TeamID=1 },
                new Player{Name="Delcie Fry", ID=23, Number=9, Position="Defense", TeamID=1 },
                new Player{Name="Chun Benz", ID=24, Number=10, Position="Offense", TeamID=1 },
                new Player{Name="Veta Ruddock", ID=25, Number=11, Position="Defense", TeamID=1 },
                new Player{Name="Evangelina Corum", ID=26, Number=12, Position="Offense", TeamID=1 },
                new Player{Name="Clyde Kenny", ID=27, Number=13, Position="Offense", TeamID=1 },
                new Player{Name="Grace Halvorson", ID=28, Number=14, Position="Defense", TeamID=1 },
                new Player{Name="Natashia Labat", ID=29, Number=15, Position="Goalie", TeamID=1 },
                new Player{Name="Cornelia Siders", ID=30, Number=1, Position="Defense", TeamID=2 },
                new Player{Name="Domitila Estep", ID=31, Number=2, Position="Offense", TeamID=2 },
                new Player{Name="Marcia Bybee", ID=32, Number=3, Position="Offense", TeamID=2 },
                new Player{Name="Ferdinand Pawlak", ID=33, Number=4, Position="Defense", TeamID=2 },
                new Player{Name="Anjanette Moodie", ID=34, Number=5, Position="Offense", TeamID=2 },
                new Player{Name="Carmelina Sancho", ID=35, Number=6, Position="Defense", TeamID=2 },
                new Player{Name="Blanca Newlin", ID=36, Number=7, Position="Offense", TeamID=2 },
                new Player{Name="Evalyn Sarmiento", ID=37, Number=8, Position="Defense", TeamID=2 },
                new Player{Name="Nannette Degreenia", ID=38, Number=9, Position="Offense", TeamID=2 },
                new Player{Name="Sharita Peel", ID=39, Number=10, Position="Defense", TeamID=2 },
                new Player{Name="Felicidad Stairs", ID=40, Number=11, Position="Offense", TeamID=2 },
                new Player{Name="Daniel Madriz", ID=41, Number=12, Position="Defense", TeamID=2 },
                new Player{Name="Kyla Dials", ID=42, Number=13, Position="Goalie", TeamID=2 },
                new Player{Name="Merna Mathews", ID=43, Number=14, Position="Defense", TeamID=2 },
                new Player{Name="Elena Looby", ID=44, Number=15, Position="Defense", TeamID=2 },
                new Player{Name="Elli Zahn", ID=45, Number=1, Position="Offense", TeamID=3 },
                new Player{Name="Jenine Remick", ID=46, Number=2, Position="Defense", TeamID=3 },
                new Player{Name="Florencia Pirtle", ID=47, Number=3, Position="Offense", TeamID=3 },
                new Player{Name="Coletta Buss", ID=48, Number=4, Position="Defense", TeamID=3 },
                new Player{Name="Ellena Guillen", ID=49, Number=5, Position="Offense", TeamID=3 },
                new Player{Name="Donny Ort", ID=50, Number=6, Position="Offense", TeamID=3 },
                new Player{Name="Karima Gorski", ID=51, Number=7, Position="Defense", TeamID=3 },
                new Player{Name="Joanna Casali", ID=52, Number=8, Position="Offense", TeamID=3 },
                new Player{Name="Audrey Odonnell", ID=53, Number=9, Position="Offense", TeamID=3 },
                new Player{Name="Eugena Etsitty", ID=54, Number=10, Position="Defense", TeamID=3 },
                new Player{Name="Charlott Marsico", ID=55, Number=11, Position="Offense", TeamID=3 },
                new Player{Name="Claudio Knappenberger", ID=56, Number=12, Position="Offense", TeamID=3 },
                new Player{Name="Chauncey Torgeson", ID=57, Number=13, Position="Defense", TeamID=3 },
                new Player{Name="Harry Holmen", ID=58, Number=14, Position="Goalie", TeamID=3 },
                new Player{Name="Hortensia Eagles", ID=59, Number=15, Position="Defense", TeamID=3 },
                new Player{Name="Adelaida Gutter", ID=60, Number=1, Position="Offense", TeamID=4 },
                new Player{Name="Eura Perdue", ID=61, Number=2, Position="Offense", TeamID=4 },
                new Player{Name="Jeanice Sinclair", ID=62, Number=3, Position="Defense", TeamID=4 },
                new Player{Name="Marshall Rayos", ID=63, Number=4, Position="Offense", TeamID=4 },
                new Player{Name="Jess Standridge", ID=64, Number=5, Position="Offense", TeamID=4 },
                new Player{Name="Cuc Deibert", ID=65, Number=6, Position="Defense", TeamID=4 },
                new Player{Name="Prince Marrs", ID=66, Number=7, Position="Offense", TeamID=4 },
                new Player{Name="Antoine Brainard", ID=67, Number=8, Position="Defense", TeamID=4 },
                new Player{Name="Stephani Cookingham", ID=68, Number=9, Position="Offense", TeamID=4 },
                new Player{Name="Leigha Mcgrail", ID=69, Number=10, Position="Offense", TeamID=4 },
                new Player{Name="Claribel Josephson", ID=70, Number=11, Position="Offense", TeamID=4 },
                new Player{Name="Iraida Glascock", ID=71, Number=12, Position="Defense", TeamID=4 },
                new Player{Name="Mirta Meachum", ID=72, Number=13, Position="Offense", TeamID=4 },
                new Player{Name="China Bowne", ID=73, Number=14, Position="Defense", TeamID=4 },
                new Player{Name="Millie Mirza", ID=74, Number=15, Position="Goalie", TeamID=4 },
                new Player{Name="Willa Dicus", ID=75, Number=1, Position="Defense", TeamID=5 },
                new Player{Name="Janee Gail", ID=76, Number=2, Position="Offense", TeamID=5 },
                new Player{Name="Nancie Pouncy", ID=77, Number=3, Position="Defense", TeamID=5 },
                new Player{Name="Lucinda Sugg", ID=78, Number=4, Position="Offense", TeamID=5 },
                new Player{Name="Linwood Danker", ID=79, Number=5, Position="Offense", TeamID=5 },
                new Player{Name="Evalyn Phillippe", ID=80, Number=6, Position="Defense", TeamID=5 },
                new Player{Name="Noah Rinker", ID=81, Number=7, Position="Offense", TeamID=5 },
                new Player{Name="Voncile Geist", ID=82, Number=8, Position="Defense", TeamID=5 },
                new Player{Name="Alma Erben", ID=83, Number=9, Position="Offense", TeamID=5 },
                new Player{Name="Jung Brammer", ID=84, Number=10, Position="Offense", TeamID=5 },
                new Player{Name="Gilma Margulies", ID=85, Number=11, Position="Offense", TeamID=5 },
                new Player{Name="Bettyann Sim", ID=86, Number=12, Position="Defense", TeamID=5 },
                new Player{Name="Princess Ruggieri", ID=87, Number=13, Position="Offense", TeamID=5 },
                new Player{Name="Oretha Bierce", ID=88, Number=14, Position="Defense", TeamID=5 },
                new Player{Name="Fernande Bosse", ID=89, Number=15, Position="Goalie", TeamID=5 }
            };
            Players.ForEach(s => context.Players.Add(s));
            List<Team> Teams = new List<Team>
            {
                new Team{ID=0, Name="Boston Bruins", Coach="Jim James", Manager="Doug Dimmadome"},
                new Team{ID=1, Name="Toronto Maple Leafs", Coach="Stan Steele", Manager="Leslie Lao"},
                new Team{ID=2, Name="Montreal Canadiens", Coach="Paul Pile", Manager="Paul Pile"},
                new Team{ID=3, Name="Chicago Black Hawks", Coach="Tyreese Tyrone", Manager="Jamal James"},
                new Team{ID=4, Name="Detroit Red Wings", Coach="Dan Dan", Manager="Stan Stan"},
                new Team{ID=5, Name="New York Rangers", Coach="Munkee Man", Manager="Dunkee Dan"}
            };
            Teams.ForEach(s => context.Teams.Add(s));
            List<WinLoss> Wins = new List<WinLoss>
            {
                new WinLoss{Winner=0, Loser=1, ID=0},
                new WinLoss{Winner=0, Loser=2, ID=1},
                new WinLoss{Winner=0, Loser=3, ID=2},
                new WinLoss{Winner=0, Loser=4, ID=3},
                new WinLoss{Winner=0, Loser=5, ID=4},
                new WinLoss{Winner=1, Loser=0, ID=5},
                new WinLoss{Winner=1, Loser=2, ID=6},
                new WinLoss{Winner=1, Loser=3, ID=7},
                new WinLoss{Winner=1, Loser=4, ID=8},
                new WinLoss{Winner=1, Loser=5, ID=9},
                new WinLoss{Winner=2, Loser=0, ID=10},
                new WinLoss{Winner=2, Loser=1, ID=11},
                new WinLoss{Winner=2, Loser=3, ID=12},
                new WinLoss{Winner=2, Loser=4, ID=13},
                new WinLoss{Winner=2, Loser=5, ID=14},
                new WinLoss{Winner=3, Loser=0, ID=15},
                new WinLoss{Winner=3, Loser=1, ID=16},
                new WinLoss{Winner=3, Loser=2, ID=17},
                new WinLoss{Winner=3, Loser=4, ID=18},
                new WinLoss{Winner=3, Loser=5, ID=19},
                new WinLoss{Winner=4, Loser=0, ID=20},
                new WinLoss{Winner=4, Loser=1, ID=21},
                new WinLoss{Winner=4, Loser=2, ID=22},
                new WinLoss{Winner=4, Loser=3, ID=23},
                new WinLoss{Winner=4, Loser=5, ID=24},
                new WinLoss{Winner=5, Loser=0, ID=25},
                new WinLoss{Winner=5, Loser=1, ID=26},
                new WinLoss{Winner=5, Loser=2, ID=27},
                new WinLoss{Winner=5, Loser=3, ID=28},
                new WinLoss{Winner=5, Loser=4, ID=29},
                new WinLoss{Winner=1, Loser=2, ID=30},
                new WinLoss{Winner=3, Loser=4, ID=31},
                new WinLoss{Winner=2, Loser=1, ID=32},
                new WinLoss{Winner=3, Loser=2, ID=33},
                new WinLoss{Winner=5, Loser=1, ID=34},
                new WinLoss{Winner=2, Loser=4, ID=35},
                new WinLoss{Winner=1, Loser=3, ID=36},
                new WinLoss{Winner=3, Loser=5, ID=37},
                new WinLoss{Winner=4, Loser=3, ID=38},
                new WinLoss{Winner=0, Loser=2, ID=39},
                new WinLoss{Winner=5, Loser=4, ID=40},
                new WinLoss{Winner=2, Loser=3, ID=41},
                new WinLoss{Winner=3, Loser=5, ID=42},
                new WinLoss{Winner=1, Loser=2, ID=43},
                new WinLoss{Winner=0, Loser=1, ID=44},
                new WinLoss{Winner=2, Loser=1, ID=45},
                new WinLoss{Winner=3, Loser=0, ID=46},
                new WinLoss{Winner=0, Loser=2, ID=47},
                new WinLoss{Winner=0, Loser=1, ID=48},
                new WinLoss{Winner=2, Loser=1, ID=49},
                new WinLoss{Winner=0, Loser=1, ID=50},
                new WinLoss{Winner=3, Loser=0, ID=51},
                new WinLoss{Winner=0, Loser=1, ID=52},
                new WinLoss{Winner=2, Loser=1, ID=53},
                new WinLoss{Winner=3, Loser=0, ID=54},
                new WinLoss{Winner=0, Loser=1, ID=55},
                new WinLoss{Winner=1, Loser=2, ID=56},
                new WinLoss{Winner=0, Loser=2, ID=57},
                new WinLoss{Winner=2, Loser=3, ID=58},
                new WinLoss{Winner=0, Loser=5, ID=59}
            };
            Wins.ForEach(s => context.Games.Add(s));
            List<Sponsor> Sponsors = new List<Sponsor>
            {
                new Sponsor{Name="Coca-Cola", Team=0},
                new Sponsor{Name="Pepsi", Team=1},
                new Sponsor{Name="Honda", Team=2},
                new Sponsor{Name="Ford", Team=3},
                new Sponsor{Name="Tesla", Team=4},
                new Sponsor{Name="Red Cross", Team=5}
            };
            Sponsors.ForEach(s => context.Sponsors.Add(s));
            context.SaveChanges();
        }
    }
}