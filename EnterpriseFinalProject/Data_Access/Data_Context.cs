using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using EnterpriseFinalProject.Models;
using EnterpriseFinalProject.DAL;

// Written by Alex Teodorescu
// Links the database to the web page using EDF

namespace EnterpriseFinalProject.Data_Access
{
    public class Data_Context : DbContext
    {
        // Names database
        public Data_Context() : base("HockeyTeamsDB") {}
        // Teams Table
        public DbSet<Team> Teams { get; set; }
        // Players Table
        public DbSet<Player> Players { get; set; }
        // Games Table
        public DbSet<WinLoss> Games { get; set; }
        // Sponsors Table
        public DbSet<Sponsor> Sponsors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Data_Initializer dataIni = new Data_Initializer();
            Database.SetInitializer<Data_Context>(dataIni);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}