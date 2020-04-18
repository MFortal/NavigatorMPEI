namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SingularTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Buildings", newName: "Building");
            RenameTable(name: "dbo.Items", newName: "Item");
            RenameTable(name: "dbo.Levels", newName: "Level");
            RenameTable(name: "dbo.Nodes", newName: "Node");
            RenameTable(name: "dbo.TypeItems", newName: "TypeItem");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TypeItem", newName: "TypeItems");
            RenameTable(name: "dbo.Node", newName: "Nodes");
            RenameTable(name: "dbo.Level", newName: "Levels");
            RenameTable(name: "dbo.Item", newName: "Items");
            RenameTable(name: "dbo.Building", newName: "Buildings");
        }
    }
}
