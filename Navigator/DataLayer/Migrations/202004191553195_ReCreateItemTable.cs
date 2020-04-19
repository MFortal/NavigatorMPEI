namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReCreateItemTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Number = c.String(),
                        Repair = c.Boolean(nullable: false),
                        LevelId = c.Int(nullable: false),
                        BuildingId = c.Int(nullable: false),
                        TypeItemId = c.Int(nullable: false),
                        NodeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Building", t => t.BuildingId, cascadeDelete: true)
                .ForeignKey("dbo.Level", t => t.LevelId, cascadeDelete: true)
                .ForeignKey("dbo.Node", t => t.NodeId, cascadeDelete: true)
                .ForeignKey("dbo.TypeItem", t => t.TypeItemId, cascadeDelete: true)
                .Index(t => t.LevelId)
                .Index(t => t.BuildingId)
                .Index(t => t.TypeItemId)
                .Index(t => t.NodeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "TypeItemId", "dbo.TypeItem");
            DropForeignKey("dbo.Item", "NodeId", "dbo.Node");
            DropForeignKey("dbo.Item", "LevelId", "dbo.Level");
            DropForeignKey("dbo.Item", "BuildingId", "dbo.Building");
            DropIndex("dbo.Item", new[] { "NodeId" });
            DropIndex("dbo.Item", new[] { "TypeItemId" });
            DropIndex("dbo.Item", new[] { "BuildingId" });
            DropIndex("dbo.Item", new[] { "LevelId" });
            DropTable("dbo.Item");
        }
    }
}
