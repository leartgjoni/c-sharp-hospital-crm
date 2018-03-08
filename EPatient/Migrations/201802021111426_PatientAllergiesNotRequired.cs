namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientAllergiesNotRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "Allergies", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Allergies", c => c.String(nullable: false));
        }
    }
}
