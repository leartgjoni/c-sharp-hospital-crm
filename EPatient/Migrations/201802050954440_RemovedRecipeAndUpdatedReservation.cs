namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedRecipeAndUpdatedReservation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Recipes", "ReservationId", "dbo.Reservations");
            DropIndex("dbo.Recipes", new[] { "ReservationId" });
            AddColumn("dbo.Reservations", "Done", c => c.Boolean(nullable: false));
            AddColumn("dbo.Reservations", "Recipe", c => c.String());
            AddColumn("dbo.Reservations", "File", c => c.Binary());
            DropTable("dbo.Recipes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Body = c.String(nullable: false),
                        ReservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Reservations", "File");
            DropColumn("dbo.Reservations", "Recipe");
            DropColumn("dbo.Reservations", "Done");
            CreateIndex("dbo.Recipes", "ReservationId");
            AddForeignKey("dbo.Recipes", "ReservationId", "dbo.Reservations", "Id", cascadeDelete: true);
        }
    }
}
