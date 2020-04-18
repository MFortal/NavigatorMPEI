namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixNodeForeignKey : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Node", name: "Nodes_Id", newName: "NextNodeId");
            RenameIndex(table: "dbo.Node", name: "IX_Nodes_Id", newName: "IX_NextNodeId");
            DropColumn("dbo.Node", "NextId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Node", "NextId", c => c.Int());
            RenameIndex(table: "dbo.Node", name: "IX_NextNodeId", newName: "IX_Nodes_Id");
            RenameColumn(table: "dbo.Node", name: "NextNodeId", newName: "Nodes_Id");
        }
    }
}
