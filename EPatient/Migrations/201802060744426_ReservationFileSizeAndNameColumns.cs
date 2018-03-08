namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservationFileSizeAndNameColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "FileName", c => c.String(maxLength: 255));
            AddColumn("dbo.Reservations", "FileSize", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "FileSize");
            DropColumn("dbo.Reservations", "FileName");
        }
    }
}
