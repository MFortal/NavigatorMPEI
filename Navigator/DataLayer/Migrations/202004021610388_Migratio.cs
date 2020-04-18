namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migratio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);
                //.Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Repaired = c.Boolean(),
                        Number = c.String(),
                        Building_Id = c.Int(nullable: false),
                        Item_Id = c.Int(),
                        Level_Id = c.Int(nullable: false),
                        Node_Id = c.Int(nullable: false),
                        TypeItem_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buildings", t => t.Building_Id, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .ForeignKey("dbo.Levels", t => t.Level_Id, cascadeDelete: true)
                .ForeignKey("dbo.Nodes", t => t.Node_Id, cascadeDelete: true)
                .ForeignKey("dbo.TypeItems", t => t.TypeItem_Id, cascadeDelete: true)
                .Index(t => t.Building_Id)
                .Index(t => t.Item_Id)
                .Index(t => t.Level_Id)
                .Index(t => t.Node_Id)
                .Index(t => t.TypeItem_Id);

            CreateTable(
                "dbo.Levels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
                //.Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Nodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        Node_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nodes", t => t.Node_Id)
                .Index(t => t.Node_Id);

            CreateTable(
                "dbo.TypeItems",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);
                //.Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "TypeItem_Id", "dbo.TypeItems");
            DropForeignKey("dbo.Items", "Node_Id", "dbo.Nodes");
            DropForeignKey("dbo.Nodes", "Node_Id", "dbo.Nodes");
            DropForeignKey("dbo.Items", "Level_Id", "dbo.Levels");
            DropForeignKey("dbo.Items", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Items", "Building_Id", "dbo.Buildings");
           // DropIndex("dbo.TypeItems", new[] { "Name" });
            DropIndex("dbo.Nodes", new[] { "Node_Id" });
          //  DropIndex("dbo.Levels", new[] { "Name" });
            DropIndex("dbo.Items", new[] { "TypeItem_Id" });
            DropIndex("dbo.Items", new[] { "Node_Id" });
            DropIndex("dbo.Items", new[] { "Level_Id" });
            DropIndex("dbo.Items", new[] { "Item_Id" });
            DropIndex("dbo.Items", new[] { "Building_Id" });
           // DropIndex("dbo.Buildings", new[] { "Name" });
            DropTable("dbo.TypeItems");
            DropTable("dbo.Nodes");
            DropTable("dbo.Levels");
            DropTable("dbo.Items");
            DropTable("dbo.Buildings");
        }
    }
}
