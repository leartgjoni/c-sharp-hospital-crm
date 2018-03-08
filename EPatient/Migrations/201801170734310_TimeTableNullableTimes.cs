namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeTableNullableTimes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Timetables", "StartTime", c => c.DateTime());
            AlterColumn("dbo.Timetables", "EndTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Timetables", "EndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Timetables", "StartTime", c => c.DateTime(nullable: false));
        }
    }
}
