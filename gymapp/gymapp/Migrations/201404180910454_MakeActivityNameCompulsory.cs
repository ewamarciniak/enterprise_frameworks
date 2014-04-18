namespace gymapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeActivityNameCompulsory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "Name", c => c.String());
        }
    }
}
