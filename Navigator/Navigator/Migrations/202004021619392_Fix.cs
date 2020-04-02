namespace Navigator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Buildings", new[] { "Name" });
            DropIndex("dbo.Levels", new[] { "Name" });
            DropIndex("dbo.TypeItems", new[] { "Name" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.TypeItems", "Name", unique: true);
            CreateIndex("dbo.Levels", "Name", unique: true);
            CreateIndex("dbo.Buildings", "Name", unique: true);
        }
    }
}
