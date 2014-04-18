namespace gymapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CaloriesPerHour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Activities");
        }
    }
}
