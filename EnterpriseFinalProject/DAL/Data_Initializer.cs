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
    public class Data_Initializer : System.Data.Entity.DropCreateDatabaseAlways<Data_Context>
    {
        public void Populate(Data_Context context)
        {
            List<Player> Players = new List<Player>
            {
                new Player{Name="Aline Doi", ID=1, Number=1, Position="Defense", TeamID=1},
                new Player{Name="Pasty Chavarria", ID=2, Number=2, Position="Defense", TeamID=1 },
                new Player{Name="Cher Akers", ID=3, Number=3, Position="Offense", TeamID=1 },
                new Player{Name="Windy Penrod", ID=4, Number=4, Position="Defense", TeamID=1 },
                new Player{Name="Gonzalo Dartez", ID=5, Number=5, Position="Offense", TeamID=1 },
                new Player{Name="Rebekah Nye", ID=6, Number=6, Position="Defense", TeamID=1 },
                new Player{Name="Elfreda Due", ID=7, Number=7, Position="Offense", TeamID=1 },
                new Player{Name="Blythe Heintz", ID=8, Number=8, Position="Defense", TeamID=1 },
                new Player{Name="Maple Bowne", ID=9, Number=9, Position="Offense", TeamID=1 },
                new Player{Name="Brittni Mckelvy", ID=10, Number=10, Position="Defense", TeamID=1 },
                new Player{Name="Annamae Bergren", ID=11, Number=11, Position="Defense", TeamID=1 },
                new Player{Name="Temeka Kendrick", ID=12, Number=12, Position="Offense", TeamID=1 },
                new Player{Name="Elina Niven", ID=13, Number=13, Position="Defense", TeamID=1 },
                new Player{Name="Ailene Millender", ID=14, Number=14, Position="Offense", TeamID=1 },
                new Player{Name="Danille Gaillard", ID=15, Number=15, Position="Goalie", TeamID=1 },
                new Player{Name="Jarrett Castile", ID=16, Number=1, Position="Defense", TeamID=2 },
                new Player{Name="Carlota Hofmann", ID=17, Number=2, Position="Offense", TeamID=2 },
                new Player{Name="Dino Glassford", ID=18, Number=3, Position="Defense", TeamID=2 },
                new Player{Name="Major Sola", ID=19, Number=4, Position="Offense", TeamID=2 },
                new Player{Name="Becky Hysell", ID=20, Number=5, Position="Offense", TeamID=2 },
                new Player{Name="Tamie Choy", ID=21, Number=6, Position="Defense", TeamID=2 },
                new Player{Name="Rosanna Ricketts", ID=22, Number=7, Position="Offense", TeamID=2 },
                new Player{Name="Arielle Burge", ID=23, Number=8, Position="Offense", TeamID=2 },
                new Player{Name="Delcie Fry", ID=24, Number=9, Position="Defense", TeamID=2 },
                new Player{Name="Chun Benz", ID=25, Number=10, Position="Offense", TeamID=2 },
                new Player{Name="Veta Ruddock", ID=26, Number=11, Position="Defense", TeamID=2 },
                new Player{Name="Evangelina Corum", ID=27, Number=12, Position="Offense", TeamID=2 },
                new Player{Name="Clyde Kenny", ID=28, Number=13, Position="Offense", TeamID=2 },
                new Player{Name="Grace Halvorson", ID=29, Number=14, Position="Defense", TeamID=2 },
                new Player{Name="Natashia Labat", ID=30, Number=15, Position="Goalie", TeamID=2 },
                new Player{Name="Cornelia Siders", ID=31, Number=1, Position="Defense", TeamID=3 },
                new Player{Name="Domitila Estep", ID=32, Number=2, Position="Offense", TeamID=3 },
                new Player{Name="Marcia Bybee", ID=33, Number=3, Position="Offense", TeamID=3 },
                new Player{Name="Ferdinand Pawlak", ID=34, Number=4, Position="Defense", TeamID=3 },
                new Player{Name="Anjanette Moodie", ID=35, Number=5, Position="Offense", TeamID=3 },
                new Player{Name="Carmelina Sancho", ID=36, Number=6, Position="Defense", TeamID=3 },
                new Player{Name="Blanca Newlin", ID=37, Number=7, Position="Offense", TeamID=3 },
                new Player{Name="Evalyn Sarmiento", ID=38, Number=8, Position="Defense", TeamID=3 },
                new Player{Name="Nannette Degreenia", ID=39, Number=9, Position="Offense", TeamID=3 },
                new Player{Name="Sharita Peel", ID=40, Number=10, Position="Defense", TeamID=3 },
                new Player{Name="Felicidad Stairs", ID=41, Number=11, Position="Offense", TeamID=3 },
                new Player{Name="Daniel Madriz", ID=42, Number=12, Position="Defense", TeamID=3 },
                new Player{Name="Kyla Dials", ID=43, Number=13, Position="Goalie", TeamID=3 },
                new Player{Name="Merna Mathews", ID=44, Number=14, Position="Defense", TeamID=3 },
                new Player{Name="Elena Looby", ID=45, Number=15, Position="Defense", TeamID=3 },
                new Player{Name="Elli Zahn", ID=46, Number=1, Position="Offense", TeamID=4 },
                new Player{Name="Jenine Remick", ID=47, Number=2, Position="Defense", TeamID=4 },
                new Player{Name="Florencia Pirtle", ID=48, Number=3, Position="Offense", TeamID=4 },
                new Player{Name="Coletta Buss", ID=49, Number=4, Position="Defense", TeamID=4 },
                new Player{Name="Ellena Guillen", ID=50, Number=5, Position="Offense", TeamID=4 },
                new Player{Name="Donny Ort", ID=51, Number=6, Position="Offense", TeamID=4 },
                new Player{Name="Karima Gorski", ID=52, Number=7, Position="Defense", TeamID=4 },
                new Player{Name="Joanna Casali", ID=53, Number=8, Position="Offense", TeamID=4 },
                new Player{Name="Audrey Odonnell", ID=54, Number=9, Position="Offense", TeamID=4 },
                new Player{Name="Eugena Etsitty", ID=55, Number=10, Position="Defense", TeamID=4 },
                new Player{Name="Charlott Marsico", ID=56, Number=11, Position="Offense", TeamID=4 },
                new Player{Name="Claudio Knappenberger", ID=57, Number=12, Position="Offense", TeamID=4 },
                new Player{Name="Chauncey Torgeson", ID=58, Number=13, Position="Defense", TeamID=4 },
                new Player{Name="Harry Holmen", ID=59, Number=14, Position="Goalie", TeamID=4 },
                new Player{Name="Hortensia Eagles", ID=60, Number=15, Position="Defense", TeamID=4 },
                new Player{Name="Adelaida Gutter", ID=61, Number=1, Position="Offense", TeamID=5 },
                new Player{Name="Eura Perdue", ID=62, Number=2, Position="Offense", TeamID=5 },
                new Player{Name="Jeanice Sinclair", ID=63, Number=3, Position="Defense", TeamID=5 },
                new Player{Name="Marshall Rayos", ID=64, Number=4, Position="Offense", TeamID=5 },
                new Player{Name="Jess Standridge", ID=65, Number=5, Position="Offense", TeamID=5 },
                new Player{Name="Cuc Deibert", ID=66, Number=6, Position="Defense", TeamID=5 },
                new Player{Name="Prince Marrs", ID=67, Number=7, Position="Offense", TeamID=5 },
                new Player{Name="Antoine Brainard", ID=68, Number=8, Position="Defense", TeamID=5 },
                new Player{Name="Stephani Cookingham", ID=69, Number=9, Position="Offense", TeamID=5 },
                new Player{Name="Leigha Mcgrail", ID=70, Number=10, Position="Offense", TeamID=5 },
                new Player{Name="Claribel Josephson", ID=71, Number=11, Position="Offense", TeamID=5 },
                new Player{Name="Iraida Glascock", ID=72, Number=12, Position="Defense", TeamID=5 },
                new Player{Name="Mirta Meachum", ID=73, Number=13, Position="Offense", TeamID=5 },
                new Player{Name="China Bowne", ID=74, Number=14, Position="Defense", TeamID=5 },
                new Player{Name="Millie Mirza", ID=75, Number=15, Position="Goalie", TeamID=5 },
                new Player{Name="Willa Dicus", ID=76, Number=1, Position="Defense", TeamID=6 },
                new Player{Name="Janee Gail", ID=77, Number=2, Position="Offense", TeamID=6 },
                new Player{Name="Nancie Pouncy", ID=78, Number=3, Position="Defense", TeamID=6 },
                new Player{Name="Lucinda Sugg", ID=79, Number=4, Position="Offense", TeamID=6 },
                new Player{Name="Linwood Danker", ID=80, Number=5, Position="Offense", TeamID=6 },
                new Player{Name="Evalyn Phillippe", ID=81, Number=6, Position="Defense", TeamID=6 },
                new Player{Name="Noah Rinker", ID=82, Number=7, Position="Offense", TeamID=6 },
                new Player{Name="Voncile Geist", ID=83, Number=8, Position="Defense", TeamID=6 },
                new Player{Name="Alma Erben", ID=84, Number=9, Position="Offense", TeamID=6 },
                new Player{Name="Jung Brammer", ID=85, Number=10, Position="Offense", TeamID=6 },
                new Player{Name="Gilma Margulies", ID=86, Number=11, Position="Offense", TeamID=6 },
                new Player{Name="Bettyann Sim", ID=87, Number=12, Position="Defense", TeamID=6 },
                new Player{Name="Princess Ruggieri", ID=88, Number=13, Position="Offense", TeamID=6 },
                new Player{Name="Oretha Bierce", ID=89, Number=14, Position="Defense", TeamID=6 },
                new Player{Name="Fernande Bosse", ID=90, Number=15, Position="Goalie", TeamID=6 }
            };
            Players.ForEach(s => context.Players.Add(s));
            List<Team> Teams = new List<Team>
            {
                new Team{ID=1, Name="Boston Bruins", Coach="Jim James", Manager="Doug Dimmadome"},
                new Team{ID=2, Name="Toronto Maple Leafs", Coach="Stan Steele", Manager="Leslie Lao"},
                new Team{ID=3, Name="Montreal Canadiens", Coach="Paul Pile", Manager="Paul Pile"},
                new Team{ID=4, Name="Chicago Black Hawks", Coach="Tyreese Tyrone", Manager="Jamal James"},
                new Team{ID=5, Name="Detroit Red Wings", Coach="Dan Dan", Manager="Stan Stan"},
                new Team{ID=6, Name="New York Rangers", Coach="Munkee Man", Manager="Dunkee Dan"}
            };
            Teams.ForEach(s => context.Teams.Add(s));
            List<WinLoss> Wins = new List<WinLoss>
            {
                new WinLoss{Winner=1, Loser=2, ID=0},
                new WinLoss{Winner=1, Loser=3, ID=1},
                new WinLoss{Winner=1, Loser=4, ID=2},
                new WinLoss{Winner=1, Loser=5, ID=3},
                new WinLoss{Winner=1, Loser=6, ID=4},
                new WinLoss{Winner=2, Loser=1, ID=5},
                new WinLoss{Winner=2, Loser=3, ID=6},
                new WinLoss{Winner=2, Loser=4, ID=7},
                new WinLoss{Winner=2, Loser=5, ID=8},
                new WinLoss{Winner=2, Loser=6, ID=9},
                new WinLoss{Winner=3, Loser=1, ID=10},
                new WinLoss{Winner=3, Loser=2, ID=11},
                new WinLoss{Winner=3, Loser=4, ID=12},
                new WinLoss{Winner=3, Loser=5, ID=13},
                new WinLoss{Winner=3, Loser=6, ID=14},
                new WinLoss{Winner=4, Loser=1, ID=15},
                new WinLoss{Winner=4, Loser=2, ID=16},
                new WinLoss{Winner=4, Loser=3, ID=17},
                new WinLoss{Winner=4, Loser=5, ID=18},
                new WinLoss{Winner=4, Loser=6, ID=19},
                new WinLoss{Winner=5, Loser=1, ID=20},
                new WinLoss{Winner=5, Loser=2, ID=21},
                new WinLoss{Winner=5, Loser=3, ID=22},
                new WinLoss{Winner=5, Loser=4, ID=23},
                new WinLoss{Winner=5, Loser=6, ID=24},
                new WinLoss{Winner=6, Loser=1, ID=25},
                new WinLoss{Winner=6, Loser=2, ID=26},
                new WinLoss{Winner=6, Loser=3, ID=27},
                new WinLoss{Winner=6, Loser=4, ID=28},
                new WinLoss{Winner=6, Loser=5, ID=29},
                new WinLoss{Winner=2, Loser=3, ID=30},
                new WinLoss{Winner=4, Loser=5, ID=31},
                new WinLoss{Winner=3, Loser=2, ID=32},
                new WinLoss{Winner=4, Loser=3, ID=33},
                new WinLoss{Winner=6, Loser=2, ID=34},
                new WinLoss{Winner=3, Loser=5, ID=35},
                new WinLoss{Winner=2, Loser=4, ID=36},
                new WinLoss{Winner=4, Loser=6, ID=37},
                new WinLoss{Winner=5, Loser=4, ID=38},
                new WinLoss{Winner=1, Loser=3, ID=39},
                new WinLoss{Winner=6, Loser=5, ID=40},
                new WinLoss{Winner=3, Loser=4, ID=41},
                new WinLoss{Winner=4, Loser=6, ID=42},
                new WinLoss{Winner=2, Loser=3, ID=43},
                new WinLoss{Winner=1, Loser=2, ID=44},
                new WinLoss{Winner=3, Loser=2, ID=45},
                new WinLoss{Winner=4, Loser=1, ID=46},
                new WinLoss{Winner=1, Loser=3, ID=47},
                new WinLoss{Winner=1, Loser=2, ID=48},
                new WinLoss{Winner=3, Loser=2, ID=49},
                new WinLoss{Winner=1, Loser=2, ID=50},
                new WinLoss{Winner=4, Loser=1, ID=51},
                new WinLoss{Winner=1, Loser=2, ID=52},
                new WinLoss{Winner=3, Loser=2, ID=53},
                new WinLoss{Winner=4, Loser=1, ID=54},
                new WinLoss{Winner=1, Loser=2, ID=55},
                new WinLoss{Winner=2, Loser=3, ID=56},
                new WinLoss{Winner=1, Loser=3, ID=57},
                new WinLoss{Winner=3, Loser=4, ID=58},
                new WinLoss{Winner=1, Loser=6, ID=59}
            };
            Wins.ForEach(s => context.Games.Add(s));
            List<Sponsor> Sponsors = new List<Sponsor>
            {
                new Sponsor{ID=1, Name="Coca-Cola", Team=1},
                new Sponsor{ID=2, Name="Pepsi", Team=2},
                new Sponsor{ID=3, Name="Honda", Team=3},
                new Sponsor{ID=4, Name="Ford", Team=4},
                new Sponsor{ID=5, Name="Tesla", Team=5},
                new Sponsor{ID=6, Name="Red Cross", Team=6}
            };
            Sponsors.ForEach(s => context.Sponsors.Add(s));
            context.SaveChanges();
        }
    }
}