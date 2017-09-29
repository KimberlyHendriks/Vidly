namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepairMembershipTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId_Id", "dbo.MembershipTypes");
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            DropIndex("dbo.Customers", new[] { "MembershipTypeId_Id" });
            RenameColumn(table: "dbo.Customers", name: "MembershipType_Id", newName: "MembershipTypeId");
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: true));
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: true));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "MembershipTypeId_Id");
            DropColumn("dbo.MembershipTypes", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Type", c => c.String());
            AddColumn("dbo.Customers", "MembershipTypeId_Id", c => c.Byte());
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte());
            DropColumn("dbo.MembershipTypes", "Name");
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeId", newName: "MembershipType_Id");
            CreateIndex("dbo.Customers", "MembershipTypeId_Id");
            CreateIndex("dbo.Customers", "MembershipType_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
            AddForeignKey("dbo.Customers", "MembershipTypeId_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
