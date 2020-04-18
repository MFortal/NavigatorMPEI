namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFields : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Items", name: "Building_Id", newName: "BuildingId");
            RenameColumn(table: "dbo.Items", name: "Level_Id", newName: "LevelId");
            RenameColumn(table: "dbo.Items", name: "Node_Id", newName: "NodeId");
            RenameColumn(table: "dbo.Items", name: "TypeItem_Id", newName: "TypeItemId");
            RenameColumn(table: "dbo.Nodes", name: "Node_Id", newName: "Nodes_Id");
            RenameIndex(table: "dbo.Items", name: "IX_Level_Id", newName: "IX_LevelId");
            RenameIndex(table: "dbo.Items", name: "IX_Building_Id", newName: "IX_BuildingId");
            RenameIndex(table: "dbo.Items", name: "IX_TypeItem_Id", newName: "IX_TypeItemId");
            RenameIndex(table: "dbo.Items", name: "IX_Node_Id", newName: "IX_NodeId");
            RenameIndex(table: "dbo.Nodes", name: "IX_Node_Id", newName: "IX_Nodes_Id");
            AddColumn("dbo.Nodes", "NextId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nodes", "NextId");
            RenameIndex(table: "dbo.Nodes", name: "IX_Nodes_Id", newName: "IX_Node_Id");
            RenameIndex(table: "dbo.Items", name: "IX_NodeId", newName: "IX_Node_Id");
            RenameIndex(table: "dbo.Items", name: "IX_TypeItemId", newName: "IX_TypeItem_Id");
            RenameIndex(table: "dbo.Items", name: "IX_BuildingId", newName: "IX_Building_Id");
            RenameIndex(table: "dbo.Items", name: "IX_LevelId", newName: "IX_Level_Id");
            RenameColumn(table: "dbo.Nodes", name: "Nodes_Id", newName: "Node_Id");
            RenameColumn(table: "dbo.Items", name: "TypeItemId", newName: "TypeItem_Id");
            RenameColumn(table: "dbo.Items", name: "NodeId", newName: "Node_Id");
            RenameColumn(table: "dbo.Items", name: "LevelId", newName: "Level_Id");
            RenameColumn(table: "dbo.Items", name: "BuildingId", newName: "Building_Id");
        }
    }
}
