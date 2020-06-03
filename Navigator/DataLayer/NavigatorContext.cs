using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DataLayer.Models.DataModels;

namespace DataLayer
{
    public class NavigatorContext : DbContext
    {
        // Передача имени строки подключения в конструктор
        public NavigatorContext() : base("NavigatorConnection")
        {
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<TypeItem> TypeItems { get; set; }

        // Именование таблиц БД в единственном числе
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}