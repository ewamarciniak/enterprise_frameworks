namespace gymapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassGym : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GymClasses",
                c => new
                    {
                        GymClassID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        ActivityID = c.Int(nullable: false),
                        ClassDate = c.DateTime(nullable: false),
                        DurationInMinutes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GymClassID)
                .ForeignKey("dbo.Activities", t => t.ActivityID, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.ActivityID)
                .Index(t => t.RoomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GymClasses", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.GymClasses", "ActivityID", "dbo.Activities");
            DropIndex("dbo.GymClasses", new[] { "RoomID" });
            DropIndex("dbo.GymClasses", new[] { "ActivityID" });
            DropTable("dbo.GymClasses");
        }
    }
}
