namespace gymapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMedicalHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicalHistories",
                c => new
                    {
                        MedicalHistoryID = c.Int(nullable: false, identity: true),
                        RecentlyHospitalized = c.Boolean(nullable: false),
                        HighBloodPressure = c.Boolean(nullable: false),
                        HighCholesterol = c.Boolean(nullable: false),
                        Diabetes = c.Boolean(nullable: false),
                        HeartAttackOrStroke = c.Boolean(nullable: false),
                        HeartConditions = c.Boolean(nullable: false),
                        BackProblems = c.Boolean(nullable: false),
                        Allergies = c.String(),
                        Medication = c.String(),
                        ChronicIlnesses = c.String(),
                        Other = c.String(),
                    })
                .PrimaryKey(t => t.MedicalHistoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MedicalHistories");
        }
    }
}
