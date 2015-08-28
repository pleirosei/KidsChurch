namespace KidsChurch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserCondition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        nickName = c.String(),
                        phoneNumber = c.String(),
                        address = c.String(),
                        primaryGuardian = c.String(),
                        secondaryGuardian = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CheckIns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ChildID = c.Int(nullable: false),
                        checkedIn = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Children", t => t.ChildID, cascadeDelete: true)
                .Index(t => t.ChildID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckIns", "ChildID", "dbo.Children");
            DropIndex("dbo.CheckIns", new[] { "ChildID" });
            DropTable("dbo.CheckIns");
            DropTable("dbo.Children");
        }
    }
}
