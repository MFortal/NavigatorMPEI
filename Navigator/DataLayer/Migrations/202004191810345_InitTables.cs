namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Building",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Description = c.String(),
                        Number = c.String(),
                        Repair = c.Boolean(nullable: false),
                        LevelId = c.Guid(nullable: false),
                        BuildingId = c.Guid(nullable: false),
                        TypeItemId = c.Guid(nullable: false),
                        NodeId = c.Guid(nullable: false),
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
            
            CreateTable(
                "dbo.Level",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Node",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        NextNodeId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Node", t => t.NextNodeId)
                .Index(t => t.NextNodeId);
            
            CreateTable(
                "dbo.TypeItem",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "TypeItemId", "dbo.TypeItem");
            DropForeignKey("dbo.Item", "NodeId", "dbo.Node");
            DropForeignKey("dbo.Node", "NextNodeId", "dbo.Node");
            DropForeignKey("dbo.Item", "LevelId", "dbo.Level");
            DropForeignKey("dbo.Item", "BuildingId", "dbo.Building");
            DropIndex("dbo.Node", new[] { "NextNodeId" });
            DropIndex("dbo.Item", new[] { "NodeId" });
            DropIndex("dbo.Item", new[] { "TypeItemId" });
            DropIndex("dbo.Item", new[] { "BuildingId" });
            DropIndex("dbo.Item", new[] { "LevelId" });
            DropTable("dbo.TypeItem");
            DropTable("dbo.Node");
            DropTable("dbo.Level");
            DropTable("dbo.Item");
            DropTable("dbo.Building");
        }
    }
}
