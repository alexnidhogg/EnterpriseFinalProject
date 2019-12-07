using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using EnterpriseFinalProject.Models;

namespace EnterpriseFinalProject.Data_Access
{
    public class Data_Context : DbContext
    {
        public Data_Context() : base("HockeyTeamsDB") {}
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<WinLoss> Games { get; set; }
        public DbSet<WinLossRecord> Records { get; set; }
        public DbSet<Roster> Rosters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}