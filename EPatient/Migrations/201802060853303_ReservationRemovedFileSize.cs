namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservationRemovedFileSize : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "FileSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "FileSize", c => c.Int(nullable: false));
        }
    }
}
