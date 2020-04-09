namespace Navigator.Migrations
{
    using Navigator.Models.DataModels;
    using Navigator.Models.SourceSeed;
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;

    internal sealed class Configuration : DbMigrationsConfiguration<NavigatorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NavigatorContext context)
        {
            //context.Buildings.AddOrUpdate(BuildingInitializer.Initialize());
            //context.Levels.AddOrUpdate(LevelInitializer.Initialize());
            //context.TypeItems.AddOrUpdate(TypeItemInitializer.Initialize());
            //context.Nodes.AddOrUpdate(NodeInitializer.Initialize());
            //context.Items.AddOrUpdate(ItemInitializer.Initialize());

            //try 
            //{
            //    context.SaveChanges();
            //}    
            //catch (DbEntityValidationException e)
            //{
            //    foreach (var ev in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            ev.Entry.Entity.GetType().Name, ev.Entry.State);
            //        foreach (var ve in ev.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
        }
    }
}
