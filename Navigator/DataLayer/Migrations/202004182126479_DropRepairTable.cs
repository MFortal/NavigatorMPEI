namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropRepairTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item", "RepairId", "dbo.Repair");
            DropIndex("dbo.Item", new[] { "RepairId" });
            AddColumn("dbo.Item", "Repair", c => c.Boolean(nullable: false));
            AddColumn("dbo.TypeItem", "Code", c => c.Int(nullable: false));
            DropColumn("dbo.Item", "RepairId");
            DropTable("dbo.Repair");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Repair",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Item", "RepairId", c => c.Int(nullable: false));
            DropColumn("dbo.TypeItem", "Code");
            DropColumn("dbo.Item", "Repair");
            CreateIndex("dbo.Item", "RepairId");
            AddForeignKey("dbo.Item", "RepairId", "dbo.Repair", "Id", cascadeDelete: true);
        }
    }
}
