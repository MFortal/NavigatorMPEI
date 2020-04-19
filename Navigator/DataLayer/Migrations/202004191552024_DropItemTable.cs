namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropItemTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item", "BuildingId", "dbo.Building");
            DropForeignKey("dbo.Item", "Item_Id", "dbo.Item");
            DropForeignKey("dbo.Item", "LevelId", "dbo.Level");
            DropForeignKey("dbo.Item", "NodeId", "dbo.Node");
            DropForeignKey("dbo.Item", "TypeItemId", "dbo.TypeItem");
            DropIndex("dbo.Item", new[] { "LevelId" });
            DropIndex("dbo.Item", new[] { "BuildingId" });
            DropIndex("dbo.Item", new[] { "TypeItemId" });
            DropIndex("dbo.Item", new[] { "NodeId" });
            DropIndex("dbo.Item", new[] { "Item_Id" });
            DropTable("dbo.Item");
        }
        
        public override void Down()
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
                        Item_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Item", "Item_Id");
            CreateIndex("dbo.Item", "NodeId");
            CreateIndex("dbo.Item", "TypeItemId");
            CreateIndex("dbo.Item", "BuildingId");
            CreateIndex("dbo.Item", "LevelId");
            AddForeignKey("dbo.Item", "TypeItemId", "dbo.TypeItem", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Item", "NodeId", "dbo.Node", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Item", "LevelId", "dbo.Level", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Item", "Item_Id", "dbo.Item", "Id");
            AddForeignKey("dbo.Item", "BuildingId", "dbo.Building", "Id", cascadeDelete: true);
        }
    }
}
