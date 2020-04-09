namespace Navigator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableRepair : DbMigration
    {
        public override void Up()
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
            CreateIndex("dbo.Item", "RepairId");
            AddForeignKey("dbo.Item", "RepairId", "dbo.Repair", "Id", cascadeDelete: true);
            DropColumn("dbo.Item", "Repaired");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "Repaired", c => c.Boolean());
            DropForeignKey("dbo.Item", "RepairId", "dbo.Repair");
            DropIndex("dbo.Item", new[] { "RepairId" });
            DropColumn("dbo.Item", "RepairId");
            DropTable("dbo.Repair");
        }
    }
}
