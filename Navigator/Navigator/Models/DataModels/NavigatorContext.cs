﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Navigator.Models.DataModels
{
    public class NavigatorContext : DbContext
    {
        public NavigatorContext() : base("NavigatorContext")
            {
            }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Object> Objects { get; set; }
        public DbSet<TypeObject> TypeObjects { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Level>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Building>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<TypeObject>().HasIndex(x => x.Name).IsUnique();
        }


    }
}