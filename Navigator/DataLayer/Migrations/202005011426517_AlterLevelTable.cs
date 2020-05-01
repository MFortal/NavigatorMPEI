namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterLevelTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item", "BuildingId", "dbo.Building");
            DropIndex("dbo.Item", new[] { "BuildingId" });
            AddColumn("dbo.Level", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Level", "BuildingId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Level", "BuildingId");
            AddForeignKey("dbo.Level", "BuildingId", "dbo.Building", "Id", cascadeDelete: true);
            DropColumn("dbo.Item", "BuildingId");
            DropColumn("dbo.Level", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Level", "Name", c => c.Int(nullable: false));
            AddColumn("dbo.Item", "BuildingId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Level", "BuildingId", "dbo.Building");
            DropIndex("dbo.Level", new[] { "BuildingId" });
            DropColumn("dbo.Level", "BuildingId");
            DropColumn("dbo.Level", "Number");
            CreateIndex("dbo.Item", "BuildingId");
            AddForeignKey("dbo.Item", "BuildingId", "dbo.Building", "Id", cascadeDelete: true);
        }
    }
}
