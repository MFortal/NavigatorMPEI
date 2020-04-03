using System.Data.Entity;

namespace Navigator.Models.DataModels
{
    public class NavigatorContext : DbContext
    {
        public NavigatorContext() : base("NavigatorConnection")
            {
            }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<TypeItem> TypeItems { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Level>().HasIndex(x => x.Name).IsUnique();
            //modelBuilder.Entity<Building>().HasIndex(x => x.Name).IsUnique();
            //modelBuilder.Entity<TypeItem>().HasIndex(x => x.Name).IsUnique();
        }


    }
}